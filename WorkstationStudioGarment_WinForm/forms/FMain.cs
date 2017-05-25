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
    public partial class FMain : MetroFramework.Forms.MetroForm
    {


        private FAuthorization f = new FAuthorization();
        private CLIENT client;
        private List<PRODUCT> listProduct = new List<PRODUCT>(); //список всех продуктов
        private OrderControlModule orderControl = new OrderControlModule();
        private Image mannequinImg; //картинка с манекеном
        private List<Image> clothes = new List<Image>(); //фотки, добавленные на манекен
        private List<PRODUCT> listSelectedProduct = new List<PRODUCT>(); //список выбранных и добавленных на манекен продуктов
        private ClientControl clientControl = new ClientControl();
        private TanyaModule tanyaM = new TanyaModule();
        private int saleSize = 10;

        private List<PRODUCT> filteredListProduct = new List<PRODUCT>();

        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            f.ShowDialog();

            client = f.OurClient;
            if (client == null)
            {
                Application.Exit();
            }
            else
            {
                lblClientLogin.Text = client.login;

                LoadFilters();
                LoadProductView();
            }
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
            UpdateMannequinList();
        }

        private void UpdateMannequinList()
        {
            listBoxClothesOnMannequin.Items.Clear();//очищаем листбокс перед обновлением
            foreach (var pr in listSelectedProduct)
            {
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

        public void DrawClothesOnMannequin(List<Image> clothes)
        {
            SolidBrush br = new SolidBrush(Color.White);
            Image img = new Bitmap(pbMannequin.Width, pbMannequin.Height);
            Graphics gr = Graphics.FromImage(img);
            gr.FillRectangle(br, 0, 0, pbMannequin.Width, pbMannequin.Height);

            gr.DrawImage(mannequinImg, 0, 0, pbMannequin.Width, pbMannequin.Height);

            foreach (Image i in clothes)
            {
                gr.DrawImage(i, 0, 0, pbMannequin.Width, pbMannequin.Height);
            }
            pbMannequin.Image = img;
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FTanyaModule f = new FTanyaModule();
            f.ShowDialog();
        }

        private void lblClientLogin_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                List<CLIENT> client = clientControl.SearchClientByLogin(lblClientLogin.Text);
                if (client == null)
                {
                    MessageBox.Show("Ошибка", "Такого клиента не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                if (client[0].access_level == 1)
                {
                    FPersonalAreaAdmin f = new FPersonalAreaAdmin();
                    f.ShowDialog();
                }
                else
                {
                    FPersonalAreaUser f = new FPersonalAreaUser();
                    f.SetClient(client[0]);
                    f.ClearSelectedProducts();
                    f.SetSelectedProducts(listSelectedProduct);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mlCategoryExpander_Click(object sender, EventArgs e)
        {
            if (mPanelCategoryExpand.Visible)
            {
                mPanelCategoryExpand.Visible = false;
                mlCategoryExpander.Text = "Категория >>";
            }
            else
            {
                mPanelCategoryExpand.Visible = true;
                mlCategoryExpander.Text = "Категория <<";
            }
        }

        private void mlColorExpander_Click(object sender, EventArgs e)
        {
            if (mPanelColorExpand.Visible)
            {
                mPanelColorExpand.Visible = false;
                mlColorExpander.Text = "Цвет >>";
            }
            else
            {
                mPanelColorExpand.Visible = true;
                mlColorExpander.Text = "Цвет <<";
            }
        }

        private void mlSizeExpander_Click(object sender, EventArgs e)
        {
            if (mPanelSizeExpand.Visible)
            {
                mPanelSizeExpand.Visible = false;
                mlSizeExpander.Text = "Размер >>";
            }
            else
            {
                mPanelSizeExpand.Visible = true;
                mlSizeExpander.Text = "Размер <<";
            }
        }

        private void LoadFilters()
        {
            try
            {
                FiltersModule filtersModule = new FiltersModule();
                cListBoxCategories.Items.AddRange(filtersModule.GetCategoriesList().ToArray());
                cListBoxColors.Items.AddRange(filtersModule.GetColorsList().ToArray());
                cListBoxSize.Items.AddRange(filtersModule.GetSizeList().ToArray());
                for (int i = 0; i < cListBoxCategories.Items.Count; i++)
                {
                    cListBoxCategories.SetItemChecked(i, true);
                }
                for (int i = 0; i < cListBoxColors.Items.Count; i++)
                {
                    cListBoxColors.SetItemChecked(i, true);
                }
                for (int i = 0; i < cListBoxSize.Items.Count; i++)
                {
                    cListBoxSize.SetItemChecked(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadProductView()
        {
            try
            {
                if (client.sex == 1)
                {
                    mannequinImg = Image.FromFile(@"res\images\Man.png");
                }
                else
                {
                    mannequinImg = Image.FromFile(@"res\images\Woman.png");
                }

                listProduct.Clear();
                if (tanyaM.ShoppersList()
                    .Where(x => x.id_client == client.id_client)
                    .ToList().Count != 0)
                {
                    
                    listProduct = orderControl.AllProducts();
                    for(int i = 0; i < listProduct.Count; i++)
                    {
                        listProduct[i].price = DecrementPercentages(listProduct[i].price, (decimal) saleSize);
                    }

                    lblSaleInfo.Text = "Вам предоставлена специальная скидка на товары в размере " + saleSize + "%";
                }
                else
                {
                    listProduct = orderControl.AllProducts();

                    lblSaleInfo.Text = "";
                }

                //рисуем изначальный манекен
                DrawClothesOnMannequin(clothes);

                // извлекаются все изображения и добавляются в imagelist
                imageList.Images.Clear();

                foreach (var product in listProduct)
                {
                    imageList.Images.Add(ImgConverter.ImageFromString(product.photo));
                }

                //все продукты добавляются в listView 
                UpdateListViewProducts();

                clothes.Clear(); //очищаем список добавленных на манекен вещей
                listSelectedProduct.Clear(); //очищаем список выбранных нами вещей
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateListViewProducts()
        {
            listViewProducts.Items.Clear();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (cBoxUserOptions.Checked)
                {
                    FPersonalAreaUser u = new FPersonalAreaUser();
                    u.SetClient(client);
                    int size = u.CalculateTheSize();

                    if (listProduct[i].size == size)
                    {
                        listViewProducts.Items.Add(new ListViewItem(listProduct[i].title.ToString() + "\n" +
                                                            listProduct[i].price.ToString(), i));
                    }
                }
                else if (cListBoxCategories
                        .GetItemChecked(cListBoxCategories.Items.IndexOf(listProduct[i].category)) &&
                    cListBoxColors
                        .GetItemChecked(cListBoxColors.Items.IndexOf(listProduct[i].color)) &&
                    cListBoxSize
                        .GetItemChecked(cListBoxSize.Items.IndexOf(listProduct[i].size.ToString())))
                {
                    listViewProducts.Items.Add(new ListViewItem(listProduct[i].title.ToString() + "\n" +
                                                            listProduct[i].price.ToString(), i));
                }
            }
        }

        private void cListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListViewProducts();
        }

        private void cListBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListViewProducts();
        }

        private void cListBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListViewProducts();
        }

        private void mlUpProduct_Click(object sender, EventArgs e)
        {
            if (listBoxClothesOnMannequin.SelectedIndex == -1)
            {
                return;
            }

            if (listBoxClothesOnMannequin.SelectedIndex == 0)
            {
                return;
            }

            int newSelItem = listBoxClothesOnMannequin.SelectedIndex - 1;

            PRODUCT curItem = listSelectedProduct[listBoxClothesOnMannequin.SelectedIndex];
            listSelectedProduct[listBoxClothesOnMannequin.SelectedIndex] =
                listSelectedProduct[newSelItem];
            listSelectedProduct[newSelItem] = curItem;

            Image curImg = clothes[listBoxClothesOnMannequin.SelectedIndex];
            clothes[listBoxClothesOnMannequin.SelectedIndex] =
                clothes[newSelItem];
            clothes[newSelItem] = curImg;

            UpdateMannequinList();
            DrawClothesOnMannequin(clothes);

            listBoxClothesOnMannequin.SetSelected(newSelItem, true);


        }

        private void mlDownProduct_Click(object sender, EventArgs e)
        {
            if (listBoxClothesOnMannequin.SelectedIndex == -1)
            {
                return;
            }

            if (listBoxClothesOnMannequin.SelectedIndex ==
                listBoxClothesOnMannequin.Items.Count - 1)
            {
                return;
            }

            int newSelItem = listBoxClothesOnMannequin.SelectedIndex + 1;

            PRODUCT curItem = listSelectedProduct[listBoxClothesOnMannequin.SelectedIndex];
            listSelectedProduct[listBoxClothesOnMannequin.SelectedIndex] =
                listSelectedProduct[newSelItem];
            listSelectedProduct[newSelItem] = curItem;

            Image curImg = clothes[listBoxClothesOnMannequin.SelectedIndex];
            clothes[listBoxClothesOnMannequin.SelectedIndex] =
                clothes[newSelItem];
            clothes[newSelItem] = curImg;


            UpdateMannequinList();
            DrawClothesOnMannequin(clothes);

            listBoxClothesOnMannequin.SetSelected(newSelItem, true);


        }

        private void mlRemoveProduct_Click(object sender, EventArgs e)
        {
            if (listBoxClothesOnMannequin.SelectedIndex == -1)
            {
                return;
            }

            listSelectedProduct.RemoveAt(listBoxClothesOnMannequin.SelectedIndex);
            clothes.RemoveAt(listBoxClothesOnMannequin.SelectedIndex);
            UpdateMannequinList();
            DrawClothesOnMannequin(clothes);
        }

        private decimal DecrementPercentages(decimal sum, decimal percent)
        {
            percent = percent / 100;
            return sum - sum * percent;
        }

        private void cBoxUserOptions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListViewProducts();
        }
    }
}