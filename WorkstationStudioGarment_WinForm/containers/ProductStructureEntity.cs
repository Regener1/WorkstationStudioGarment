using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment_WinForm.containers
{
    class ProductStructureEntity
    {
        private int idProductStructure;
        private int count;
        private string materialName;

        public ProductStructureEntity() { }

        public ProductStructureEntity(int idProductStructure, int count, string materialName)
        {
            this.idProductStructure = idProductStructure;
            this.count = count;
            this.materialName = materialName;
        }

        public int IdProductStructure
        {
            get
            {
                return idProductStructure;
            }

            set
            {
                idProductStructure = value;
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
