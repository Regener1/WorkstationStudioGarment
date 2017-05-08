using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.containers
{
    class MaterialInfoContainer
    {
        private MATERIAL material;

        private List<PRODUCT> products = new List<PRODUCT>();

        public MaterialInfoContainer() { }
        public MaterialInfoContainer(MATERIAL material, List<PRODUCT> products)
        {
            this.material = material;
            this.products.AddRange(products);
        }


        public MATERIAL Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        public List<PRODUCT> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }
    }
}
