﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.modules;
using WorkstationStudioGarment_WinForm.tool;
using WorkstationStudioGarment_WinForm.user_controls;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FPersonalAreaUser : Form
    {
        ClientControlModule clientModule = new ClientControlModule();
        //ProductControlModule productModule = new ProductControlModule();
        CLIENT client = new CLIENT();
        List<PRODUCT> listSelectedProduct = new List<PRODUCT>();
        OrderControlModule orderModule = new OrderControlModule();
        List<UserControlBasket> listControls = new List<UserControlBasket>();

        /// <summary>
        /// Передача текущего клиента в класс формы
        /// </summary>
        /// <param name="client"></param>
        public void SetClient(CLIENT client)
        {
            this.client = client;
        }
        /// <summary>
        /// Передача выбранных продуктов на форму
        /// </summary>
        /// <param name="listSelectedProduct"></param>
        public void SetSelectedProducts(List<PRODUCT> listSelectedProduct)
        {
            this.listSelectedProduct = listSelectedProduct;
        }
        public FPersonalAreaUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Очищаем список выбранных нами вещей
        /// </summary>
        public void ClearSelectedProducts() {
            listSelectedProduct.Clear(); 
        }
        /// <summary>
        ///  Удаление аккаунта клиента
        /// </summary>
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                clientModule.Delete(client);
                MessageBox.Show("Ваш аккаунт успешно удалён");
                FAuthorization f = new FAuthorization();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FPersonalAreaUser_Load(object sender, EventArgs e)
        {
            try
            {
                tbSurname.Text = client.surname;
                tbName.Text = client.name;
                tbPhone.Text = client.phone_number;
                tbPatronymic.Text = client.patronymic;
                tbMail.Text = client.mail;
                tbChest.Text = client.chest.ToString();
                tbGrowth.Text = client.growth.ToString();
                tbPassword.Text = client.password;
                tbHip.Text = client.hip.ToString();
                tbWaist.Text = client.waist.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SetInfo();
            FillListControls();
        }

        /// <summary>
        /// Вывод информации о количестве товара в корзине на форму
        /// </summary>
        public void SetInfo() 
        {
            if (listSelectedProduct.Count > 0)
            {
                lblInfo.Visible = false;
                btnMain.Visible = false;
                lblCountProducts.Text = "Товаров в корзине: " + listSelectedProduct.Count;
                btnCreateOrder.Enabled = true;
                Update();
            }
            else
            {
                lblInfo.Visible = true;
                btnMain.Visible = true;
                lblCountProducts.Text = "Товаров в корзине: 0";
                btnCreateOrder.Enabled = false;
                Update();
            }
        }
        /// <summary>
        /// Заполнение списка с выбранными продуктами на вкладке корзина 
        /// </summary>
        public void FillListControls() 
        {
            try 
            {
                int Y = 0;
                for (int i = 0; i < listSelectedProduct.Count; i++)
                {
                    PRODUCT pr = listSelectedProduct[i];
                    bool availability = orderModule.CheckForAvailability(pr);
                    string s = "";
                    switch (availability) 
                    {
                        case true:
                            s = "Наличие на складе: Да";
                            break;
                        case false: 
                            s = "Наличие на складе: Нет -> ";
                            break;
                    }
                    
                    UserControlBasket us = new UserControlBasket();

                    ///
                    ///Проверка на возможность пошить товар, если его нет на складе
                    ///
                    if (availability) 
                    {
                        us.nUDCount.Value = 1;
                        us.nUDCount.Maximum = orderModule.GetProductLimit(pr);
                    } else {
                        us.nUDCount.Value = 0;
                        us.nUDCount.Maximum = orderModule.GetSewingLimit(pr);
                        if (us.nUDCount.Maximum == 0) { 
                           s += "В данный момент отсутствуют материалы для пошива этого товара";
                        } else {
                           s += "Вы можете заказать этот товар на пошив";
                        }
                    }
                    us.tbInfo.Text = "Наименование " + pr.title + Environment.NewLine +
                                     "Размер: " + pr.size + Environment.NewLine +
                                     "Цвет: " + pr.color + Environment.NewLine +
                                     "Цена: " + pr.price + Environment.NewLine +
                                     s;
                    us.pb.Image = ImgConverter.ImageFromString(pr.photo); 
                    us.tbTotal.Text = (us.nUDCount.Value * pr.price).ToString();

                    us.Location = new Point(0, Y);
                    us.nUDCount.ValueChanged += nUDCount_ValueChanged;
                    listControls.Add(us);
                    panelProduct.Controls.Add(us);
                    Y += us.Height;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        void nUDCount_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listControls.Count; i++)
            {
                listControls[i].tbTotal.Text = (listControls[i].nUDCount.Value * 
                                                listSelectedProduct[i].price).ToString();
            }
        }

        /// <summary>
        /// Редактирование сведений о клиенте
        /// </summary>
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                client.surname= tbSurname.Text;
                client.name = tbName.Text;
                client.phone_number = tbPhone.Text;
                client.patronymic = tbPatronymic.Text;
                client.mail = tbMail.Text;
                client.chest = Int32.Parse(tbChest.Text);
                client.growth = Int32.Parse(tbGrowth.Text);
                client.password = tbPassword.Text;
                client.hip = Int32.Parse(tbHip.Text);
                client.waist = Int32.Parse(tbWaist.Text);

                clientModule.Update(client);
                MessageBox.Show("Данные успешно обновлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Оформление данных в таблицу "заказ" и "корзина" 
        /// </summary>
        /// <remarks="При оформлении заказа кол-во товара в наличие уменьшается на кол-во купленного"></remarks>
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try 
            {
                ORDER o = new ORDER();
                o.order_date = DateTime.Today.ToString("d");
                o.order_status = 0; //какие цифры вообще должны использоваться?
                o.order_time = DateTime.Now.ToString("H:M:s");
                orderModule.AddOrder(o);

                for (int i = 0; i < listSelectedProduct.Count; i++)
                {
                    bool availability = orderModule.CheckForAvailability(listSelectedProduct[i]);

                    //если не можем пошить товар или выбрано кол-во 0, не записываем его в корзину
                    if (listControls[i].nUDCount.Maximum == 0 || 
                        listControls[i].nUDCount.Value == 0) 
                    {
                        continue;
                    }

                    BASKET b = new BASKET();
                    b.id_client = client.id_client;
                    b.id_product = listSelectedProduct[i].id_product;
                    b.count = (int)(listControls[i].nUDCount.Value);
                    b.id_order = o.id_order;
                    
                    orderModule.AddBasket(b);

                    o.total_sum += Decimal.Parse(listControls[i].tbTotal.Text);
                    if (availability)
                    {
                        //orderModule.DecreaseCountOfProduct(listSelectedProduct[i], b.count);
                        listSelectedProduct[i].count -= b.count;
                        orderModule.Update(listSelectedProduct[i]);
                    }
                    else 
                    {
                        orderModule.DecreaseMaterialCount(listSelectedProduct[i]);
                    }  
                }

                MessageBox.Show("Ваш заказ успешно оформлен");

                listSelectedProduct.Clear();
                SetInfo();
                listControls.Clear();
                FillListControls();
                Update();
                tabControl1.SelectedTab = tabPage3;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
