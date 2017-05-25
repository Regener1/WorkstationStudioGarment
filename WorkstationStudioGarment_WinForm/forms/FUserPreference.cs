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
        Dictionary<string, int> categories;
        Dictionary<string, int> names;
        Dictionary<string, int> colors;

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

        public UserPreferenceModule Upm
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
            tbPriceBegin.Text = upm.MinPrice.ToString();
            tbPriceEnd.Text = upm.MaxPrice.ToString();


            categories = new Dictionary<string, int>();
            names = new Dictionary<string, int>();
            colors = new Dictionary<string, int>();

            foreach (var item in upm.Names)
            {
                names.Add(item.Key, item.Value);
                checkedLBNames.Items.Add(item.Key);
            }

            foreach (var item in upm.Categories)
            {
                categories.Add(item.Key, item.Value);
                checkedLBCategories.Items.Add(item.Key);
            }

            foreach (var item in upm.Colors)
            {
                colors.Add(item.Key, item.Value);
                checkedLBColors.Items.Add(item.Key);
            }


        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(upm.GetRules());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            flpProductsView.Controls.Clear();
            upm.MinPrice = decimal.Parse(tbPriceBegin.Text);
            upm.MaxPrice = decimal.Parse(tbPriceEnd.Text);
            
            upm.ApplyUserFilter();
            productsList = upm.GetPreferenceList();
            foreach (PRODUCT entity in productsList)
            {
                string description = entity.title + Environment.NewLine
                                     + entity.category + Environment.NewLine
                                     + entity.color + Environment.NewLine
                                     + entity.price.ToString();

                ProductViewPanel pvPanel = new ProductViewPanel();
                pvPanel.pbPhoto.Image = ImgConverter.ImageFromString(entity.photo);
                pvPanel.tbDescription.Text = description;
                flpProductsView.Controls.Add(pvPanel);
            }
        }

        private void checkedLBNames_SelectedValueChanged(object sender, EventArgs e)
        {
            Dictionary<string, int> categories = new Dictionary<string, int>();
            Dictionary<string, int> names = new Dictionary<string, int>();
            Dictionary<string, int> colors = new Dictionary<string, int>();


            for (int i = 0; i < this.names.Count; i++)
            {
                if (checkedLBNames.GetItemChecked(i))
                {
                    names.Add(this.names.Keys.ToList()[i], 0);
                }
            }
            for (int i = 0; i < this.categories.Count; i++)
            {
                if (checkedLBCategories.GetItemChecked(i))
                {
                    categories.Add(this.categories.Keys.ToList()[i], 0);
                }
            }
            for (int i = 0; i < this.colors.Count; i++)
            {
                if (checkedLBColors.GetItemChecked(i))
                {
                    colors.Add(this.colors.Keys.ToList()[i], 0);
                }
            }
            upm.Names = names;
            upm.Categories = categories;
            upm.Colors = colors;
        }
    }
}
