using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.modules;
using WorkstationStudioGarment_WinForm.tool;
using WorkstationStudioGarment_WinForm.user_controls;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FUserPreference : Form
    {
        private List<PRODUCT> productsList;
        private UserPreferenceModule upm;

        public FUserPreference()
        {
            InitializeComponent();
        }

        public List<PRODUCT> ProductsList
        {
            set
            {
                productsList = value;
            }
        }

        internal UserPreferenceModule Upm
        {
            get
            {
                return upm;
            }

            set
            {
                upm = value;
            }
        }

        private void FUserPreference_Load(object sender, EventArgs e)
        {
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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(upm.GetRules());
        }
    }
}
