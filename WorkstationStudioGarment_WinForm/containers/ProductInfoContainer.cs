using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.containers
{
    class ProductMaterial
    {
        private int idMaterial;
        private string name;
        private int count;

        public ProductMaterial() { }

        public ProductMaterial(int idMaterial, string name, int count)
        {
            this.idMaterial = idMaterial;
            this.name = name;
            this.count = count;
        }

        public int IdMaterial
        {
            get
            {
                return idMaterial;
            }

            set
            {
                idMaterial = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
    }

    class ProductInfoContainer
    {
        private PRODUCT product;
        private List<ProductMaterial> productMaterials = new List<ProductMaterial>();

        public ProductInfoContainer() { }
        public ProductInfoContainer(PRODUCT product, List<ProductMaterial> productMaterials)
        {
            this.product = product;
            this.productMaterials.AddRange(productMaterials);
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

        public List<ProductMaterial> ProductMaterials
        {
            get
            {
                return productMaterials;
            }

            set
            {
                productMaterials = value;
            }
        }
    }
}
