using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.tool;

namespace WorkstationStudioGarment_WinForm.modules
{
    class ChartControlModule
    {
        private SupplyService supplyS = new SupplyService();
        private ProductService productS = new ProductService();
        private OrderService orderS = new OrderService();

        /// <summary>
        /// Возвращает сумму проданных товаров за месяц
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public decimal GetTotalSumMonth(int month, int year)
        {
            try
            {
                using(StudioDB db = new StudioDB())
                {
                    var orders = orderS.All();
                    decimal res = 0;
                    foreach(var item in orders)
                    {
                        if (Parser.ParseStringToIntArray(item.order_date, '.')[1] == month &&
                            Parser.ParseStringToIntArray(item.order_date, '.')[2] == year)
                        {
                            res += item.total_sum;
                        }
                    }

                    return res;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Возвращает затраченную сумму за месяц поставки
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>

        public decimal GetTotalSumMonthSupply(int month, int year)
        {
            try
            {
                using (StudioDB db = new StudioDB())
                {
                    var supplies = supplyS.All();
                    int idSupply = -1;
                    foreach (var item in supplies)
                    {
                        if (Parser.ParseStringToIntArray(item.delivery_date, '.')[1] == month &&
                            Parser.ParseStringToIntArray(item.delivery_date, '.')[2] == year)
                        {
                            idSupply = item.id_supply;
                        }
                    }

                    decimal res = 0;
                    if (idSupply != -1)
                    {
                        var products = db.PRODUCTs.Where(x => x.id_supply == idSupply);
                        foreach(var item in products)
                        {
                            res += DecrementPercentages(item.price, 10) * item.count;
                        }

                        var salesProducts = from b in db.BASKETs
                                            join p in db.PRODUCTs
                                            on b.id_product equals p.id_product
                                            where p.id_supply == idSupply
                                            select new { b.count, p.price };
                        foreach(var item in salesProducts)
                        {
                            res += DecrementPercentages(item.price, 10) * item.count;
                        }
                    }
                    return res;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private decimal DecrementPercentages(decimal sum, decimal percent)
        {
            percent = percent / 100;
            return sum - sum * percent;
        }
    }
}
