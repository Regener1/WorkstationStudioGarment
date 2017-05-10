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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FEditSupply : MetroFramework.Forms.MetroForm
    {
        private ProductControlModule productsControlS = new ProductControlModule();
        private SUPPLY supply;

        public FEditSupply()
        {
            InitializeComponent();
        }

        public SUPPLY Supply
        {
            get
            {
                return supply;
            }

            set
            {
                supply = value;
            }
        }

        public SUPPLY GetSupply()
        {
            return supply;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            supply.delivery_date = mtbDeliveryDate.Text;
            productsControlS.Update(supply);
            Close();
        }

        private void FEditSupply_Load(object sender, EventArgs e)
        {
            mtbDeliveryDate.Text = supply.delivery_date;
        }
    }
}
