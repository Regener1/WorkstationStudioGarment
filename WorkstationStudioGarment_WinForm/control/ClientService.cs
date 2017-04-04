using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class ClientService : IServiceDAO<CLIENT>
    {
        public void Add(CLIENT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {

                    db.CLIENTs.Add(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CLIENT> All()
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    return db.CLIENTs.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(CLIENT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    CLIENT client = db.CLIENTs.
                        FirstOrDefault(c => c.id_client == entity.id_client);
                    if(client != null)
                    {
                        db.CLIENTs.Remove(client);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(CLIENT entity)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var obj = from o in db.CLIENTs
                                where o.id_client == entity.id_client
                              select o;
                    obj.ToList()[0].name = entity.name;
                    obj.ToList()[0].surname = entity.surname;
                    obj.ToList()[0].patronymic= entity.patronymic;
                    obj.ToList()[0].login = entity.login;
                    obj.ToList()[0].password = entity.password;
                    obj.ToList()[0].access_level = entity.access_level;
                    obj.ToList()[0].password = entity.password;
                    obj.ToList()[0].mail = entity.mail;
                    obj.ToList()[0].phone_number = entity.phone_number;
                    obj.ToList()[0].sex = entity.sex;
                    obj.ToList()[0].growth = entity.growth;
                    obj.ToList()[0].chest = entity.chest;
                    obj.ToList()[0].waist = entity.waist;
                    obj.ToList()[0].hip = entity.hip;
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
