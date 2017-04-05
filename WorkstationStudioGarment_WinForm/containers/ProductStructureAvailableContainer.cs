using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment_WinForm.containers
{
    class ProductStructureAvailableContainer
    {
        private string name;
        private int necessaryCount;
        private int availableCount;

        

        public ProductStructureAvailableContainer() { }

        public ProductStructureAvailableContainer(string name, int necessaryCount, int availableCount)
        {
            this.name = name;
            this.necessaryCount = necessaryCount;
            this.availableCount = availableCount;
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

        public int NecessaryCount
        {
            get
            {
                return necessaryCount;
            }

            set
            {
                necessaryCount = value;
            }
        }

        public int AvailableCount
        {
            get
            {
                return availableCount;
            }

            set
            {
                availableCount = value;
            }
        }
    }
}
