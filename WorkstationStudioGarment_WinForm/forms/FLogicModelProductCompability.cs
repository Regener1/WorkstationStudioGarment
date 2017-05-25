using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.modules;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FLogicModelProductCompability : Form
    {
        private LogicModelModule control = new LogicModelModule();

        private List<string> clothes = new List<string>();

        private List<string> topBody = new List<string>();
        private List<string> botBody = new List<string>();

        private List<string> botDown = new List<string>();
        private List<string> topUp = new List<string>();

        public FLogicModelProductCompability()
        {
            InitializeComponent();
        }

        private void FLogicModelProductCompability_Load(object sender, EventArgs e)
        {
            clothes.AddRange(control.AllProductNames());

            topBody.Add("Блузка");
            topBody.Add("Футболка");
            topBody.Add("Рубашка");

            botBody.Add("Юбка");
            botBody.Add("Платье");
            botBody.Add("Джинсы");



            botDown.Add("Футболка");
            botDown.Add("Юбка");


        }
    }
}
