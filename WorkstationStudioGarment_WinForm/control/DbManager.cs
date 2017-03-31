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
    class DbManager
    {

        /// <summary>
        /// Add product into table "Product"
        /// </summary>
        /// <param name="title"></param>
        /// <param name="category"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="photo"></param>
        /// <param name="price"></param>
        /// <param name="id_supply"></param>
        /// <returns>id_product</returns>
        public int AddProduct(string title, string category, int size,
                                string color, Image photo, decimal price,
                                int id_supply)
        {
            string image = ImageToString(photo);
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
                    return product.id_product;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Convert image to string
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public string ImageToString(Image image)
        {
            string strData = "";
            try
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);
                byte[] data = ms.ToArray();
                strData = Convert.ToBase64String(data);
                return strData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Convert image from string
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Image ImageFromString(string data)
        {
            try
            {
                byte[] img = Convert.FromBase64String(data);
                MemoryStream ms = new MemoryStream(img);
                return Image.FromStream(ms);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Add supply into table "Supply"
        /// </summary>
        /// <param name="date">delivery_date</param>
        /// <param name="count">count</param>
        /// <returns>Id supply</returns>
        public int AddSupply(string date, int count)
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

        /// <summary>
        /// Returns list of supplies
        /// </summary>
        /// <returns></returns>
        public List<SUPPLY> GetSupplies()
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

        /// <summary>
        /// Returns list of products
        /// </summary>
        /// <returns></returns>
        public List<PRODUCT> GetProducts()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var product = db.PRODUCTs.ToList();
                    return product;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Return product count
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetProductCount(int id_supply)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var supply = from s in db.SUPPLies
                                 where s.id_supply == id_supply
                                 select s.count;
                    return supply.ToList()[0];
                }
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Add material into table "Material"
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        /// <returns>id_material</returns>
        public int AddMaterial(string name, int count)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    MATERIAL material = new MATERIAL();
                    material.name = name;
                    material.count = count;
                    db.MATERIALs.Add(material);
                    db.SaveChanges();
                    return material.id_material;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Add product structure into table "Product structure"
        /// </summary>
        /// <param name="count"></param>
        /// <param name="id_product"></param>
        /// <param name="id_material"></param>
        /// <returns>id_product_structure</returns>
        public int AddProductStructure(int count, int id_product, int id_material)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    PRODUCT_STRUCTURE product_structure = new PRODUCT_STRUCTURE();
                    product_structure.count = count;
                    product_structure.id_product = id_product;
                    product_structure.id_material = id_material;
                    db.PRODUCT_STRUCTURE.Add(product_structure);
                    db.SaveChanges();
                    return product_structure.id_product_structure;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Change count product structure
        /// </summary>
        /// <param name="id_product">current id_product</param>
        /// <param name="id_material">current id_material</param>
        /// <param name="count">new count</param>
        public void ChangeProductStructure(int id_product, int id_material, int count)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    //проверить!!!!!
                    var product_structure =  (from ps in db.PRODUCT_STRUCTURE
                                             where ps.id_product == id_product && ps.id_material == id_material
                                             select ps.count).ToList();

                    product_structure[0] = count;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// returns available material
        /// </summary>
        /// <param name="id_product"></param>
        /// <param name="id_material"></param>
        /// <returns>count</returns>
        public int CountNesessaryMaterial(int id_product, int id_material)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var product_structure = (from ps in db.PRODUCT_STRUCTURE
                                             where ps.id_product == id_product && ps.id_material == id_material
                                             select ps.count).ToList();

                    return product_structure[0];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Return count available material
        /// </summary>
        /// <param name="id_material"></param>
        /// <returns>count</returns>
        public int CountAvailableMaterial(int id_material)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var material = (from m in db.MATERIALs
                                   where m.id_material == id_material
                                   select m.count).ToList();
                    return material[0];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Return list of materials
        /// </summary>
        /// <returns></returns>
        public List<MATERIAL> GetMaterials()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var materials = db.MATERIALs.ToList();
                    return materials;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}

