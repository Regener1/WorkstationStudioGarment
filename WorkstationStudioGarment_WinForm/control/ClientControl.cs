using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class ClientControl
    {
        //public CLIENT client = new CLIENT();

        
        /// <summary>
        /// Add clients into CLIENT table 
        /// </summary>
        public void addClients(int id_client, string login, string password,
                                int accsess_level, string surname, string name, string patronymic,
                                string mail, string phone_number, int sex, int growth, int chest,
                                int waist, int hip) {
            try { 
                using(StudioDB db = new StudioDB()) {
                    CLIENT client = new CLIENT();
                    
                }
            }
        
        }
        
        /// <summary>
        /// Select all record from CLIENT table
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CLIENT> selectAll()
        { 
            using(StudioDB studiodb = new StudioDB()) {
                
                var clientQuery = from cl in studiodb.CLIENTs
                                  select cl;
                return clientQuery;
            } 
        }
    }
}
