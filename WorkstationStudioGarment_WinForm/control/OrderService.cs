using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class OrderService : IServiceDAO<ORDER>
    {
        public void Add(ORDER entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    db.ORDERs.Add(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<ORDER> All()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    return db.ORDERs.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(ORDER entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    ORDER order = db.ORDERs.
                        FirstOrDefault(c => c.id_order == entity.id_order);
                    if (order != null)
                    {
                        db.ORDERs.Remove(order);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(ORDER entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var obj = from o in db.ORDERs
                                where o.id_order == entity.id_order
                                select o;
                    obj.ToList()[0].order_date = entity.order_date;
                    obj.ToList()[0].order_time = entity.order_date;
                    obj.ToList()[0].order_status = entity.order_status;
                    obj.ToList()[0].total_sum = entity.total_sum;
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
