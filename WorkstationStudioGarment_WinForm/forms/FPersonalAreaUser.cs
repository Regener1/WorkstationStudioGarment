using System;
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
        ClientService clientServise = new ClientService();
        CLIENT client = new CLIENT();
        List<PRODUCT> listSelectedProduct = new List<PRODUCT>();
        OrderControlModule orderControl = new OrderControlModule();
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
                clientServise.Delete(client);
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

            int Y = 0;
            
            for (int i = 0; i < listSelectedProduct.Count; i++)
            {
                UserControlBasket us = new UserControlBasket();
                
                us.tbInfo.Text = "Наименование" + listSelectedProduct[i].title + Environment.NewLine + 
                                 "Размер: "+ listSelectedProduct[i].size + Environment.NewLine + 
                                 "Цвет: "+ listSelectedProduct[i].color+ Environment.NewLine + 
                                 "Цена: "+ listSelectedProduct[i].price+ Environment.NewLine;
                us.pb.Image = ImgConverter.ImageFromString(listSelectedProduct[i].photo);
                us.nUDCount.Value = 1;
                us.nUDCount.Maximum = orderControl.GetProductLimit(listSelectedProduct[i]);
                us.tbTotal.Text = (us.nUDCount.Value * listSelectedProduct[i].price).ToString();

                us.Location = new Point(0, Y);
                us.nUDCount.ValueChanged += nUDCount_ValueChanged;
                listControls.Add(us);
                panelProduct.Controls.Add(us);
                Y += us.Height;
            }


            if (listSelectedProduct.Count > 0)
            {
                lblCountProducts.Text = "Товаров в корзине :" + listSelectedProduct.Count;
            }
            else {
                lblInfo.Visible = true;
                btnMain.Visible = true;
                lblCountProducts.Text = "Товаров в корзине : 0" ;
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
                clientServise.Update(client);
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

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
