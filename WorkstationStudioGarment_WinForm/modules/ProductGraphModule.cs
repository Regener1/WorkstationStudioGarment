using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.containers;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.modules
{
    class ProductGraphModule
    {
        private ProductService productS = new ProductService();
        private ProductStructureService productStructureS = new ProductStructureService();
        private MaterialService materialS = new MaterialService();

        public List<PRODUCT> AllProducts()
        {
            return productS.All();
        }

        public List<MATERIAL> AllMaterials()
        {
            return materialS.All();
        }

        public List<ProductInfoContainer> GetProductsInfo()
        {
            try
            {
                using(StudioDB db = new StudioDB())
                {
                    List<ProductInfoContainer> productsInfo = new List<ProductInfoContainer>();
                    List<PRODUCT> products = AllProducts();
                    foreach(PRODUCT item in products)
                    {
                        var productMaterials = from ps in db.PRODUCT_STRUCTURE
                                               join m in db.MATERIALs
                                               on ps.id_material equals m.id_material
                                               where ps.id_product == item.id_product
                                               select new { m.id_material, m.name, ps.count };
                        List<ProductMaterial> materialsInfo = productMaterials.ToList()
                            .Select(x => new ProductMaterial(x.id_material, x.name, x.count))
                            .ToList();
                        productsInfo.Add(new ProductInfoContainer(item, materialsInfo));
                    }

                    return productsInfo;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<MaterialInfoContainer> GetMaterialsInfo()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    List<MaterialInfoContainer> materialsInfo = new List<MaterialInfoContainer>();
                    List<MATERIAL> materials = AllMaterials();
                    foreach (MATERIAL item in materials)
                    {
                        var products = from ps in db.PRODUCT_STRUCTURE
                                               join m in db.MATERIALs
                                               on ps.id_material equals m.id_material
                                               join p in db.PRODUCTs
                                               on ps.id_product equals p.id_product
                                               where ps.id_material == item.id_material
                                               select p;
                        materialsInfo.Add(new MaterialInfoContainer(item, products.ToList()));
                    }

                    return materialsInfo;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
