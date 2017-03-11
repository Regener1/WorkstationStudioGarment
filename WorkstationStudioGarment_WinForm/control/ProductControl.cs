using System;
using System.Collections.Generic;
using System.Drawing;
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
                                int id_storage)
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
                    //product.photo = 
                    product.price = price;
                    product.id_storage = id_storage;
                    db.PRODUCTs.Add(product);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private byte[] ConvertImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();

            return null;
        }

        public void AddProductIntoStorage (string date, int count)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    STORAGE storage = new STORAGE();
                    storage.delivery_date = date;
                    storage.count = count;
                    db.STORAGEs.Add(storage);
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
