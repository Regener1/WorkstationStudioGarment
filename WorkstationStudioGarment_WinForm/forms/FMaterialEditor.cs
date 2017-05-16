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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FMaterialEditor : MetroFramework.Forms.MetroForm
    {
        private ProductControlModule productsControlS = new ProductControlModule();
        private List<MATERIAL> lMaterials = new List<MATERIAL>();

        public FMaterialEditor()
        {
            InitializeComponent();
        }

        private void LoadMaterials()
        {
            try
            {
                lvMaterials.Rows.Clear();
                lMaterials.Clear();
                lMaterials = productsControlS.AllMaterials();

                foreach (MATERIAL m in lMaterials)
                {
                    lvMaterials.Rows.Add(new string[] { m.id_material.ToString(), m.name, m.count.ToString() });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadMaterials_Click(object sender, EventArgs e)
        {
            LoadMaterials();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                MATERIAL newMaterial = new MATERIAL();
                newMaterial.name = tbName.Text;
                newMaterial.count = Convert.ToInt32(nudCount.Value);

                productsControlS.Add(newMaterial);

                LoadMaterials();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
