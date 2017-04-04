using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class ProductStructureService : IServiceDAO<PRODUCT_STRUCTURE>
    {
        public void Add(PRODUCT_STRUCTURE entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {

                    db.PRODUCT_STRUCTURE.Add(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<PRODUCT_STRUCTURE> All()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    return db.PRODUCT_STRUCTURE.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(PRODUCT_STRUCTURE entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    PRODUCT_STRUCTURE productStruct = db.PRODUCT_STRUCTURE.
                        FirstOrDefault(c => c.id_product_structure == entity.id_product_structure);
                    if (productStruct != null)
                    {
                        db.PRODUCT_STRUCTURE.Remove(productStruct);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(PRODUCT_STRUCTURE entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var obj = from o in db.PRODUCT_STRUCTURE
                              where o.id_product_structure == entity.id_product_structure
                              select o;
                    obj.ToList()[0].count = entity.count;
                    obj.ToList()[0].id_material = entity.id_material;
                    obj.ToList()[0].id_product = entity.id_product;
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
