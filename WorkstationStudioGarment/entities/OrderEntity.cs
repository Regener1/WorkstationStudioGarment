using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment.entities
{
    class OrderEntity
    {
        public int id_order;
        DateTime order_date;
        DateTime order_time;
        string order_status;
        double total_sum;

        public OrderEntity() { 
        
        }

    }
}
