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
    public partial class FMaterialEditor : Form
    {
        private ProductControlModule productsControlS = new ProductControlModule();
        private List<MATERIAL> lMaterials = new List<MATERIAL>();

        public FMaterialEditor()
        {
            InitializeComponent();
        }

        private void LoadMaterials()
        {
            lvMaterials.Items.Clear();
            lMaterials.Clear();
            lMaterials = productsControlS.AllMaterials();

            foreach (MATERIAL m in lMaterials)
            {
                lvMaterials.Items.Add(new ListViewItem(new string[] { m.id_material.ToString(), m.name, m.count.ToString() }));
            }
        }

        private void btnLoadMaterials_Click(object sender, EventArgs e)
        {
            LoadMaterials();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            MATERIAL newMaterial = new MATERIAL();
            newMaterial.name = tbName.Text;
            newMaterial.count = Convert.ToInt32(nudCount.Value);

            productsControlS.Add(newMaterial);

            LoadMaterials();
        }

        
    }
}
