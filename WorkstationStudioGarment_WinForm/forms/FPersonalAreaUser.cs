using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.containers;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.modules;
using WorkstationStudioGarment_WinForm.tool;
using WorkstationStudioGarment_WinForm.user_controls;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FPersonalAreaUser : MetroFramework.Forms.MetroForm
    {
        ClientControlModule clientModule = new ClientControlModule();
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
            this.listSelectedProduct.AddRange(listSelectedProduct);
        }

        public FPersonalAreaUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Очищаем список выбранных нами вещей
        /// </summary>
        public void ClearSelectedProducts()
        {
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
            SetCientInfo();
            SetProductInfo();
            FillListControls();
            FillClientOrdersInfo();
            SetSize(CalculateTheSize());
        }

        private void SetSize(int size)
        {
            lblSize.Text = size.ToString();
        }

        public int CalculateTheSize() {
            int size = 56;
            int ch = client.chest;
            int wa = client.waist;
            int hip = client.hip;
            if (client.sex == 0)
            {
                if ((ch >= 80 && ch < 84) || (wa >= 62 && wa < 66) || (hip >= 86 && hip < 92))
                    size = 40;
                if ((ch >= 84 && ch < 88) || (wa >= 66 && wa < 70) || (hip >= 92 && hip < 96))
                    size = 42;
                if ((ch >= 88 && ch < 92) || (wa >= 70 && wa < 74) || (hip >= 96 && hip < 100))
                    size = 44;
                if ((ch >= 92 && ch < 96) || (wa >= 74 && wa < 78) || (hip >= 100 && hip < 104))
                    size = 46;
                if ((ch >= 96 && ch < 100) || (wa >= 78 && wa < 82) || (hip >= 104 && hip < 108))
                    size = 48;
                if ((ch >= 100 && ch < 104) || (wa >= 82 && wa < 86) || (hip >= 108 && hip < 112))
                    size = 50;
                if ((ch >= 104 && ch < 108) || (wa >= 86 && wa < 90) || (hip >= 112 && hip < 116))
                    size = 52;
                if ((ch >= 108 && ch < 112) || (wa >= 90 && wa < 94) || (hip >= 116 && hip < 120))
                    size = 54;
            }
            else {
                size = 60;
                if ((ch >= 88 && ch < 92) || (wa >= 70 && wa < 76) || (hip >= 92 && hip < 96))
                    size = 44;
                if ((ch >= 92 && ch < 96) || (wa >= 76 && wa < 82) || (hip >= 96 && hip < 100))
                    size = 46;
                if ((ch >= 96 && ch < 100) || (wa >= 82 && wa < 88) || (hip >= 100 && hip < 104))
                    size = 48;
                if ((ch >= 100 && ch < 104) || (wa >= 88 && wa < 94) || (hip >= 104 && hip < 108))
                    size = 50;
                if ((ch >= 104 && ch < 108) || (wa >= 94 && wa < 100) || (hip >= 108 && hip < 112))
                    size = 52;
                if ((ch >= 108 && ch < 112) || (wa >= 82 && wa < 86) || (hip >= 112 && hip < 116))
                    size = 54;
                if ((ch >= 112 && ch < 116) || (wa >= 106 && wa < 112) || (hip >= 116 && hip < 120))
                    size = 56;
                if ((ch >= 116 && ch < 120) || (wa >= 112 && wa < 118) || (hip >= 120 && hip < 124))
                    size = 58;
            }

            return size;
        }

        private void SetCientInfo()
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
        }

        /// <summary>
        /// Вывод информации о количестве товара в корзине на форму
        /// </summary>
        public void SetProductInfo()
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
            UpdateBasketList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            listSelectedProduct.RemoveAt(
                ((sender as MetroFramework.Controls.MetroLink).Parent as UserControlBasket).ID);
            UpdateBasketList();
        }

        private void UpdateBasketList()
        {
            try
            {
                listControls.Clear();
                panelProduct.Controls.Clear();

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
                    us.ID = i;

                    ///
                    ///Проверка на возможность пошить товар, если его нет на складе
                    ///
                    if (availability)
                    {
                        us.nUDCount.Value = 1;
                        us.nUDCount.Maximum = orderModule.GetProductLimit(pr);
                    }
                    else
                    {
                        us.nUDCount.Value = 0;
                        us.nUDCount.Maximum = orderModule.GetSewingLimit(pr);
                        if (us.nUDCount.Maximum == 0)
                        {
                            s += "В данный момент отсутствуют материалы для пошива этого товара";
                        }
                        else
                        {
                            s += "Вы можете заказать этот товар на пошив";
                        }
                    }
                    us.tbInfo.Text = "Наименование: " + pr.title + Environment.NewLine +
                                     "Размер: " + pr.size + Environment.NewLine +
                                     "Цвет: " + pr.color + Environment.NewLine +
                                     "Цена: " + pr.price + Environment.NewLine +
                                     s;
                    us.pb.Image = ImgConverter.ImageFromString(pr.photo);
                    us.tbTotal.Text = (us.nUDCount.Value * pr.price).ToString();

                    us.nUDCount.ValueChanged += nUDCount_ValueChanged;
                    listControls.Add(us);
                    panelProduct.Controls.Add(us);
                    us.btnRemove.Click += BtnRemove_Click;
                }

                SetProductInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillClientOrdersInfo()
        {
            List<ClientProductContainer> lClientsProducts = clientModule.GetClientsProduct(client);
            if (lClientsProducts.Count != 0)
            {
                mGridClientOrders.Rows.Clear();
                foreach (var item in lClientsProducts)
                {

                    mGridClientOrders.Rows.Add(new string[] { item.Product.id_product.ToString(),
                                                              item.Product.title, item.Product.category,
                                                              item.Product.size.ToString(),
                                                              item.Product.color,
                                                              item.Date.ToString("dd.MM.yyyy"), item.Time.ToString("H:M:s"),
                                                              item.Product.price.ToString(),
                                                              item.Count.ToString(), item.Price.ToString() });
                }
            }
        }

        void nUDCount_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listControls.Count; i++)
            {
                if (listControls[i].nUDCount.Value == 0)
                    listControls[i].nUDCount.BackColor = Color.Red;
                else
                    listControls[i].nUDCount.BackColor = Color.White;
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
                client.surname = tbSurname.Text;
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
                decimal totalSum = 0;
                for (int i = 0; i < listSelectedProduct.Count; i++)
                {
                    if (listControls[i].nUDCount.Value == 0)
                    {
                        continue;
                    }
                    totalSum += decimal.Parse(listControls[i].tbTotal.Text);
                }

                if (totalSum == 0)
                {
                    return;
                }

                ORDER o = new ORDER();
                o.order_date = DateTime.Today.ToString("d");
                o.order_status = 0; 
                o.order_time = DateTime.Now.ToString("H:M:s");
                o.total_sum = totalSum;
                orderModule.AddOrder(o);

                for (int i = 0; i < listSelectedProduct.Count; i++)
                {
                    bool availability = orderModule.CheckForAvailability(listSelectedProduct[i]);

                    //если не можем пошить товар или выбрано кол-во 0, не записываем его в корзину
                    if (listControls[i].nUDCount.Value == 0)
                    {
                        continue;
                    }

                    BASKET b = new BASKET();
                    b.id_client = client.id_client;
                    b.id_product = listSelectedProduct[i].id_product;
                    b.count = (int)(listControls[i].nUDCount.Value);
                    b.id_order = o.id_order;
                    orderModule.AddBasket(b);

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

                CreatePDF(listSelectedProduct);
                ///
                ///функция для создания пдф
                ///



                MessageBox.Show("Ваш заказ успешно оформлен");

                listSelectedProduct.Clear();
                SetProductInfo();
                listControls.Clear();
                FillListControls();
                Update();
                metroTabControl1.SelectedTab = tabPage3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreatePDF(List<PRODUCT> list) { 
            
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroTabControl1.SelectedIndex == 2)
            {
                FillClientOrdersInfo(); 
            }
        }

        private void tbChest_TextChanged(object sender, EventArgs e)
        {
            CalculateTheSize();
        }

        private void tbWaist_TextChanged(object sender, EventArgs e)
        {
            CalculateTheSize();
        }

        private void tbHip_TextChanged(object sender, EventArgs e)
        {
            CalculateTheSize();
        }
    }
}
