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
        FTanya f = new FTanya();
        public Form1()
        {
            InitializeComponent();

            f.ShowDialog();

        }
    }
}
