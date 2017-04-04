using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class MaterialService : IServiceDAO<MATERIAL>
    {
        public void Add(MATERIAL entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    db.MATERIALs.Add(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<MATERIAL> All()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    return db.MATERIALs.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(MATERIAL entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    MATERIAL material = db.MATERIALs.
                        FirstOrDefault(c => c.id_material == entity.id_material);
                    if (material != null)
                    {
                        db.MATERIALs.Remove(material);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(MATERIAL entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var obj = from o in db.MATERIALs
                              where o.id_material == entity.id_material
                              select o;
                    obj.ToList()[0].name = entity.name;
                    obj.ToList()[0].count = entity.count;
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
