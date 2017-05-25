using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.tool;

namespace WorkstationStudioGarment_WinForm.containers
{
    class ClientProductContainer
    {
        private PRODUCT product;
        private DateTime date;
        private DateTime time;
        private int count;
        private decimal price;


        public ClientProductContainer() { }

        public ClientProductContainer(PRODUCT product, string date, string time, int count, decimal price)
        {
            this.product = product;
            this.price = price;
            this.count = count;
            int[] values = Parser.ParseStringToIntArray(date, '.');
            this.date = new DateTime(values[2],values[1],values[0]);
            values = Parser.ParseStringToIntArray(time, ':');
            this.time = new DateTime(1, 1, 1, values[0], values[1], values[2]);
        }

        public PRODUCT Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        
    }
}
