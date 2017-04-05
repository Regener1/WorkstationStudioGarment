using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment_WinForm.containers
{
    public class ProductStructureContainer
    {
        private int idMaterial;
        private int count;
        private string materialName;

        public ProductStructureContainer() { }

        public ProductStructureContainer(int idProductStructure, int count, string materialName)
        {
            this.idMaterial = idProductStructure;
            this.count = count;
            this.materialName = materialName;
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

        public string MaterialName
        {
            get
            {
                return materialName;
            }

            set
            {
                materialName = value;
            }
        }
    }
}
