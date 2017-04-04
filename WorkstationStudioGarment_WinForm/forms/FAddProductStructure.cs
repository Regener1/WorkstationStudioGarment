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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FAddProductStructure : Form
    {

        private int idProduct = -1;
        private ProductsService pManager = new ProductsService();
        private List<MATERIAL> materials;
        private List<ProductStructureEntity> psEntities;

        public FAddProductStructure()
        {
            InitializeComponent();
        }

        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (cbMaterial.SelectedIndex == -1)
            {
                return;
            }

            ProductStructureEntity ps = new ProductStructureEntity();
            ps.MaterialName = materials[cbMaterial.SelectedIndex].name;
            ps.Count = Convert.ToInt32(nudCount.Value);
            ps.IdMaterial = materials[cbMaterial.SelectedIndex].id_material;

            psEntities.Add(ps);

            lvProductStucture.Items.Clear();
            foreach (ProductStructureEntity pse in psEntities)
            {
                lvProductStucture.Items.Add(new ListViewItem(new string[]
                                                            { pse.MaterialName,
                                                              pse.Count.ToString()
                                                            }));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ProductStructureEntity pse in psEntities)
                {
                    PRODUCT_STRUCTURE productStruct = new PRODUCT_STRUCTURE();
                    productStruct.id_product = idProduct;
                    productStruct.id_material = pse.IdMaterial;
                    productStruct.count = pse.Count;
                    pManager.Add(productStruct);
                }

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FAddProductStructure_Load(object sender, EventArgs e)
        {
            materials = pManager.GetAllMaterials();

            for (int i = 0; i < materials.Count; i++)
            {
                cbMaterial.Items.Add(materials[i].name);
            }

        }
    }
}
