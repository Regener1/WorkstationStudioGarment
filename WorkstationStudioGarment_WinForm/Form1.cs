using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.forms;

namespace WorkstationStudioGarment_WinForm
{
    public partial class Form1 : Form
    {
        FAuthorization f = new FAuthorization();
        //FRegistration f = new FRegistration();
        public Form1()
        {
            InitializeComponent();
            f.ShowDialog();
           // f.ShowDialog();

        }

        private void btnTestForm_Click(object sender, EventArgs e)
        {
           // FTest fTest = new FTest();
           // fTest.ShowDialog();
        }
    }
}
