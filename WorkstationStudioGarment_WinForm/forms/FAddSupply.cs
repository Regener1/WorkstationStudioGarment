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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FAddSupply : Form
    {
        private ProductsManager pManager = new ProductsManager();
        private SUPPLY supply;

        public FAddSupply()
        {
            InitializeComponent();
        }

        public SUPPLY GetSupply()
        {
            return supply;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            supply = new SUPPLY();
            supply.delivery_date = mtbDeliveryDate.Text;
            pManager.Add(supply);
        }
    }
}
