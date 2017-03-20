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
    public partial class FTanya : Form
    {
        public ClientControl clC = new ClientControl();
        CLIENT cl = new CLIENT();
        public FTanya()
        {
            InitializeComponent();
        }

        private void bAddClient_Click(object sender, EventArgs e)
        {
            ClientControl clC = new ClientControl();
            clC.AddClients("ghj", "jhgh", "8gj", "ghjghj", "hjjh", "bvghj", "fgfgh", 5, 7, 78, 657, 90);
           
            IEnumerable<CLIENT> clll = clC.SelectAll().ToList();
            
            //foreach (var array in clll)
            //{
            //    this.dGClient.Rows.Add(array);
            //}
        }

    }
}
