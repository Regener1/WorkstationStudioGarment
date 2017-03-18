using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Linq;
using WorkstationStudioGarment_WinForm.manager;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace WorkstationStudioGarment_WinForm.control
{
    class ProductControl
    {
        /// <summary>
        /// Add product into table "Product" and "Storage"
        /// </summary>
        public void AddProduct (string title, string category, int size,
                                string color, Image photo, decimal price,
                                int id_supply)
        {
            string image = ConvertImageToByte(photo);
            if (image.Equals(""))
            {
                throw new Exception("Cannot convert image to string.");
            }

            try
            {
                using (StudioDB db = new StudioDB())
                {
                    PRODUCT product = new PRODUCT();
                    product.title = title;
                    product.category = category;
                    product.size = size;
                    product.color = color;
                    product.photo = image;
                    product.price = price;
                    product.id_supply = id_supply;
                    db.PRODUCTs.Add(product);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private string ConvertImageToByte(Image image)
        {
            string strData = "";
            try
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);
                byte[] data = ms.ToArray();
                strData = Convert.ToBase64String(data);
            }
            catch (Exception e)
            {
                throw e;
            }
            return strData;
        }

        public int AddSupply (string date, int count)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    SUPPLY supply = new SUPPLY();
                    supply.delivery_date = date;
                    supply.count = count;
                    db.SUPPLies.Add(supply);
                    db.SaveChanges();
                    return supply.id_supply;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SUPPLY> GetSupply()
        {
            
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var supply = db.SUPPLies.ToList();

                    return supply;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
