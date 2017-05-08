using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment_WinForm.tool
{
    class GraphModel
    {
        private GraphNode parent;
        private GraphNode child;
        private GraphNode lineDescription;

        public GraphModel() { }
        public GraphModel(GraphNode parent, GraphNode child, GraphNode lineDescription)
        {
            this.parent = parent;
            this.child = child;
            this.lineDescription = lineDescription;
        }

        public GraphNode Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public GraphNode Child
        {
            get
            {
                return child;
            }

            set
            {
                child = value;
            }
        }

        public GraphNode LineDescription
        {
            get
            {
                return lineDescription;
            }

            set
            {
                lineDescription = value;
            }
        }

        
    }
}
