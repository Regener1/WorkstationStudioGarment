using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.containers;
using WorkstationStudioGarment_WinForm.control;

namespace WorkstationStudioGarment_WinForm.modules
{
    class OrderControlModule
    {
        private ClientService clientS = new ClientService();
        private BasketService basketS = new BasketService();
        private OrderService orderS = new OrderService();
        private ProductService productS = new ProductService();
        private SupplyService supplyS = new SupplyService();
        private ProductStructureService productStructureS = new ProductStructureService();
        private MaterialService materialS = new MaterialService();


        public void Add(BASKET entity)
        {
            basketS.Add(entity);
        }

        public List<PRODUCT> AllProducts()
        {
            return productS.All();
        }

        /// <summary>
        /// Уменьшить количество имеющегося материала
        /// </summary>
        /// <param name="entity"></param>
        public void DecreaseMaterialCount(PRODUCT entity)
        {
            try
            {
                List<MATERIAL> lMaterials;
                List<PRODUCT_STRUCTURE> lProductStructures;
                using (StudioDB db = new StudioDB())
                {
                    var productStructures = from ps in db.PRODUCT_STRUCTURE
                                            where ps.id_product == entity.id_product
                                            select ps;
                    lProductStructures = productStructures.ToList();
                    var materials = from m in db.MATERIALs
                                    join ps in db.PRODUCT_STRUCTURE
                                    on m.id_material equals ps.id_material
                                    where ps.id_product == entity.id_product
                                    select m;
                    lMaterials = materials.ToList();
                }

                for(int i = 0; i < lMaterials.Count; i++)
                {
                    lMaterials[i].count -= lProductStructures[i].count;
                    materialS.Update(lMaterials[i]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Получение количества доступного товара. Возврат -1 ели товар не найден. 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int GetProductLimit(PRODUCT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    PRODUCT product = db.PRODUCTs
                        .FirstOrDefault(c => c.id_product == entity.id_product);
                    if(product != null)
                    {
                        return product.count;
                    }
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Проверка на наличие товара на складе
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool CheckForAvailability(PRODUCT entity)
        {
            return entity.count == 0 ? false : true;
        }

        /// <summary>
        /// Получение количества товара который можно пошить.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Если 0 то не можем пошить товар</returns>
        public int GetSewingLimit(PRODUCT entity)
        {
            int count = 0;
            int availableCount = 0;
            List<ProductStructureAvailableContainer> lProductStruct = GetProductStructureAndMaterialCount(entity);
            if (lProductStruct.Count == 0)
                return count;

            //ищем минимальное 
            if (lProductStruct[0].NecessaryCount <= lProductStruct[0].AvailableCount)
            {
                count = lProductStruct[0].AvailableCount / lProductStruct[0].NecessaryCount;
            }
            else
            {
                return 0;
            }

            for (int i = 1; i < lProductStruct.Count; i++)
            {
                if(lProductStruct[i].NecessaryCount <= lProductStruct[i].AvailableCount)
                {
                    availableCount = lProductStruct[i].AvailableCount / lProductStruct[i].NecessaryCount;
                    if (availableCount < count)
                    {
                        count = availableCount;
                    }
                }
                else
                {
                    return 0;
                }
            }
            return count;
        }
        
        /// <summary>
        /// Получить количество необходимого и доступного материала
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private List<ProductStructureAvailableContainer> GetProductStructureAndMaterialCount(PRODUCT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var structure = from ps in db.PRODUCT_STRUCTURE
                                    join m in db.MATERIALs on ps.id_material equals m.id_material
                                    where ps.id_product == entity.id_product
                                    select new { m.name, necessaryCount = ps.count, availableCount = m.count };
                    return structure
                        .ToList()
                        .Select(x => new ProductStructureAvailableContainer(x.name, x.necessaryCount, x.availableCount))
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
