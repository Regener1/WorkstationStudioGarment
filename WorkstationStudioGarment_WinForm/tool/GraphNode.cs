using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WorkstationStudioGarment_WinForm.tool
{
    class GraphNode 
    {
        private int id;

        private Graphics g;
        private Pen p;

        private GraphicsPath path;

        private GraphNode parent = null;
        private GraphNode child = null;

        private bool isDrawing = true;
        private bool isAdditionalNode = false;

        private float cx;
        private float cy;

        private float width;
        private float height;

        private Font stringFont;
        private string nodeText;
        private List<string> infoLines = new List<string>();

        public GraphNode(Graphics g, GraphicsPath path, GraphNode parent, GraphNode child)
        {
            this.g = g;
            this.path = path;
            this.parent = parent;
            this.child = child;
            CalculateCenter();
        }

        public GraphNode(Graphics g, GraphicsPath path, float cx, float cy)
        {
            this.g = g;
            this.path = path;
            this.cx = cx;
            this.cy = cy;
        }
        public GraphNode(Graphics g, GraphicsPath path, int id, float cx, float cy)
        {
            this.g = g;
            this.path = path;
            this.id = id;
            this.cx = cx;
            this.cy = cy;
        }

        public Graphics G
        {
            get
            {
                return g;
            }

            set
            {
                g = value;
            }
        }

        public float Cx
        {
            get
            {
                return cx;
            }

            set
            {
                cx = value;
            }
        }

        public float Cy
        {
            get
            {
                return cy;
            }

            set
            {
                cy = value;
            }
        }

        public float Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public List<string> InfoLines
        {
            get
            {
                return infoLines;
            }

            set
            {
                infoLines = value;
            }
        }

        public GraphicsPath Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public bool IsDrawing
        {
            get
            {
                return isDrawing;
            }

            set
            {
                isDrawing = value;
            }
        }

        public bool IsAdditionalNode
        {
            get
            {
                return isAdditionalNode;
            }

            set
            {
                isAdditionalNode = value;
            }
        }

        public void Init()
        {
            StringBuilder lines = new StringBuilder();
            p = new Pen(Color.Black);
            stringFont = new Font("Arial", 11, FontStyle.Bold);
            foreach (string item in infoLines)
            {
                lines.AppendLine(item);
            }

            nodeText = lines.ToString();

            SizeF stringSize = g.MeasureString(nodeText, stringFont);
            width = stringSize.Width;
            height = stringSize.Height;
            Rectangle rect = new Rectangle((int)(cx - width / 2), (int)(cy - height / 2),
                                           (int)width, (int)height);
            if(path != null)
                path.AddRectangle(rect);
        }

        public void CalculateCenter()
        {
            cx = (int)(parent.Cx + child.Cx) / 2;
            cy = (int)(parent.Cy + child.Cy) / 2;
        }

        public void DrawNode(Brush brush)
        {
            if(parent != null)
                CalculateCenter();
            g.FillRectangle(brush, (int)(cx - width / 2), (int)(cy - height / 2),
                                           (int)width, (int)height);
            g.DrawString(nodeText, stringFont, Brushes.Black, cx - (int)width / 2, cy - (int)height / 2);      
        }

        public void DrawConnection()
        {
            g.DrawLine(p, parent.Cx, parent.Cy, child.Cx, child.Cy);

        }

        public override string ToString()
        {
            return infoLines[1];
        }

    }
}
