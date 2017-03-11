using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using WorkstationStudioGarment_WinForm.manager;

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
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    PRODUCT product = new PRODUCT();
                    product.title = title;
                    product.category = category;
                    product.size = size;
                    product.color = color;

                    string image = ConvertImageToByte(photo);
                    if (image.Equals(""))
                    {
                        throw new Exception("Cannot convert image to string.");
                    }

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

        public void AddProductIntoSupply (string date, int count)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    SUPPLY supply = new SUPPLY();
                    supply.delivery_date = date;
                    supply.count = count;
                    db.SUPPLYs.Add(supply);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
