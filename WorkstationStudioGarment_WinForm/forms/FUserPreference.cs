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
using WorkstationStudioGarment_WinForm.tool;
using WorkstationStudioGarment_WinForm.user_controls;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FUserPreference : Form
    {
        private List<PRODUCT> productsList;

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

        private void FUserPreference_Load(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            foreach(PRODUCT entity in productsList)
            {
                string description = entity.title + Environment.NewLine
                                     + entity.category + Environment.NewLine
                                     + entity.color + Environment.NewLine
                                     + entity.price.ToString();

                ProductViewPanel pvPanel = new ProductViewPanel();
                pvPanel.Location = new Point(3,y);
                pvPanel.pbPhoto.Image = ImgConverter.ImageFromString(entity.photo);
                pvPanel.tbDescription.Text = description;
                panelProductsView.Controls.Add(pvPanel);
                y += pvPanel.Height + 10;
            }

        }
    }
}
