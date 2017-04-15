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
using WorkstationStudioGarment_WinForm.modules;
using WorkstationStudioGarment_WinForm.tool;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FPersonalAreaAdmin : Form
    {

        private ProductControlModule productsControlS = new ProductControlModule();

        private List<SUPPLY> lSupplies = new List<SUPPLY>();
        private List<PRODUCT> lProducts = new List<PRODUCT>();
        private List<ProductStructureContainer> lProductStructure = new List<ProductStructureContainer>();

        public FPersonalAreaAdmin()
        {
            InitializeComponent();
        }

        private void ClearAllLists()
        {
            lSupplies.Clear();
            lProducts.Clear();
            lProductStructure.Clear();
            lvSupplies.Items.Clear();
            lvProducts.Items.Clear();
            lvProductStructure.Items.Clear();
        }

        private void btnLoadSupplies_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAllLists();

                lSupplies = productsControlS.AllSupplies();

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
                if (lvSupplies.SelectedIndices.Count == 0)
                {
                    return;
                }
                lProducts.Clear();
                lvProducts.Items.Clear();
                lProducts = productsControlS.GetSuppliesProducts(lSupplies[lvSupplies.SelectedIndices[0]]);

                if (lProducts.Count != 0)
                {
                    foreach (PRODUCT p in lProducts)
                    {
                        lvProducts.Items.Add(new ListViewItem(new string[] { p.id_product.ToString(), p.title,
                                                                    p.category, p.size.ToString(),
                                                                    p.color, p.price.ToString(),
                                                                    p.count.ToString(), p.id_supply.ToString()}));
                    }
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
                if(lvProducts.SelectedIndices.Count == 0)
                {
                    return;
                }
                Image photo = ImgConverter.ImageFromString(lProducts[lvProducts.SelectedIndices[0]].photo);
                pictureBoxPhoto.Image = photo;

                PRODUCT product = lProducts[lvProducts.SelectedIndices[0]];

                lProductStructure.Clear();
                lvProductStructure.Items.Clear();
                lProductStructure = productsControlS.GetProductStructure(product);


                foreach (ProductStructureContainer ps in lProductStructure)
                {
                    lvProductStructure.Items.Add(new ListViewItem(new string[] { ps.MaterialName, ps.Count.ToString() }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (lvSupplies.SelectedIndices.Count > 0)
            {
                FAddProduct fAddProduct = new FAddProduct();
                fAddProduct.IdSupply = lSupplies[lvSupplies.SelectedIndices[0]].id_supply;
                fAddProduct.ShowDialog();

                PRODUCT newProduct = fAddProduct.GetProduct();

                if(newProduct != null)
                {
                    lProducts.Add(newProduct);
                    lvProducts.Items.Add(new ListViewItem(new string[] { newProduct.id_product.ToString(), newProduct.title,
                                                                    newProduct.category, newProduct.size.ToString(),
                                                                    newProduct.color, newProduct.price.ToString(),
                                                                    newProduct.count.ToString(), newProduct.id_supply.ToString()}));
                }

            }

        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            FAddSupply fAddSupply = new FAddSupply();
            fAddSupply.ShowDialog();
            SUPPLY newSupply = fAddSupply.GetSupply();

            if (newSupply != null)
            {
                lSupplies.Add(newSupply);
                lvSupplies.Items.Add(new ListViewItem(new string[] { newSupply.id_supply.ToString(), newSupply.delivery_date }));
            }
        }

        private void btnAddProductStructure_Click(object sender, EventArgs e)
        {
            FAddProductStructure fAddProductStructure = new FAddProductStructure();
            fAddProductStructure.IdProduct = lProducts[lvProducts.SelectedIndices[0]].id_product;
            fAddProductStructure.ShowDialog();

            lProductStructure.Clear();
            lvProductStructure.Items.Clear();
            lProductStructure = fAddProductStructure.GetProductStructure();

            if (lProductStructure != null)
            {

                foreach(ProductStructureContainer pse in lProductStructure)
                {
                    lvProductStructure.Items.Add(new ListViewItem(new string[] { pse.MaterialName, pse.Count.ToString() }));
                }
                
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ClientService cs = new ClientService();
            List<CLIENT> clients = cs.All();
            cs.Delete(clients[0]);
        }

        private void btnMaterialEditor_Click(object sender, EventArgs e)
        {
            FMaterialEditor fMaterialEditor = new FMaterialEditor();
            fMaterialEditor.ShowDialog();
        }

        
    }
}
