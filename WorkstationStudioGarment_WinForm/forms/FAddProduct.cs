﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkstationStudioGarment_WinForm.control;
using WorkstationStudioGarment_WinForm.manager;
using WorkstationStudioGarment_WinForm.tool;

namespace WorkstationStudioGarment_WinForm.forms
{
    public partial class FAddProduct : Form
    {
        private int idSupply = -1;
        private ProductsManager pManager = new ProductsManager();
        private PRODUCT product;

        public FAddProduct()
        {
            InitializeComponent();
        }

        public int IdSupply
        {
            get { return idSupply; }
            set { idSupply = value; }
        }

        public PRODUCT GetProduct()
        {
            return product;
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG (*png) | *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(ofd.FileName);
            }

            tbPath.Text = ofd.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            product = new PRODUCT();

            if (idSupply != -1)
            {
                product.title = tbName.Text;
                product.category = tbCategory.Text;
                product.size = Convert.ToInt32(tbSize.Text);
                product.color = tbColor.Text;
                product.photo = ImgConverter.ImageToString(pictureBoxPhoto.Image);
                product.price = Convert.ToInt32(tbPrice.Text);
                product.count = Convert.ToInt32(tbCount.Text);
                product.id_supply = idSupply;
            }

            pManager.Add(product);
        }
    }
}