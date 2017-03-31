using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    public class ClientControl
    {
        public void AddClients(string login, string password, string surname, 
                                string name, string patronymic, string mail, string phone_number, 
                                int sex, int growth, int chest, int waist, int hip)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    CLIENT client = new CLIENT();
                    client.login = login;
                    client.password = password;
                    client.surname = surname;
                    client.name = name;
                    client.patronymic = patronymic;
                    client.mail = mail;
                    client.access_level = 0;
                    client.phone_number = phone_number;
                    client.sex = sex;
                    client.growth = growth;
                    client.chest = chest;
                    client.waist = waist;
                    client.hip = hip;
                    db.CLIENTs.Add(client);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select all record from CLIENT table
        /// </summary>
        public IEnumerable<CLIENT> SelectAll()
        {
            using (StudioDB db = new StudioDB())
            {

                var clientQuery = from cl in db.CLIENTs
                                  select cl;
                return clientQuery;
            }
        }


        public void ChangeParametrs(string login, string mail, string phone_number,
                                 int growth, int chest, int waist, int hip)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var tmpclient = from cl in db.CLIENTs
                                    where cl.login == login
                                    select cl;
                    (tmpclient as CLIENT).mail = mail;
                    (tmpclient as CLIENT).phone_number = phone_number;
                    (tmpclient as CLIENT).growth = growth;
                    (tmpclient as CLIENT).chest = chest;
                    (tmpclient as CLIENT).waist = waist;
                    (tmpclient as CLIENT).hip = hip;
                    db.SaveChanges();
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public List<CLIENT> SearchClient(string login, string password) { 
            try {
                using (StudioDB db = new StudioDB()) {
                    var tmpclient = from cl in db.CLIENTs
                                    where cl.login == login && cl.password == password
                                    select cl;
                    return tmpclient.ToList();
                }
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        public List<CLIENT> SearchClientByLogin(string login) {
            try { 
                using(StudioDB db = new StudioDB()) {
                    var tmpclient = from cl in db.CLIENTs
                                    where cl.login == login
                                    select cl;
                    return tmpclient.ToList();
                }
            }
            catch(Exception ex) {
                throw ex;
            }
        }
    }
}
