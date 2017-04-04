using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class ProductService : IServiceDAO<PRODUCT>
    {
        public void Add(PRODUCT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {

                    db.PRODUCTs.Add(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<PRODUCT> All()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    return db.PRODUCTs.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(PRODUCT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    PRODUCT product = db.PRODUCTs.
                        FirstOrDefault(c => c.id_product == entity.id_product);
                    if (product != null)
                    {
                        db.PRODUCTs.Remove(product);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(PRODUCT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var obj = from o in db.PRODUCTs
                              where o.id_product == entity.id_product
                              select o;
                    obj.ToList()[0].title = entity.title;
                    obj.ToList()[0].category = entity.category;
                    obj.ToList()[0].size = entity.size;
                    obj.ToList()[0].color = entity.color;
                    obj.ToList()[0].photo = entity.photo;
                    obj.ToList()[0].price = entity.price;
                    obj.ToList()[0].count = entity.count;
                    obj.ToList()[0].id_supply = entity.id_supply;
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
