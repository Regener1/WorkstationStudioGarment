using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.containers
{
    class ClientProductContainer
    {
        private PRODUCT product;
        private int count;
        private decimal price;


        public ClientProductContainer() { }

        public ClientProductContainer(PRODUCT product, int count, decimal price)
        {
            this.product = product;
            this.price = price;
            this.count = count;
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
    }
}
