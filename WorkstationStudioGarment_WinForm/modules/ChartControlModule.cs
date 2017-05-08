﻿using System;
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
                        if (Parser.ParseStringToArray(item.order_date, '.')[1] == month &&
                            Parser.ParseStringToArray(item.order_date, '.')[2] == year)
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
                        if (Parser.ParseStringToArray(item.delivery_date, '.')[1] == month &&
                            Parser.ParseStringToArray(item.delivery_date, '.')[2] == year)
                        {
                            idSupply = item.id_supply;
                        }
                    }

                    decimal res = 0;
                    if (idSupply != -1)
                    {
                        res = db.PRODUCTs
                            .Where(x => x.id_supply == idSupply)
                            .Sum(x => x.price);
                    }
                    return res;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
