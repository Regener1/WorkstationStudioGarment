﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    public partial class FPersonalAreaAdmin : MetroFramework.Forms.MetroForm
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

        /*
         * Product special offer 
         */
        private List<PRODUCT> lProductSrecOffer = new List<PRODUCT>();

        public FPersonalAreaAdmin()
        {
            InitializeComponent();
        }
        private void UpdateListViewProducts()
        {
            lvProducts.Rows.Clear();

            foreach (PRODUCT p in lProducts)
            {
                lvProducts.Rows.Add(new string[] { p.id_product.ToString(), p.title,
                                                   p.category, p.size.ToString(),
                                                   p.color, p.price.ToString(),
                                                   p.count.ToString(), p.id_supply.ToString()});
            }
        }
        private void UpdateListViewProductStruct()
        {
            lvProductStructure.Rows.Clear();
            foreach (ProductStructureContainer ps in lProductStructure)
            {
                lvProductStructure.Rows.Add(new string[] { ps.MaterialName, ps.Count.ToString() });
            }
        }
        private void UpdateListViewSupplies()
        {
            lvSupplies.Rows.Clear();

            foreach (SUPPLY s in lSupplies)
            {
                lvSupplies.Rows.Add(new string[] { s.id_supply.ToString(), s.delivery_date });
            }
        }

        private Image CreateChart(string[] dates, decimal[] data)
        {
            int maxX = dates.Length;
            int maxY = (int)data.Max() / 1000;
            int minY = (int)data.Min() / 1000;
            int w = pbChart.Width;
            int h = pbChart.Height;

            if (maxY == 0 && minY == 0)
            {
                maxY = 1;
                minY = 1;
            }

            double cdx = Math.Round((w - 90) / (double)maxX);

            double cdy = 0;
            if (maxY == minY)
            {
                cdy = Math.Round((h - 40) / (double)Math.Abs(maxY));
            }
            else
            {
                cdy = Math.Round((h - 40) / ((double)Math.Abs(maxY) + Math.Abs(minY)));
            }

            double zeroY = 0;
            if (maxY > 0)
            {
                zeroY = (cdy * maxY);
            }
            else
            {
                zeroY = (h - cdy * Math.Abs(maxY));
            }


            Bitmap bmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmp);

            Pen p = new Pen(Brushes.Black, 2);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            //axe X
            g.DrawLine(p, 25, (int)zeroY, w - 25, (int)zeroY);
            g.DrawString("Месяц", new Font("Arial", 10), Brushes.Black, w - 50, (int)zeroY + 5);
            //axe Y
            g.DrawLine(p, 25, h - 10, 25, 20);
            g.DrawString("Прибыль т.р.", new Font("Arial", 10), Brushes.Black, 25, 5);

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
                if (maxY < 0 && minY < 0)
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
                else if (maxY > 0 && minY > 0)
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
                if (data[i] > 0)
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
            lvSupplies.Rows.Clear();
            lvProducts.Rows.Clear();
            lvProductStructure.Rows.Clear();
        }

        private void lvSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvSupplies.SelectedRows.Count == 0)
                {
                    return;
                }
                lProducts.Clear();
                lvProducts.Rows.Clear();
                lProducts = productsControlS.GetSuppliesProducts(lSupplies[lvSupplies.SelectedRows[0].Index]);

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
                if (lvProducts.SelectedRows.Count == 0)
                {
                    return;
                }
                Image photo = ImgConverter.ImageFromString(lProducts[lvProducts.SelectedRows[0].Index].photo);
                pictureBoxPhoto.Image = photo;

                PRODUCT product = lProducts[lvProducts.SelectedRows[0].Index];

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
            if (lvSupplies.SelectedRows.Count == 0)
            {
                return;
            }
            FAddProduct fAddProduct = new FAddProduct();
            fAddProduct.IdSupply = lSupplies[lvSupplies.SelectedRows[0].Index].id_supply;
            fAddProduct.ShowDialog();

            PRODUCT newProduct = fAddProduct.GetProduct();

            if (newProduct != null)
            {
                lProducts.Add(newProduct);
                lvProducts.Rows.Add(new string[] { newProduct.id_product.ToString(), newProduct.title,
                                                   newProduct.category, newProduct.size.ToString(),
                                                   newProduct.color, newProduct.price.ToString(),
                                                   newProduct.count.ToString(), newProduct.id_supply.ToString()});
            }


        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedRows.Count == 0)
            {
                return;
            }
            FEditProduct fEditProduct = new FEditProduct();
            fEditProduct.Product = lProducts[lvProducts.SelectedRows[0].Index];
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
                lvSupplies.Rows.Add(new string[] { newSupply.id_supply.ToString(),
                                                            newSupply.delivery_date });
            }
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            if (lvSupplies.SelectedRows.Count == 0)
            {
                return;
            }
            FEditSupply fEditSupply = new FEditSupply();
            fEditSupply.Supply = lSupplies[lvSupplies.SelectedRows[0].Index];
            fEditSupply.ShowDialog();

            UpdateListViewSupplies();
        }

        private void btnAddProductStructure_Click(object sender, EventArgs e)
        {
            FAddProductStructure fAddProductStructure = new FAddProductStructure();
            fAddProductStructure.IdProduct = lProducts[lvProducts.SelectedRows[0].Index].id_product;
            fAddProductStructure.ShowDialog();

            lProductStructure.Clear();
            lvProductStructure.Rows.Clear();
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
            LoadChartData();

            LoadProductsData();

            LoadClientsData();
        }

        private void LoadChartData()
        {
            cbMonthBegin.DataSource = Enum.GetValues(typeof(Months));
            cbMonthEnd.DataSource = Enum.GetValues(typeof(Months));
        }

        private void LoadProductsData()
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

        private void LoadClientsData()
        {
            try
            {
                lClients.Clear();
                lvClients.Rows.Clear();

                lClients = clientControlS.AllClients();

                foreach (CLIENT entity in lClients)
                {
                    lvClients.Rows.Add(new string[] { entity.id_client.ToString(),
                                                      entity.login,entity.access_level.ToString(),
                                                      entity.surname + " " + entity.name + " " + entity.patronymic,
                                                      entity.sex.ToString(),
                                                      entity.mail,
                                                      entity.phone_number, entity.growth.ToString(),
                                                      entity.chest.ToString(), entity.waist.ToString(),
                                                      entity.hip.ToString() });
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
                if (lvClients.SelectedRows.Count == 0)
                {
                    return;
                }

                lvClientsProducts.Rows.Clear();
                lClientsProducts.Clear();

                lClientsProducts = clientControlS.GetClientsProduct(lClients[lvClients.SelectedRows[0].Index]);

                if (lClientsProducts.Count != 0)
                {
                    foreach (var item in lClientsProducts)
                    {
                        lvClientsProducts.Rows.Add(new string[] { item.Product.id_product.ToString(),
                                                                  item.Product.title, item.Product.category,
                                                                  item.Product.size.ToString(),
                                                                  item.Product.color, item.Product.price.ToString(),
                                                                  item.Date.ToString("dd.MM.yyyy"), item.Time.ToString("H:mm:ss"),
                                                                  item.Count.ToString(), item.Price.ToString() });
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
            if (lvClientsProducts.SelectedRows.Count == 0)
            {
                return;
            }

            pbClientProductPhoto.Image = ImgConverter.ImageFromString(lClientsProducts[lvClientsProducts.SelectedRows[0].Index]
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
            if (dateRange.Count == 0 || dataRange.Count == 0)
            {
                MessageBox.Show("Нет данных");
                return;
            }


            pbChart.Image = CreateChart(dateRange.ToArray(), dataRange.ToArray());
        }

        private void btnChangeProductStructure_Click(object sender, EventArgs e)
        {
            FEditProductStructure fEditProductStructure = new FEditProductStructure();
            fEditProductStructure.PsEntities = lProductStructure;
            fEditProductStructure.ShowDialog();

            lProductStructure.Clear();
            lvProductStructure.Rows.Clear();

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

        private void lvProductSrecOffer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvProductSrecOffer.SelectedRows.Count == 0)
                {
                    return;
                }

                Image photo = ImgConverter.ImageFromString(lProductSrecOffer[lvProductSrecOffer.SelectedRows[0].Index].photo);
                pbImage.Image = photo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControlMain.SelectedIndex == 3)
                {
                    lProductSrecOffer.Clear();
                    lProductSrecOffer.AddRange(productsControlS.AllProducts());
                    lvProductSrecOffer.Rows.Clear();

                    foreach (PRODUCT p in lProductSrecOffer)
                    {
                        lvProductSrecOffer.Rows.Add(new object[] { false, p.id_product.ToString(), p.title,
                                                                       p.category, p.size.ToString(),
                                                                       p.color, p.price.ToString(),
                                                                       p.count.ToString(), p.id_supply.ToString()});
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            try
            {
                ProductSaleContainer prodSaleCont = new ProductSaleContainer();
                for (int i = 0; i < lvProductSrecOffer.Rows.Count; i++)
                {
                    if ((bool)lvProductSrecOffer.Rows[i].Cells[0].Value)
                    {
                        prodSaleCont.productsId.Add(lProductSrecOffer[i].id_product);
                    }
                }

                prodSaleCont.sale = nudSale.Value;

                if (File.Exists("ProductSale.xml"))
                {
                    File.Delete("ProductSale.xml");
                }

                Serializer.SerializeClass(typeof(ProductSaleContainer), prodSaleCont, "ProductSale.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroButtonSend_Click(object sender, EventArgs e)
        {
            try
            {

                SmtpClient client1 = new SmtpClient();
                client1.Host = "smtp.yandex.ru";
                client1.Port = 25;
                client1.EnableSsl = true;
                client1.Credentials = new NetworkCredential("BelousovaTanya1995@yandex.ru", "tANYA12345");
                client1.DeliveryMethod = SmtpDeliveryMethod.Network;


                //CredentialCache.DefaultNetworkCredentials;
                List<string> mails = clientControlS.GetMailClients();

                MailMessage message = new MailMessage();

                message.From = new MailAddress("BelousovaTanya1995@yandex.ru", "Ателье по пошиву и продаже одежды");//от кого
                message.Subject = "Новое специальное предложение для вас от ателье!";//тема
                message.Body = metroTextBox1.Text;//текст письма
                for (int i = 0; i < mails.Count; i++)
                {
                    message.To.Add(new MailAddress(mails[i].ToString()));//кому 
                }

                client1.Send(message);
                MessageBox.Show("You send messages");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
