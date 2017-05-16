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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FEditProduct : MetroFramework.Forms.MetroForm
    {
        private ProductControlModule productsControlS = new ProductControlModule();
        private PRODUCT product;

        public PRODUCT Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public FEditProduct()
        {
            InitializeComponent();
        }

        private void FEditProduct_Load(object sender, EventArgs e)
        {
            tbName.Text = product.title;
            tbCategory.Text = product.category;
            tbSize.Text = product.size.ToString();
            tbColor.Text = product.color;
            pictureBoxPhoto.Image = ImgConverter.ImageFromString(product.photo);
            tbPrice.Text = product.price.ToString();
            tbCount.Text = product.count.ToString();
        }

        public PRODUCT GetProduct()
        {
            return product;
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PNG (*png) | *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.Image = Image.FromFile(ofd.FileName);
                }

                tbPath.Text = ofd.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                product.title = tbName.Text;
                product.category = tbCategory.Text;
                product.size = Convert.ToInt32(tbSize.Text);
                product.color = tbColor.Text;
                product.photo = ImgConverter.ImageToString(pictureBoxPhoto.Image);
                product.price = Convert.ToInt32(tbPrice.Text);
                product.count = Convert.ToInt32(tbCount.Text);

                productsControlS.Update(product);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
