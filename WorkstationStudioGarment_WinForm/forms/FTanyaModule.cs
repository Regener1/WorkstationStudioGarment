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
using WorkstationStudioGarment_WinForm.tool;
using WorkstationStudioGarment_WinForm.user_controls;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FTanyaModule : Form
    {
        /// <summary>
        /// Надо резделить всё по классам и функциям
        /// </summary>

        BasketService basketService = new BasketService();
        ProductService productServise = new ProductService();
        List<BASKET> lbasket = new List<BASKET>();
        List<BASKET> listOrder = new List<BASKET>();
        List<PRODUCT> productsList = new List<PRODUCT>();
        List<PRODUCT> Allproducts = new List<PRODUCT>();
        public FTanyaModule()
        {
            InitializeComponent();
        }

        private void FTanyaModule_Load(object sender, EventArgs e)
        {
            lbasket = basketService.All();
            Allproducts = productServise.All();
            foreach (BASKET b in lbasket)
            {
                if (b.id_order != -1)
                {
                    listOrder.Add(b);
                }
            }


            try
            {
                if (listOrder.Count < 10)
                {
                    foreach (BASKET b in listOrder)
                    {
                        foreach (PRODUCT p in Allproducts)
                        {
                            if (b.id_product == p.id_product)
                            {
                                if (!productsList.Contains(p))
                                {
                                    productsList.Add(p);
                                }
                            }
                        }
                    }
                }

                else
                {
                    int count = (20 * listOrder.Count) / 100;
                    while (count > 0)
                    {
                        foreach (BASKET b in listOrder)
                        {
                            foreach (PRODUCT p in Allproducts)
                            {
                                if (b.id_product == p.id_product)
                                {
                                    if (!productsList.Contains(p)) {
                                        productsList.Add(p);
                                    }
                                    
                                }
                            }
                        }
                        count--;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (PRODUCT entity in productsList)
            {
                string description = entity.title + Environment.NewLine
                                     + entity.category + Environment.NewLine
                                     + entity.color + Environment.NewLine
                                     + entity.price.ToString();

                ProductViewPanel pvPanel = new ProductViewPanel();
                //pvPanel.Location = new Point(3,y);
                pvPanel.pbPhoto.Image = ImgConverter.ImageFromString(entity.photo);
                pvPanel.tbDescription.Text = description;
                flpProductsView.Controls.Add(pvPanel);
            }
        }
    }
}
