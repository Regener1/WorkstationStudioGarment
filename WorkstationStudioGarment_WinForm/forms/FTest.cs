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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FTest : Form
    {
        private Image image;
        private ProductControl pc = new ProductControl();

        public FTest()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    pc.AddProduct(tbCategory.Text, tbCategory.Text, Convert.ToInt32(tbSize.Text),
            //                tbColor.Text, image, Convert.ToDecimal(tbPrice.Text),);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(ofd.FileName);
                pictureBox1.Image = image;
            }
        }

        private void btnInsertSupply_Click(object sender, EventArgs e)
        {
            try
            {
                int id = pc.AddProductIntoSupply(tbDeliveryDate.Text, Convert.ToInt32(tbCount.Text));

                pc.AddProduct(tbCategory.Text, tbCategory.Text, Convert.ToInt32(tbSize.Text),
                            tbColor.Text, image, Convert.ToDecimal(tbPrice.Text), id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
