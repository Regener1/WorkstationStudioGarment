namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        ///        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panelMannequin = new System.Windows.Forms.Panel();
            this.pbMannequin = new System.Windows.Forms.PictureBox();
            this.listBoxClothesOnMannequin = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblClientLogin = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mPanelCategoryExpand = new MetroFramework.Controls.MetroPanel();
            this.cListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.mlCategoryExpander = new MetroFramework.Controls.MetroLink();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mlColorExpander = new MetroFramework.Controls.MetroLink();
            this.mPanelColorExpand = new MetroFramework.Controls.MetroPanel();
            this.cListBoxColors = new System.Windows.Forms.CheckedListBox();
            this.mlSizeExpander = new MetroFramework.Controls.MetroLink();
            this.mPanelSizeExpand = new MetroFramework.Controls.MetroPanel();
            this.cListBoxSize = new System.Windows.Forms.CheckedListBox();
            this.mlUpProduct = new MetroFramework.Controls.MetroLink();
            this.mlRemoveProduct = new MetroFramework.Controls.MetroLink();
            this.mlDownProduct = new MetroFramework.Controls.MetroLink();
            this.panelMannequin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMannequin)).BeginInit();
            this.mPanelCategoryExpand.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mPanelColorExpand.SuspendLayout();
            this.mPanelSizeExpand.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 250);
            this.imageList.TransparentColor = System.Drawing.Color.DarkGray;
            // 
            // panelMannequin
            // 
            this.panelMannequin.AllowDrop = true;
            this.panelMannequin.Controls.Add(this.pbMannequin);
            this.panelMannequin.Location = new System.Drawing.Point(703, 95);
            this.panelMannequin.Name = "panelMannequin";
            this.panelMannequin.Size = new System.Drawing.Size(214, 536);
            this.panelMannequin.TabIndex = 4;
            this.panelMannequin.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragDrop);
            this.panelMannequin.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragEnter);
            // 
            // pbMannequin
            // 
            this.pbMannequin.BackColor = System.Drawing.Color.White;
            this.pbMannequin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMannequin.ImageLocation = "";
            this.pbMannequin.InitialImage = null;
            this.pbMannequin.Location = new System.Drawing.Point(0, 0);
            this.pbMannequin.Name = "pbMannequin";
            this.pbMannequin.Size = new System.Drawing.Size(214, 536);
            this.pbMannequin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMannequin.TabIndex = 3;
            this.pbMannequin.TabStop = false;
            // 
            // listBoxClothesOnMannequin
            // 
            this.listBoxClothesOnMannequin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxClothesOnMannequin.FormattingEnabled = true;
            this.listBoxClothesOnMannequin.Location = new System.Drawing.Point(923, 117);
            this.listBoxClothesOnMannequin.Name = "listBoxClothesOnMannequin";
            this.listBoxClothesOnMannequin.Size = new System.Drawing.Size(165, 507);
            this.listBoxClothesOnMannequin.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "FTanya";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProducts.LargeImageList = this.imageList;
            this.listViewProducts.Location = new System.Drawing.Point(214, 95);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(483, 536);
            this.listViewProducts.SmallImageList = this.imageList;
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            this.listViewProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(716, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Здравствуйте,";
            // 
            // lblClientLogin
            // 
            this.lblClientLogin.Location = new System.Drawing.Point(805, 66);
            this.lblClientLogin.Name = "lblClientLogin";
            this.lblClientLogin.Size = new System.Drawing.Size(112, 23);
            this.lblClientLogin.TabIndex = 12;
            this.lblClientLogin.Text = "our client\'s login";
            this.lblClientLogin.UseSelectable = true;
            this.lblClientLogin.Click += new System.EventHandler(this.lblClientLogin_LinkClicked);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(923, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(165, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Вы добавили на манекен";
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1123, 659);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 53);
            this.metroPanel1.TabIndex = 96;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mPanelCategoryExpand
            // 
            this.mPanelCategoryExpand.Controls.Add(this.cListBoxCategories);
            this.mPanelCategoryExpand.HorizontalScrollbarBarColor = true;
            this.mPanelCategoryExpand.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelCategoryExpand.HorizontalScrollbarSize = 10;
            this.mPanelCategoryExpand.Location = new System.Drawing.Point(3, 32);
            this.mPanelCategoryExpand.Name = "mPanelCategoryExpand";
            this.mPanelCategoryExpand.Size = new System.Drawing.Size(170, 140);
            this.mPanelCategoryExpand.TabIndex = 97;
            this.mPanelCategoryExpand.VerticalScrollbarBarColor = true;
            this.mPanelCategoryExpand.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelCategoryExpand.VerticalScrollbarSize = 10;
            // 
            // cListBoxCategories
            // 
            this.cListBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cListBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cListBoxCategories.FormattingEnabled = true;
            this.cListBoxCategories.Location = new System.Drawing.Point(0, 0);
            this.cListBoxCategories.Name = "cListBoxCategories";
            this.cListBoxCategories.Size = new System.Drawing.Size(170, 140);
            this.cListBoxCategories.TabIndex = 2;
            this.cListBoxCategories.SelectedIndexChanged += new System.EventHandler(this.cListBoxCategories_SelectedIndexChanged);
            // 
            // mlCategoryExpander
            // 
            this.mlCategoryExpander.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mlCategoryExpander.Location = new System.Drawing.Point(3, 3);
            this.mlCategoryExpander.Name = "mlCategoryExpander";
            this.mlCategoryExpander.Size = new System.Drawing.Size(170, 23);
            this.mlCategoryExpander.TabIndex = 98;
            this.mlCategoryExpander.Text = "Категория <<";
            this.mlCategoryExpander.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlCategoryExpander.UseSelectable = true;
            this.mlCategoryExpander.Click += new System.EventHandler(this.mlCategoryExpander_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mlCategoryExpander);
            this.flowLayoutPanel1.Controls.Add(this.mPanelCategoryExpand);
            this.flowLayoutPanel1.Controls.Add(this.mlColorExpander);
            this.flowLayoutPanel1.Controls.Add(this.mPanelColorExpand);
            this.flowLayoutPanel1.Controls.Add(this.mlSizeExpander);
            this.flowLayoutPanel1.Controls.Add(this.mPanelSizeExpand);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 536);
            this.flowLayoutPanel1.TabIndex = 99;
            // 
            // mlColorExpander
            // 
            this.mlColorExpander.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mlColorExpander.Location = new System.Drawing.Point(3, 178);
            this.mlColorExpander.Name = "mlColorExpander";
            this.mlColorExpander.Size = new System.Drawing.Size(170, 23);
            this.mlColorExpander.TabIndex = 99;
            this.mlColorExpander.Text = "Цвет <<";
            this.mlColorExpander.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlColorExpander.UseSelectable = true;
            this.mlColorExpander.Click += new System.EventHandler(this.mlColorExpander_Click);
            // 
            // mPanelColorExpand
            // 
            this.mPanelColorExpand.Controls.Add(this.cListBoxColors);
            this.mPanelColorExpand.HorizontalScrollbarBarColor = true;
            this.mPanelColorExpand.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelColorExpand.HorizontalScrollbarSize = 10;
            this.mPanelColorExpand.Location = new System.Drawing.Point(3, 207);
            this.mPanelColorExpand.Name = "mPanelColorExpand";
            this.mPanelColorExpand.Size = new System.Drawing.Size(170, 140);
            this.mPanelColorExpand.TabIndex = 100;
            this.mPanelColorExpand.VerticalScrollbarBarColor = true;
            this.mPanelColorExpand.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelColorExpand.VerticalScrollbarSize = 10;
            // 
            // cListBoxColors
            // 
            this.cListBoxColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cListBoxColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cListBoxColors.FormattingEnabled = true;
            this.cListBoxColors.Location = new System.Drawing.Point(0, 0);
            this.cListBoxColors.Name = "cListBoxColors";
            this.cListBoxColors.Size = new System.Drawing.Size(170, 140);
            this.cListBoxColors.TabIndex = 2;
            this.cListBoxColors.SelectedIndexChanged += new System.EventHandler(this.cListBoxColors_SelectedIndexChanged);
            // 
            // mlSizeExpander
            // 
            this.mlSizeExpander.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mlSizeExpander.Location = new System.Drawing.Point(3, 353);
            this.mlSizeExpander.Name = "mlSizeExpander";
            this.mlSizeExpander.Size = new System.Drawing.Size(170, 23);
            this.mlSizeExpander.TabIndex = 101;
            this.mlSizeExpander.Text = "Размер <<";
            this.mlSizeExpander.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlSizeExpander.UseSelectable = true;
            this.mlSizeExpander.Click += new System.EventHandler(this.mlSizeExpander_Click);
            // 
            // mPanelSizeExpand
            // 
            this.mPanelSizeExpand.Controls.Add(this.cListBoxSize);
            this.mPanelSizeExpand.HorizontalScrollbarBarColor = true;
            this.mPanelSizeExpand.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelSizeExpand.HorizontalScrollbarSize = 10;
            this.mPanelSizeExpand.Location = new System.Drawing.Point(3, 382);
            this.mPanelSizeExpand.Name = "mPanelSizeExpand";
            this.mPanelSizeExpand.Size = new System.Drawing.Size(170, 140);
            this.mPanelSizeExpand.TabIndex = 102;
            this.mPanelSizeExpand.VerticalScrollbarBarColor = true;
            this.mPanelSizeExpand.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelSizeExpand.VerticalScrollbarSize = 10;
            // 
            // cListBoxSize
            // 
            this.cListBoxSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cListBoxSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cListBoxSize.FormattingEnabled = true;
            this.cListBoxSize.Location = new System.Drawing.Point(0, 0);
            this.cListBoxSize.Name = "cListBoxSize";
            this.cListBoxSize.Size = new System.Drawing.Size(170, 140);
            this.cListBoxSize.TabIndex = 2;
            this.cListBoxSize.SelectedIndexChanged += new System.EventHandler(this.cListBoxSize_SelectedIndexChanged);
            // 
            // mlUpProduct
            // 
            this.mlUpProduct.BackgroundImage = global::WorkstationStudioGarment_WinForm.Properties.Resources.go_up;
            this.mlUpProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mlUpProduct.Location = new System.Drawing.Point(1094, 117);
            this.mlUpProduct.Name = "mlUpProduct";
            this.mlUpProduct.Size = new System.Drawing.Size(35, 35);
            this.mlUpProduct.TabIndex = 100;
            this.mlUpProduct.UseSelectable = true;
            this.mlUpProduct.Click += new System.EventHandler(this.mlUpProduct_Click);
            // 
            // mlRemoveProduct
            // 
            this.mlRemoveProduct.BackgroundImage = global::WorkstationStudioGarment_WinForm.Properties.Resources.cross;
            this.mlRemoveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mlRemoveProduct.Location = new System.Drawing.Point(1092, 199);
            this.mlRemoveProduct.Name = "mlRemoveProduct";
            this.mlRemoveProduct.Size = new System.Drawing.Size(40, 40);
            this.mlRemoveProduct.TabIndex = 102;
            this.mlRemoveProduct.UseSelectable = true;
            this.mlRemoveProduct.Click += new System.EventHandler(this.mlRemoveProduct_Click);
            // 
            // mlDownProduct
            // 
            this.mlDownProduct.BackgroundImage = global::WorkstationStudioGarment_WinForm.Properties.Resources.go_down;
            this.mlDownProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mlDownProduct.Location = new System.Drawing.Point(1094, 158);
            this.mlDownProduct.Name = "mlDownProduct";
            this.mlDownProduct.Size = new System.Drawing.Size(35, 35);
            this.mlDownProduct.TabIndex = 101;
            this.mlDownProduct.UseSelectable = true;
            this.mlDownProduct.Click += new System.EventHandler(this.mlDownProduct_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 692);
            this.Controls.Add(this.mlRemoveProduct);
            this.Controls.Add(this.mlDownProduct);
            this.Controls.Add(this.mlUpProduct);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblClientLogin);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxClothesOnMannequin);
            this.Controls.Add(this.panelMannequin);
            this.Controls.Add(this.listViewProducts);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "Ателье по продаже и пошиву одежды";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panelMannequin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMannequin)).EndInit();
            this.mPanelCategoryExpand.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mPanelColorExpand.ResumeLayout(false);
            this.mPanelSizeExpand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panelMannequin;
        private System.Windows.Forms.ListBox listBoxClothesOnMannequin;
        private System.Windows.Forms.PictureBox pbMannequin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView listViewProducts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink lblClientLogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel mPanelCategoryExpand;
        private MetroFramework.Controls.MetroLink mlCategoryExpander;
        private System.Windows.Forms.CheckedListBox cListBoxCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLink mlColorExpander;
        private MetroFramework.Controls.MetroPanel mPanelColorExpand;
        private System.Windows.Forms.CheckedListBox cListBoxColors;
        private MetroFramework.Controls.MetroLink mlSizeExpander;
        private MetroFramework.Controls.MetroPanel mPanelSizeExpand;
        private System.Windows.Forms.CheckedListBox cListBoxSize;
        private MetroFramework.Controls.MetroLink mlUpProduct;
        private MetroFramework.Controls.MetroLink mlDownProduct;
        private MetroFramework.Controls.MetroLink mlRemoveProduct;
    }
}