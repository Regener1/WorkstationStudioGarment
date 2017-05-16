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
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.modules;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FEditProductStructure : MetroFramework.Forms.MetroForm
    {
        private ProductControlModule productsControlS = new ProductControlModule();
        private List<MATERIAL> lMaterials;
        private List<ProductStructureContainer> psEntities = new List<ProductStructureContainer>();

        public List<ProductStructureContainer> PsEntities
        {
            get
            {
                return psEntities;
            }

            set
            {
                psEntities = value;
            }
        }

        public FEditProductStructure()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            lvProductStucture.Items.Clear();
            foreach (ProductStructureContainer pse in psEntities)
            {
                lvProductStucture.Items.Add(new ListViewItem(new string[]
                                                            { pse.MaterialName,
                                                              pse.Count.ToString()
                                                            }));
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (cbMaterial.SelectedIndex == -1)
            {
                return;
            }

            ProductStructureContainer ps = new ProductStructureContainer();
            ps.MaterialName = lMaterials[cbMaterial.SelectedIndex].name;
            ps.Count = Convert.ToInt32(nudCount.Value);
            ps.IdMaterial = lMaterials[cbMaterial.SelectedIndex].id_material;

            psEntities.Add(ps);

            UpdateList();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ProductStructureContainer pse in psEntities)
                {
                    PRODUCT_STRUCTURE productStruct = new PRODUCT_STRUCTURE();
                    productStruct.id_material = pse.IdMaterial;
                    productStruct.count = pse.Count;
                    productsControlS.Update(productStruct);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FEditProductStructure_Load(object sender, EventArgs e)
        {
            try
            {
                lMaterials = productsControlS.AllMaterials();

                for (int i = 0; i < lMaterials.Count; i++)
                {
                    cbMaterial.Items.Add(lMaterials[i].name);
                }

                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            if(lvProductStucture.SelectedIndices.Count == 0)
            {
                return;
            }

            psEntities.RemoveAt(lvProductStucture.SelectedIndices[0]);

            UpdateList();
        }
    }
}
