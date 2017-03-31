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
    public partial class FAuthorization : Form
    {
       // FMain fmain = new FMain();
        FRegistration freg = new FRegistration();
        ClientControl cl = new ClientControl();
        List<CLIENT> client;
        public CLIENT ourClient;
        public FAuthorization()
        {
            InitializeComponent();
        }

        private void bAuthorization_Click(object sender, EventArgs e)
        {
            try
            {
                client = cl.SearchClient(tbLogin.Text, tbPassword.Text);
                if (client.Count == 0)
                {
                    lblError.Visible = true;
                    tbLogin.BackColor = Color.Red;
                    tbPassword.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Вы успешно вошли в систему.");
                    ourClient = client[0];
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            freg.ShowDialog();
        }

        private void tbLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lblError.Visible = false;
            tbLogin.BackColor = Color.White;
            tbPassword.BackColor = Color.White;
        }

        private void tbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lblError.Visible = false;
            tbLogin.BackColor = Color.White;
            tbPassword.BackColor = Color.White;
        }
    }
}
