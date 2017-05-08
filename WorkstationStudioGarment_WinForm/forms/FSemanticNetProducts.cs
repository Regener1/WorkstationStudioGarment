using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.containers;
using WorkstationStudioGarment_WinForm.modules;
using WorkstationStudioGarment_WinForm.tool;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FSemanticNetProducts : Form
    {
        private ProductGraphModule productGraphModule = new ProductGraphModule();
        private List<ProductInfoContainer> productsInfo;
        private List<MaterialInfoContainer> materialsInfo;

        private GraphNode currObj;
        private bool isDown = false;
        private Point oldPoint;
        private Bitmap bmp;
        private Graphics g;

        private List<GraphNode> productNodes = new List<GraphNode>();
        private List<GraphNode> materialNodes = new List<GraphNode>();
        private List<GraphModel> graphModels = new List<GraphModel>();

        private void Render()
        {
            g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);

            foreach (GraphModel item in graphModels)
            {
                if(!item.Parent.IsDrawing || !item.Child.IsDrawing)
                {
                    continue;
                }
                
                if (item.LineDescription.IsAdditionalNode && cbAdditionalInfo.Checked)
                {
                    item.LineDescription.DrawConnection();
                    item.LineDescription.DrawNode(Brushes.White);                    
                }
                if (!item.LineDescription.IsAdditionalNode)
                {
                    item.LineDescription.DrawConnection();
                    item.LineDescription.DrawNode(Brushes.White);
                }
            }
            foreach (GraphNode item in productNodes)
            {
                if (!item.IsDrawing)
                {
                    continue;
                }
                item.DrawNode(Brushes.DeepSkyBlue);
            }

            foreach (GraphNode item in materialNodes)
            {
                if (!item.IsDrawing)
                {
                    continue;
                }
                item.DrawNode(Brushes.LightGreen);
            }

            pbGraph.Image = bmp;
        }

        public FSemanticNetProducts()
        {
            InitializeComponent();
        }

        private void FSemanticNetProducts_Load(object sender, EventArgs e)
        {
            productsInfo = productGraphModule.GetProductsInfo();
            materialsInfo = productGraphModule.GetMaterialsInfo();

            

            bmp = new Bitmap(pbGraph.Width, pbGraph.Height);
            g = Graphics.FromImage(bmp);

            int alpha = 0;
            int radius = 200;
            int beginX = bmp.Width / 2;
            int beginY = bmp.Height / 2;
            GraphNode node;
            foreach (ProductInfoContainer item in productsInfo)
            {
                int x = (int)(radius * Math.Sin(alpha * Math.PI / 180)) + beginX;
                int y = (int)(radius * Math.Cos(alpha * Math.PI / 180)) + beginY;
                node = new GraphNode(g, new GraphicsPath(), item.Product.id_product, x, y);
                node.InfoLines.Add(item.Product.id_product.ToString());
                node.InfoLines.Add(item.Product.title);
                node.InfoLines.Add(item.Product.category);
                node.Init();

                productNodes.Add(node);
                alpha += 20;
            }

            radius = 100;
            alpha = 0;
            foreach (MaterialInfoContainer item in materialsInfo)
            {
                int x = (int)(radius * Math.Sin(alpha * Math.PI / 180)) + beginX;
                int y = (int)(radius * Math.Cos(alpha * Math.PI / 180)) + beginY;
                node = new GraphNode(g, new GraphicsPath(), item.Material.id_material, x, y);
                node.InfoLines.Add(item.Material.id_material.ToString());
                node.InfoLines.Add(item.Material.name);
                node.InfoLines.Add(item.Material.count.ToString());
                node.Init();

                materialNodes.Add(node);
                alpha += 40;
            }

            // добавление узлов товару
            for(int i = 0; i < productNodes.Count; i++)
            {
                for(int j = 0; j < productsInfo[i].ProductMaterials.Count; j++)
                {
                    GraphNode gNode = 
                        materialNodes.FirstOrDefault(c => c.Id == productsInfo[i].ProductMaterials[j].IdMaterial);

                    GraphNode lineDescription = 
                        new GraphNode(g, null, productNodes[i], gNode);
                    lineDescription.InfoLines.Add(productsInfo[i].ProductMaterials[j].Count.ToString());
                    lineDescription.Init();

                    if(graphModels.Exists(x => (x.Parent.Id == gNode.Id) && 
                                            (x.Child.Id == productNodes[i].Id)))
                    {
                        graphModels.Add(new GraphModel(productNodes[i], gNode, lineDescription));
                    }
                }

                for (int j = 0; j < productNodes.Count; j++)
                {
                    if (i == j)
                        continue;

                    GraphNode lineDescription =
                        new GraphNode(g, null, productNodes[i], productNodes[j]);
                    lineDescription.IsAdditionalNode = true;
                    if(productsInfo[i].Product.count > productsInfo[j].Product.count)
                    {
                        lineDescription.InfoLines.Add(productsInfo[i].Product.id_product.ToString() +
                            "("+productsInfo[i].Product.count+")"
                             + " > " +
                             productsInfo[j].Product.id_product.ToString() +
                             "(" + productsInfo[j].Product.count + ")");
                    }
                    else if (productsInfo[i].Product.count < productsInfo[j].Product.count)
                    {
                        lineDescription.InfoLines.Add(productsInfo[i].Product.id_product.ToString() +
                            "(" + productsInfo[i].Product.count + ")"
                             + " < " +
                             productsInfo[j].Product.id_product.ToString() +
                             "(" + productsInfo[j].Product.count + ")");
                    }
                    else 
                    {
                        lineDescription.InfoLines.Add(productsInfo[i].Product.id_product.ToString() +
                            "(" + productsInfo[i].Product.count + ")"
                             + " = " +
                             productsInfo[j].Product.id_product.ToString()+
                             "(" + productsInfo[j].Product.count + ")");
                    }
                    lineDescription.Init();

                    if (!graphModels.Exists(x => (x.Parent.Id == productNodes[j].Id) &&
                         (x.Child.Id == productNodes[i].Id)))
                    {
                        graphModels.Add(new GraphModel(productNodes[i], productNodes[j], lineDescription));
                    }
                }
            }

            // добавление узлов материалу
            for (int i = 0; i < materialNodes.Count; i++)
            {
                for (int j = 0; j < materialNodes.Count; j++)
                {
                    if (i == j)
                        continue;

                    GraphNode lineDescription =
                        new GraphNode(g, null, materialNodes[i], materialNodes[j]);
                    lineDescription.IsAdditionalNode = true;
                    if (materialsInfo[i].Material.count > materialsInfo[j].Material.count)
                    {
                        lineDescription.InfoLines.Add(materialsInfo[i].Material.id_material.ToString() +
                            "("+ materialsInfo[i].Material.count + ")"
                            + " > " +
                            materialsInfo[j].Material.id_material.ToString() +
                           "(" + materialsInfo[j].Material.count + ")");
                    }
                    else if (materialsInfo[i].Material.count < materialsInfo[j].Material.count)
                    {
                        lineDescription.InfoLines.Add(materialsInfo[i].Material.id_material.ToString() +
                            "(" + materialsInfo[i].Material.count + ")"
                            + " < " +
                            materialsInfo[j].Material.id_material.ToString() +
                           "(" + materialsInfo[j].Material.count + ")");
                    }
                    else
                    {
                        lineDescription.InfoLines.Add(materialsInfo[i].Material.id_material.ToString() +
                            "(" + materialsInfo[i].Material.count + ")"
                            + " = " + 
                           materialsInfo[j].Material.id_material.ToString() +
                           "(" + materialsInfo[j].Material.count + ")");
                    }
                    lineDescription.Init();

                    if (!graphModels.Exists(x => (x.Parent.Id == productNodes[j].Id) &&
                         (x.Child.Id == materialNodes[i].Id)))
                    {
                        graphModels.Add(new GraphModel(materialNodes[i], materialNodes[j], lineDescription));
                    }
                }
            }

            for (int i = 0; i < productNodes.Count; i++)
            {
                checkedLBProducts.Items.Add(productNodes[i], productNodes[i].IsDrawing);
            }
            for (int i = 0; i < materialNodes.Count; i++)
            {
                checkedLBMaterials.Items.Add(materialNodes[i], materialNodes[i].IsDrawing);
            }

            Render();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void pbGraph_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            oldPoint = e.Location;
            Console.WriteLine(e.Location.ToString());
            //Ищем объект, в который попала точка. Если таких несколько, то найден будет первый по списку
            foreach (GraphNode item in productNodes)
            {
                if (item.Path.GetBounds().Contains(e.Location))
                {
                    Console.WriteLine(item.Path.GetBounds().ToString());
                    currObj = item;//Запоминаем найденный объект
                    return;
                }
            }

            foreach (GraphNode item in materialNodes)
            {
                if (item.Path.GetBounds().Contains(e.Location))
                {
                    Console.WriteLine(item.Path.GetBounds().ToString());
                    currObj = item;//Запоминаем найденный объект
                    return;
                }
            }
        }

        private void pbGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDown)
                return;
            if (currObj == null)
                return;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    //Считаем смещение курсора
                    int deltaX, deltaY;
                    deltaX = e.Location.X - oldPoint.X;
                    deltaY = e.Location.Y - oldPoint.Y;
                    //Смещаем нарисованный объект
                    currObj.Cx += deltaX;
                    currObj.Cy += deltaY;
                    currObj.Path.Transform(new Matrix(1, 0, 0, 1, deltaX, deltaY));

                    //Запоминаем новое положение курсора
                    oldPoint = e.Location;
                    break;
                default:
                    break;
            }
            Render();

        }

        private void pbGraph_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            currObj = null;
        }

        private void checkedLBProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedLBProducts.Items.Count; i++)
            {
                productNodes[i].IsDrawing = checkedLBProducts.GetItemChecked(i);
            }
            Render();
        }

        private void checkedLBMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedLBMaterials.Items.Count; i++)
            {
                materialNodes[i].IsDrawing = checkedLBMaterials.GetItemChecked(i);
            }
            Render();
        }

        private void cbAdditionalInfo_CheckedChanged(object sender, EventArgs e)
        {
            Render();
        }
    }
}
