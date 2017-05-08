using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.containers;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.modules;
using WorkstationStudioGarment_WinForm.tool;
using Excel = Microsoft.Office.Interop.Excel;

namespace WorkstationStudioGarment_WinForm.forms
{
    public enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    public partial class FPersonalAreaAdmin : Form
    {
        /*
         * Clients
         */
        private ClientControlModule clientControlS = new ClientControlModule();

        private List<CLIENT> lClients = new List<CLIENT>();
        private List<ClientProductContainer> lClientsProducts = new List<ClientProductContainer>();

        /*
         * Products 
         */
        private ProductControlModule productsControlS = new ProductControlModule();

        private List<SUPPLY> lSupplies = new List<SUPPLY>();
        private List<PRODUCT> lProducts = new List<PRODUCT>();
        private List<ProductStructureContainer> lProductStructure = new List<ProductStructureContainer>();

        /*
         * Chart
         */
        private List<string> dateRange = new List<string>();
        private List<decimal> dataRange = new List<decimal>();
        private ChartControlModule chartControlM = new ChartControlModule();

        public FPersonalAreaAdmin()
        {
            InitializeComponent();
        }
        private void UpdateListViewProducts()
        {
            lvProducts.Items.Clear();

            foreach (PRODUCT p in lProducts)
            {
                lvProducts.Items.Add(new ListViewItem(new string[] { p.id_product.ToString(), p.title,
                                                                    p.category, p.size.ToString(),
                                                                    p.color, p.price.ToString(),
                                                                    p.count.ToString(), p.id_supply.ToString()}));
            }
        }
        private void UpdateListViewProductStruct()
        {
            lvProductStructure.Items.Clear();
            foreach (ProductStructureContainer ps in lProductStructure)
            {
                lvProductStructure.Items.Add(new ListViewItem(new string[] { ps.MaterialName, ps.Count.ToString() }));
            }
        }
        private void UpdateListViewSupplies()
        {
            lvSupplies.Items.Clear();

            foreach (SUPPLY s in lSupplies)
            {
                lvSupplies.Items.Add(new ListViewItem(new string[] { s.id_supply.ToString(), s.delivery_date }));
            }
        }

        private Image CreateChart(string[] dates, decimal[] data)
        {
            int maxX = dates.Length;
            int maxY = (int)data.Max() / 1000;
            int minY = (int)data.Min() / 1000;
            int w = pbChart.Width;
            int h = pbChart.Height;

            if(maxY == 0 && minY == 0)
            {
                maxY = 1;
                minY = 1;
            }

            double cdx = Math.Round((w - 90) / (double)maxX);

            double cdy = 0;
            if (maxY == minY)
            {
                cdy = Math.Round(h / (double)Math.Abs(maxY));
            }
            else
            {
                cdy = Math.Round(h / ((double)Math.Abs(maxY) + Math.Abs(minY)));
            }

            double zeroY = 0;
            if (maxY > 0)
            {
                zeroY = (cdy * maxY) - 40;
            }
            else
            {
                zeroY = (h - cdy * Math.Abs(maxY)) + 40;
            }


            Bitmap bmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmp);

            Pen p = new Pen(Brushes.Black, 2);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            //axe X
            g.DrawLine(p, 25, (int)zeroY, w - 25,(int)zeroY);
            g.DrawString("Месяц", new Font("Arial", 10), Brushes.Black, w - 50, (int)zeroY + 5);
            //axe Y
            g.DrawLine(p, 25, h - 10, 25, 20);
            g.DrawString("Прибыль т.р.", new Font("Arial", 10), Brushes.Black, 5, 5);

            //grid X
            int sign = 1;
            if (maxY == minY)
            {
                
                if (maxY < 0)
                {
                    sign = -1;
                }

                for (int y = 1; y <= Math.Abs(maxY); y++)
                {
                    g.DrawLine(Pens.Black, 25, (int)(zeroY + sign * (cdy * y)),
                        w - 25, (int)(zeroY + sign * (cdy * y)));
                    g.DrawString((sign * y).ToString(), new Font("Arial", 10), Brushes.Black, 
                                    5, (int)(zeroY + sign * (cdy * y)));
                }
            }
            else
            {
                if(maxY < 0 && minY < 0)
                {
                    sign = -1;
                    for (int y = 1; y <= Math.Abs(maxY); y++)
                    {
                        g.DrawLine(Pens.Black, 25, (int)(zeroY + sign * (cdy * y)),
                            w - 25, (int)(zeroY + sign * (cdy * y)));
                        g.DrawString((sign * y).ToString(), new Font("Arial", 10), Brushes.Black,
                                        5, (int)(zeroY + sign * (cdy * y)));
                    }
                }
                else if(maxY > 0 && minY > 0)
                {
                    sign = 1;
                    for (int y = 1; y <= Math.Abs(maxY); y++)
                    {
                        g.DrawLine(Pens.Black, 25, (int)(zeroY + sign * (cdy * y)),
                            w - 25, (int)(zeroY + sign * (cdy * y)));
                        g.DrawString((sign * y).ToString(), new Font("Arial", 10), Brushes.Black,
                                        5, (int)(zeroY + sign * (cdy * y)));
                    }
                }
                else
                {
                    for (int y = 1; y <= Math.Abs(maxY); y++)
                    {
                        g.DrawLine(Pens.Black, 25, (int)(zeroY - (cdy * y)),
                            w - 25, (int)(zeroY - (cdy * y)));
                        g.DrawString(y.ToString(), new Font("Arial", 10), Brushes.Black,
                                    5, (int)(zeroY - (cdy * y)));
                    }

                    for (int y = 1; y <= Math.Abs(minY); y++)
                    {
                        g.DrawLine(Pens.Black, 25, (int)(zeroY + (cdy * y)),
                            w - 25, (int)(zeroY + (cdy * y)));
                        g.DrawString((-1 * y).ToString(), new Font("Arial", 10), Brushes.Black,
                                    5, (int)(zeroY + (cdy * y)));
                    }
                    
                }

                
            }
            //grid Y
            for (int x = 0; x < maxX; x++)
            {
                g.DrawLine(Pens.Black, 25 + (int)(cdx * x), h - 10, 25 + (int)(cdx * x), 10);
                g.DrawString(dates[x], new Font("Arial", 10), 
                                Brushes.Black, (int)(cdx * x) + 35, (int)zeroY + 4);
            }

            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] > 0)
                {
                    g.FillRectangle(Brushes.Red, (int)(i * cdx) + 25, (int)(zeroY - ((int)(data[i] / 1000) * cdy)),
                            10, (int)((int)(data[i] / 1000) * cdy));
                }
                else
                {
                    g.FillRectangle(Brushes.Red, 
                            (int)(i * cdx) + 25, 
                            (int)(zeroY),
                            10, 
                            (int)((int)(Math.Abs(data[i]) / 1000) * cdy));
                }
                
            }

            return bmp;
        }

        private void ClearAllProductLists()
        {
            lSupplies.Clear();
            lProducts.Clear();
            lProductStructure.Clear();
            lvSupplies.Items.Clear();
            lvProducts.Items.Clear();
            lvProductStructure.Items.Clear();
        }

        private void btnLoadSupplies_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAllProductLists();

                lSupplies = productsControlS.AllSupplies();

                UpdateListViewSupplies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvSupplies.SelectedIndices.Count == 0)
                {
                    return;
                }
                lProducts.Clear();
                lvProducts.Items.Clear();
                lProducts = productsControlS.GetSuppliesProducts(lSupplies[lvSupplies.SelectedIndices[0]]);

                UpdateListViewProducts();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvProducts.SelectedIndices.Count == 0)
                {
                    return;
                }
                Image photo = ImgConverter.ImageFromString(lProducts[lvProducts.SelectedIndices[0]].photo);
                pictureBoxPhoto.Image = photo;

                PRODUCT product = lProducts[lvProducts.SelectedIndices[0]];

                lProductStructure.Clear();
                
                lProductStructure = productsControlS.GetProductStructure(product);

                UpdateListViewProductStruct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (lvSupplies.SelectedIndices.Count == 0)
            {
                return;
            }
            FAddProduct fAddProduct = new FAddProduct();
            fAddProduct.IdSupply = lSupplies[lvSupplies.SelectedIndices[0]].id_supply;
            fAddProduct.ShowDialog();

            PRODUCT newProduct = fAddProduct.GetProduct();

            if (newProduct != null)
            {
                lProducts.Add(newProduct);
                lvProducts.Items.Add(new ListViewItem(new string[] { newProduct.id_product.ToString(), newProduct.title,
                                                                    newProduct.category, newProduct.size.ToString(),
                                                                    newProduct.color, newProduct.price.ToString(),
                                                                    newProduct.count.ToString(), newProduct.id_supply.ToString()}));
            }


        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedIndices.Count == 0)
            {
                return;
            }
            FEditProduct fEditProduct = new FEditProduct();
            fEditProduct.Product = lProducts[lvProducts.SelectedIndices[0]];
            fEditProduct.ShowDialog();

            UpdateListViewProducts();
        }

        

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            FAddSupply fAddSupply = new FAddSupply();
            fAddSupply.ShowDialog();
            SUPPLY newSupply = fAddSupply.GetSupply();

            if (newSupply != null)
            {
                lSupplies.Add(newSupply);
                lvSupplies.Items.Add(new ListViewItem(new string[] { newSupply.id_supply.ToString(),
                                                            newSupply.delivery_date }));
            }
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            if (lvSupplies.SelectedIndices.Count == 0)
            {
                return;
            }
            FEditSupply fEditSupply = new FEditSupply();
            fEditSupply.Supply = lSupplies[lvSupplies.SelectedIndices[0]];
            fEditSupply.ShowDialog();

            UpdateListViewSupplies();
        }

        private void btnAddProductStructure_Click(object sender, EventArgs e)
        {
            FAddProductStructure fAddProductStructure = new FAddProductStructure();
            fAddProductStructure.IdProduct = lProducts[lvProducts.SelectedIndices[0]].id_product;
            fAddProductStructure.ShowDialog();

            lProductStructure.Clear();
            lvProductStructure.Items.Clear();
            lProductStructure = fAddProductStructure.GetProductStructure();

            if (lProductStructure != null)
            {

                UpdateListViewProductStruct();

            }
        }

        private void btnMaterialEditor_Click(object sender, EventArgs e)
        {
            FMaterialEditor fMaterialEditor = new FMaterialEditor();
            fMaterialEditor.ShowDialog();
        }


        private void FPersonalAreaAdmin_Load(object sender, EventArgs e)
        {
            cbMonthBegin.DataSource = Enum.GetValues(typeof(Months));
            cbMonthEnd.DataSource = Enum.GetValues(typeof(Months));

            try
            {
                lClients.Clear();
                lvClients.Items.Clear();

                lClients = clientControlS.AllClients();

                foreach (CLIENT entity in lClients)
                {
                    lvClients.Items.Add(new ListViewItem(new string[] { entity.id_client.ToString(),
                                                                        entity.surname + " " + entity.name + " " + entity.patronymic,
                                                                        entity.sex.ToString(), entity.login,
                                                                        entity.access_level.ToString(), entity.mail,
                                                                        entity.phone_number, entity.growth.ToString(),
                                                                        entity.chest.ToString(), entity.waist.ToString(),
                                                                        entity.hip.ToString() }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvClients.SelectedIndices.Count == 0)
                {
                    return;
                }

                lvClientsProducts.Items.Clear();
                lClientsProducts.Clear();

                lClientsProducts = clientControlS.GetClientsProduct(lClients[lvClients.SelectedIndices[0]]);

                if (lClientsProducts.Count != 0)
                {
                    foreach (var item in lClientsProducts)
                    {
                        lvClientsProducts.Items.Add(new ListViewItem(new string[] { item.Product.id_product.ToString(),
                                                                                    item.Product.title, item.Product.category,
                                                                                    item.Product.size.ToString(),
                                                                                    item.Product.color, item.Product.price.ToString(),
                                                                                    item.Date.ToString("dd.MM.yyyy"), item.Time.ToString("H:M:s"),
                                                                                    item.Count.ToString(), item.Price.ToString() }));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvClientsProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvClientsProducts.SelectedIndices.Count == 0)
            {
                return;
            }

            pbClientProductPhoto.Image = ImgConverter.ImageFromString(lClientsProducts[lvClientsProducts.SelectedIndices[0]]
                                                                                                        .Product.photo);

        }

        private void rbRangeDateReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRangeDateReport.Checked)
            {
                cbMonthBegin.Enabled = true;
                cbMonthEnd.Enabled = true;
                nudYearBegin.Enabled = true;
                nudYearEnd.Enabled = true;
            }
            else
            {
                cbMonthBegin.Enabled = false;
                cbMonthEnd.Enabled = false;
                nudYearBegin.Enabled = false;
                nudYearEnd.Enabled = false;
            }
        }

        private void btnCreateChart_Click(object sender, EventArgs e)
        {
            ReportInfo();
            if(dateRange.Count == 0 || dataRange.Count == 0)
            {
                MessageBox.Show("Нет данных");
                return;
            }


            pbChart.Image = CreateChart(dateRange.ToArray(), dataRange.ToArray());
        }

        private void btnChangeProductStructure_Click(object sender, EventArgs e)
        {
            FAddProductStructure fAddProductStructure = new FAddProductStructure();
            fAddProductStructure.IdProduct = lProducts[lvProducts.SelectedIndices[0]].id_product;
            fAddProductStructure.ShowDialog();

            FEditProductStructure fEditProductStructure = new FEditProductStructure();
            fEditProductStructure.PsEntities = lProductStructure;
            fEditProductStructure.ShowDialog();


            lProductStructure.Clear();
            lvProductStructure.Items.Clear();
            lProductStructure = fAddProductStructure.GetProductStructure();

            if (lProductStructure != null)
            {
                UpdateListViewProductStruct();
            }
        }

        private void ReportInfo()
        {
            DateTime monthBegin;
            DateTime monthEnd;

            if (rbRangeDateReport.Checked)
            {
                monthBegin = new DateTime((int)nudYearBegin.Value, cbMonthBegin.SelectedIndex + 1, 1);
                monthEnd = new DateTime((int)nudYearEnd.Value, cbMonthEnd.SelectedIndex + 1, 1);
            }
            else
            {
                monthBegin = new DateTime(DateTime.Now.Year, 1, 1);
                monthEnd = new DateTime(DateTime.Now.Year, 12, 1);
            }

            if (monthBegin > monthEnd)
            {
                MessageBox.Show("Неверный диапазон дат");
                return;
            }

            dataRange.Clear();
            dateRange.Clear();

            //dataRange.Add(2500);
            //dataRange.Add(-5000);
            //dataRange.Add(13000);
            //dataRange.Add(7000);
            //dataRange.Add(-3000);

            for (var date = monthBegin.Date; date <= monthEnd.Date; date = date.AddMonths(1))
            {
                dateRange.Add(date.Month + "/" + date.Year);

                dataRange.Add(chartControlM.GetTotalSumMonth(date.Month, date.Year) -
                            chartControlM.GetTotalSumMonthSupply(date.Month, date.Year));
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportInfo();
            if (dateRange.Count == 0 || dataRange.Count == 0)
            {
                MessageBox.Show("Нет данных");
                return;
            }
            Excel.Application excelapp = new Excel.Application();
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);
            Excel.Sheets excelsheets = excelapp.Worksheets;
            Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            Excel.Range excelcells = null;
            int rows = dataRange.Count;

            //head
            excelcells = excelworksheet.Cells[1, 2];
            excelcells.Clear();
            excelcells.Value2 = "Прибыль";

            for (int i = 1; i <= rows; i++)
            {
                excelcells = excelworksheet.Cells[i + 1, 1];
                excelcells.Clear();
                excelcells.Value2 = dateRange[i - 1];
            }

            for (int i = 1; i <= rows; i++)
            {
                excelcells = excelworksheet.Cells[i + 1, 2];
                excelcells.Clear();
                excelcells.Value2 = dataRange[i - 1];
            }

            Excel.Range c1 = excelworksheet.Cells[1, 1];
            Excel.Range c2 = excelworksheet.Cells[dataRange.Count + 1, 2];
            excelcells = excelworksheet.get_Range(c1, c2);
            excelcells.Select();

            Excel.Chart excelchart = (Excel.Chart)excelapp.Charts.Add(Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);
            excelchart.Activate();
            excelchart.Select(Type.Missing);

            excelchart.ChartTitle.Text = "Прибыль по месяцам";

            excelapp.Visible = true;
        }
    }
}
