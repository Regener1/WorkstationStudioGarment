using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class SupplyService : IServiceDAO<SUPPLY>
    {
        public void Add(SUPPLY entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {

                    db.SUPPLies.Add(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SUPPLY> All()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    return db.SUPPLies.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(SUPPLY entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    SUPPLY supply = db.SUPPLies.
                        FirstOrDefault(c => c.id_supply == entity.id_supply);
                    if (supply != null)
                    {
                        db.SUPPLies.Remove(supply);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(SUPPLY entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var obj = from o in db.SUPPLies
                              where o.id_supply == entity.id_supply
                              select o;
                    obj.ToList()[0].delivery_date = entity.delivery_date;
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
