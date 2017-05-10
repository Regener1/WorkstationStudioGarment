using WorkstationStudioGarment_WinForm.manager;
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
using WorkstationStudioGarment_WinForm.tool;
using WorkstationStudioGarment_WinForm.modules;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FMain : Form
    {
        FAuthorization f = new FAuthorization();
        CLIENT client;
        List<PRODUCT> listProduct = new List<PRODUCT>(); //список всех продуктов
        //DbManager dbManager = new DbManager();
        OrderControlModule orderControl = new OrderControlModule();
        Image mannequinImg; //картинка с манекеном
        List<Image> clothes = new List<Image>(); //фотки, добавленные на манекен
        List<PRODUCT> listSelectedProduct = new List<PRODUCT>(); //список выбранных и добавленных на манекен продуктов
        ClientControl clientControl = new ClientControl();
        public FMain()
        {
            InitializeComponent();
        }

        //public void SetClient(CLIENT client) { 
        //    this.client = client;
        //}
        private void FMain_Load(object sender, EventArgs e)
        {
            
            f.ShowDialog();
          
            client = f.ourClient;
            if (client == null) {
                MessageBox.Show("Ошибка", "Ошибка при авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblClientLogin.Text = client.login;
            //if (client.sex == 1)
            //{
            //    mannequinImg = Image.FromFile(@"C:/Users/User/Documents/Visual Studio 2013/Projects/kursach/WorkstationStudioGarment/WorkstationStudioGarment_WinForm/photos/Man.png");
            //}
            //else
            //{
            //    mannequinImg = Image.FromFile(@"C:/Users/User/Documents/Visual Studio 2013/Projects/kursach/WorkstationStudioGarment/WorkstationStudioGarment_WinForm/photos/Woman.png");
            //}

            mannequinImg = new Bitmap(pbMannequin.Width, pbMannequin.Height);

            //string srt = dbManager.ImageToString(Image.FromFile(@"C:/Users/User/Documents/Visual Studio 2013/Projects/kursach/WorkstationStudioGarment/WorkstationStudioGarment_WinForm/photos/штаны муж.png"));
            //рисуем изначальный манекен
            DrawClothesOnMannequin(clothes);

            //список всех продуктов
            listProduct.Clear();
            listProduct = orderControl.AllProducts();

            // извлекаются все изображения из бд и добавляются в imagelist
            imageList.Images.Clear();
            try
            {
                foreach (var product in listProduct)
                {
                    imageList.Images.Add(ImgConverter.ImageFromString(product.photo));
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            //все продукты добавляются в listView 
            listViewProducts.Clear();
            for(int i = 0; i < listProduct.Count; i++)  
            {
                listViewProducts.Items.Add(new ListViewItem(listProduct[i].title.ToString() + "\n" +
                                                            listProduct[i].price.ToString(), i));
            } 

            clothes.Clear(); //очищаем список добавленных на манекен вещей
            listSelectedProduct.Clear(); //очищаем список выбранных нами вещей

        }

        private void lvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            int index;
            if (listViewProducts.SelectedIndices.Count > 0)
            {
                //на манекен мы перетаскиваем индекс одежды, на котором она находилась в listProduct
                index = listViewProducts.SelectedIndices[0];
                listViewProducts.DoDragDrop(index.ToString(), DragDropEffects.Move | DragDropEffects.Copy);
            }
        }

        private void panelMannequin_DragDrop(object sender, DragEventArgs e)
        {
            //индекс = индекс в listProduct
            int index_selected_product = Int32.Parse(e.Data.GetData(DataFormats.Text).ToString());
            Image img = ImgConverter.ImageFromString(listProduct[index_selected_product].photo);
            if (listSelectedProduct.Contains(listProduct[index_selected_product]))
            {
                return;
            } 

            clothes.Add(img);

            DrawClothesOnMannequin(clothes); //отрисовка всех изображений на манекене

            //
            //вывод в листбокс выбранных нами продуктов
            //
            listSelectedProduct.Add(listProduct[index_selected_product]); //сначала добавляем их в обычный список
            PRODUCT selPoduct = listProduct[index_selected_product]; //выбранный продукт
            listBoxClothesOnMannequin.Items.Clear();//очищаем листбокс перед обновлением
            foreach (var pr in listSelectedProduct) {
                listBoxClothesOnMannequin.Items.Add(pr.title + ", Размер: " + pr.size + ", Цена: " + pr.price);
            }
        }

        private void panelMannequin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        public void DrawClothesOnMannequin(List<Image> clothes) { 
            SolidBrush br = new SolidBrush(Color.White);
            Image img = new Bitmap(pbMannequin.Width, pbMannequin.Height);
            Graphics gr = Graphics.FromImage(img);
            gr.FillRectangle(br, 0, 0, pbMannequin.Width, pbMannequin.Height);

            gr.DrawImage(mannequinImg, 0, 0, pbMannequin.Width, pbMannequin.Height);

            foreach(Image i in clothes)
            {
                gr.DrawImage(i, 0, 0, pbMannequin.Width, pbMannequin.Height);
            }
            pbMannequin.Image = img;
        }

        private void lblClientLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<CLIENT> client = clientControl.SearchClientByLogin(lblClientLogin.Text);
            if (client == null) {
                MessageBox.Show("Ошибка", "Такого клиента не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            if (client[0].access_level == 1)
            {
                FPersonalAreaAdmin f = new FPersonalAreaAdmin();
                f.ShowDialog();
            }
            else {
                FPersonalAreaUser f = new FPersonalAreaUser();
                f.SetClient(client[0]);
                f.ClearSelectedProducts();
                f.SetSelectedProducts(listSelectedProduct);
                f.ShowDialog();

            }
        }

		
		private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //for (int i = 0; i < listSelectedProduct.Count; i++) {
            //    BASKET b = new BASKET();
            //    b.id_client = client.id_client;
            //    b.id_product = listSelectedProduct[i].id_product;
            //    b.count = 1;
            //    b.id_order = -1;
            //    orderControl.Add(b);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPreferenceModule upm = new UserPreferenceModule(client);
            try
            {
                upm.Load();
                List<PRODUCT> userPreference = upm.GetPreferenceList();
                if (userPreference.Count != 0)
                {
                    FUserPreference fUserpreference = new FUserPreference();
                    fUserpreference.ProductsList = userPreference;
                    fUserpreference.Upm = upm;
                    fUserpreference.Show();
                }
                Console.WriteLine("Thread Stop");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Thread Stop Exception");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FTanyaModule f = new FTanyaModule();
            f.ShowDialog();
        }
    }
}