﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.containers;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.modules
{
    class ClientControlModule
    {

        private ClientService clientS = new ClientService();
        private ProductService productS = new ProductService();
        private BasketService basketS = new BasketService();

        public List<CLIENT> AllClients()
        {
            return clientS.All();
        }

        public List<ClientProductContainer> GetClientsProduct(CLIENT entity)
        {
            try
            {
                using(StudioDB db = new StudioDB())
                {
                    var productsInfo = from b in db.BASKETs
                                       join p in db.PRODUCTs on b.id_product equals p.id_product
                                       where b.id_client == entity.id_client
                                       select new { p, b.count, price = b.count * p.price };
                    return productsInfo
                        .ToList()
                        .Select(x => new ClientProductContainer(x.p, x.count, x.price))
                        .ToList();
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}