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
    class ProductControlModule
    {
        private SupplyService supplyS = new SupplyService();
        private ProductService productS = new ProductService();
        private ProductStructureService productStructureS = new ProductStructureService();
        private MaterialService materialS = new MaterialService();

        /*
         * НУЖНЫ TRY CATCH
         */
        public void Add(SUPPLY entity)
        {
            supplyS.Add(entity);
        }

        public void Add(PRODUCT entity)
        {
            productS.Add(entity);
        }

        public void Add(PRODUCT_STRUCTURE entity)
        {
            productStructureS.Add(entity);
        }

        public void Add(MATERIAL entity)
        {
            materialS.Add(entity);
        }

        public List<SUPPLY> AllSupplies()
        {
            return supplyS.All();        
        }

        public List<MATERIAL> AllMaterials()
        {
            return materialS.All();
        }

       
        /// <summary>
        /// Получить все продукты относящиеся к данной поставке
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public List<PRODUCT> GetSuppliesProducts(SUPPLY entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var products = from p in db.PRODUCTs
                                   where p.id_supply == entity.id_supply
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
        /// Получить весь состав выбранного товара
        /// </summary>
        /// <param name="productStruct"></param>
        /// <returns></returns>
        public List<ProductStructureContainer> GetProductStructure(PRODUCT product)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var structure = from ps in db.PRODUCT_STRUCTURE
                                    join m in db.MATERIALs on ps.id_material equals m.id_material
                                    where ps.id_product == product.id_product
                                    select new { ps.id_product_structure, ps.count, m.name };
                    return structure
                        .ToList()
                        .Select(x => new ProductStructureContainer(x.id_product_structure, x.count, x.name))
                        .ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
