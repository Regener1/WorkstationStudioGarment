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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FMain : Form
    {
        CLIENT client;
        public FMain()
        {
            InitializeComponent();
        }

        public void SetClient(CLIENT client) { 
            this.client = client;
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            lblClientLogin.Text = client.login;
        }
    }
}
