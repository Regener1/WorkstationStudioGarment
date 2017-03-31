using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.containers
{
    class ProductEntity
    {
        //заполнить id поставки и id материала
        private PRODUCT product;
        private List<PRODUCT_STRUCTURE> productStructures;

        public ProductEntity() { }

        public ProductEntity(PRODUCT product, List<PRODUCT_STRUCTURE> productStructures)
        {
            this.product = product;
            this.productStructures = productStructures;
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
        
        public List<PRODUCT_STRUCTURE> ProductStructures
        {
            get
            {
                return productStructures;
            }

            set
            {
                productStructures = value;
            }
        }

    }
}
