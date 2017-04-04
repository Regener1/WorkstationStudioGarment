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
using WorkstationStudioGarment_WinForm.containers;


namespace WorkstationStudioGarment_WinForm.control
{
    class DbManager
    {

        /// <summary>
        /// Add product into table "Product"
        /// </summary>
        public int AddProduct(PRODUCT product)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    
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
        /// Add material into table "Material"
        /// </summary>
        public int AddMaterial(MATERIAL material)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
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
        /// Add supply into table "Supply"
        /// </summary>
        public int AddSupply(SUPPLY supply)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
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
        /// Add product structure into table "Product structure"
        /// </summary>
        public int AddProductStructure(PRODUCT_STRUCTURE productStruct)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    db.PRODUCT_STRUCTURE.Add(productStruct);
                    db.SaveChanges();
                    return productStruct.id_product_structure;
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

        public List<PRODUCT> GetProducts(int size)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var product = from p in db.PRODUCTs
                                  where p.size == size
                                  select p;
                    return product.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public List<PRODUCT_STRUCTURE> GetProductStructures()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var productStruct = db.PRODUCT_STRUCTURE.ToList();
                    return productStruct;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Получить количество и имя материалов из которых состоит товар
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public List<ProductStructureEntity> GetProductStructure(int idProduct)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var structure = from ps in db.PRODUCT_STRUCTURE
                                    join m in db.MATERIALs on ps.id_material equals m.id_material
                                    where ps.id_product == idProduct
                                    select new { ps.id_product_structure, ps.count, m.name };
                    return structure
                        .ToList()
                        .Select(x => new ProductStructureEntity(x.id_product_structure, x.count, x.name))
                        .ToList();
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

        /// <summary>
        /// Получить все продукты относящиеся к поставке
        /// </summary>
        /// <param name="supply"></param>
        /// <returns></returns>
        public List<PRODUCT> GetSuppliesProducts(int idSupply)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var products = from p in db.PRODUCTs
                                   where p.id_supply == idSupply
                                   select p;
                    return products.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Получить все поставки к которым относится товар
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public List<SUPPLY> GetProductsSupplies(int idSupply)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var products = from s in db.SUPPLies
                                   where s.id_supply == idSupply
                                   select s;
                    return products.ToList();
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

    }
}

