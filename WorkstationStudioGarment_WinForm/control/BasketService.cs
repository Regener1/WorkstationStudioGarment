using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class BasketService : IServiceDAO<BASKET>
    {
        public void Add(BASKET entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    db.BASKETs.Add(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<BASKET> All()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    return db.BASKETs.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(BASKET entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    BASKET basket = db.BASKETs.
                        FirstOrDefault(c => c.id_basket == entity.id_basket);
                    if (basket != null)
                    {
                        db.BASKETs.Remove(basket);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(BASKET entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var obj = from o in db.BASKETs
                              where o.id_basket == entity.id_basket
                              select o;
                    obj.ToList()[0].count = entity.count;
                    obj.ToList()[0].id_client = entity.id_client;
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
