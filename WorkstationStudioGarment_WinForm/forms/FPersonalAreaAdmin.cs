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
using WorkstationStudioGarment_WinForm.tool;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FPersonalAreaAdmin : Form
    {

        private ProductsManager pManager = new ProductsManager();
        private List<SUPPLY> lSupplies = new List<SUPPLY>();
        private List<PRODUCT> lProducts = new List<PRODUCT>();
        private List<ProductStructureEntity> lProductStructures = new List<ProductStructureEntity>();

        public FPersonalAreaAdmin()
        {
            InitializeComponent();
        }

        private void ClearAllLists()
        {
            lSupplies.Clear();
            lProducts.Clear();
            lProductStructures.Clear();
            lvSupplies.Items.Clear();
            lvProducts.Items.Clear();
            lvProductStructure.Items.Clear();
        }

        private void btnLoadSupplies_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAllLists();

                lSupplies = pManager.GetAllSupplies();

                foreach (SUPPLY s in lSupplies)
                {
                    lvSupplies.Items.Add(new ListViewItem(new string[] { s.id_supply.ToString(), s.delivery_date }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lProducts.Clear();
                int idSupply = lSupplies[lvSupplies.SelectedIndices[0]].id_supply;
                lProducts = pManager.GetSuppliesProducts(idSupply);

                foreach (PRODUCT p in lProducts)
                {
                    lvProducts.Items.Add(new ListViewItem(new string[] { p.id_product.ToString(), p.title,
                                                                    p.category, p.color,
                                                                    p.price.ToString(), p.count.ToString(),
                                                                    p.id_supply.ToString()}));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Image photo = ImgConverter.ImageFromString(lProducts[lvProducts.SelectedIndices[0]].photo);
                pictureBoxPhoto.Image = photo;

                int idProduct = lProducts[lvProducts.SelectedIndices[0]].id_product;

                lProductStructures.Clear();
                lProductStructures = pManager.GetProductStructure(idProduct);

                foreach (ProductStructureEntity ps in lProductStructures)
                {
                    lvProductStructure.Items.Add(new ListViewItem(new string[] { ps.MaterialName, ps.Count.ToString() }));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(lvSupplies.SelectedIndices.Count > 0)
            {
                FAddProduct fAddProduct = new FAddProduct();
                fAddProduct.IdSupply = lSupplies[lvSupplies.SelectedIndices[0]].id_supply;
                fAddProduct.ShowDialog();
                PRODUCT newProduct = fAddProduct.GetProduct();
                lProducts.Add(newProduct);
                lvProducts.Items.Add(new ListViewItem(new string[] { newProduct.id_product.ToString(), newProduct.title,
                                                                    newProduct.category, newProduct.color,
                                                                    newProduct.price.ToString(), newProduct.count.ToString(),
                                                                    newProduct.id_supply.ToString()}));
            }
            
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            FAddSupply fAddSupply = new FAddSupply();
            fAddSupply.ShowDialog();
            SUPPLY newSupply = fAddSupply.GetSupply();
            lSupplies.Add(newSupply);
            lvSupplies.Items.Add(new ListViewItem(new string[] { newSupply.id_supply.ToString(), newSupply.delivery_date }));
        }
    }
}
