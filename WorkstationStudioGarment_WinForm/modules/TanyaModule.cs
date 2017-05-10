using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.modules
{
    class TanyaModule
    {
        BasketService basketService = new BasketService();
        List<CLIENT> candidates_list = new List<CLIENT>();


        /// <summary>
        /// количество заказанных продуктов когда-либо
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>

        public bool FirstIf(CLIENT client)
        {
            try
            {
                int count = 0;
                foreach (var o in basketService.All())
                {
                    if (o.id_client == client.id_client)
                    {
                        if (o.id_product != 0)
                        {
                            count++;
                        }
                    }
                }
                if (count >= 3)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// количество заказов
        /// </summary>
        /// <returns></returns>
        public bool SecondIf(CLIENT client)
        {
            try
            {
                int count = 0;
                foreach (var o in basketService.All())
                {
                    if (o.id_client == client.id_client)
                    {
                        if (o.id_order != 0)
                        {
                            count++;
                        }
                    }
                }
                if (count >= 3)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Сумма заказа больше 5000 тысяч рублей
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool ThirdIf(CLIENT client)
        {
            try
            {
                 using (StudioDB db = new StudioDB())
                {
                    var sum = from b in db.BASKETs
                              join i in db.ORDERs
                              on b.id_order equals i.id_order
                              where b.id_client == client.id_client && i.total_sum > 5000
                              select b;

                    if (sum.ToList().Count != 0) {
                        return true;
                    }
                    return false;
                 }
              
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CLIENT> ShoppersList() {
            try {
                using (StudioDB db = new StudioDB())
                {
                    foreach (CLIENT c in db.CLIENTs) {
                        if (FirstIf(c)) {
                            if (!candidates_list.Contains(c))
                                candidates_list.Add(c);
                        }
                        if (SecondIf(c)) {
                            if (!candidates_list.Contains(c))
                                candidates_list.Add(c);
                        }
                        if (ThirdIf(c)) {
                            if (!candidates_list.Contains(c))
                                candidates_list.Add(c);
                        }
                    }
                }
                return candidates_list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
