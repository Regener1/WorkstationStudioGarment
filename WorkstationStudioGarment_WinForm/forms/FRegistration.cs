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

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FRegistration : MetroFramework.Forms.MetroForm
    {

        ClientControl cl = new ClientControl();

        public FRegistration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Registration in the system
        /// </summary>
        private void bRegistration_Click(object sender, EventArgs e)
        {
            int sex = 0;
            if (cbMan.Checked)
            {
                sex = 1;
            }
            try
            {
                cl.AddClients(tbLogin.Text, tbPassword.Text, tbSurname.Text, tbName.Text,
                    tbPatronymic.Text, tbMail.Text, tbPhone.Text, sex,
                    Int32.Parse(tbGrowth.Text), Int32.Parse(tbChest.Text),
                    Int32.Parse(tbWaist.Text), Int32.Parse(tbHip.Text));
                MetroFramework.MetroMessageBox.Show(this,"Регистрация прошла успешно.");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ошибка при регистрации в системе.\n" + ex.Message);
            }

            Close();
        }

        private void cbMan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMan.Checked)
            {
                chWoman.Checked = false;
            }
        }

        private void chWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (chWoman.Checked)
            {
                cbMan.Checked = false;
            }
        }
    }
}
