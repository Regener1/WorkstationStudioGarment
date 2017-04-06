namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FPersonalAreaAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageUsersManager = new System.Windows.Forms.TabPage();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.colHeadFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAccess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageProductsManager = new System.Windows.Forms.TabPage();
            this.btnMaterialEditor = new System.Windows.Forms.Button();
            this.btnAddProductStructure = new System.Windows.Forms.Button();
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadSupplies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvProductStructure = new System.Windows.Forms.ListView();
            this.colHeadMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadMaterialCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.lvSupplies = new System.Windows.Forms.ListView();
            this.colHeadId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadDeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.colHeadProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadProductCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadIdSupply = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageUsersManager.SuspendLayout();
            this.tabPageProductsManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(1477, 24);
            this.menuStripAdmin.TabIndex = 0;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageUsersManager);
            this.tabControlMain.Controls.Add(this.tabPageProductsManager);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1477, 680);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageUsersManager
            // 
            this.tabPageUsersManager.Controls.Add(this.button1);
            this.tabPageUsersManager.Controls.Add(this.listViewUsers);
            this.tabPageUsersManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsersManager.Name = "tabPageUsersManager";
            this.tabPageUsersManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsersManager.Size = new System.Drawing.Size(1469, 654);
            this.tabPageUsersManager.TabIndex = 0;
            this.tabPageUsersManager.Text = "Users manager";
            this.tabPageUsersManager.UseVisualStyleBackColor = true;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadFIO,
            this.colHeadLogin,
            this.colHeadAccess});
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewUsers.Location = new System.Drawing.Point(3, 3);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(238, 648);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.List;
            // 
            // colHeadFIO
            // 
            this.colHeadFIO.Text = "ФИО";
            // 
            // colHeadLogin
            // 
            this.colHeadLogin.Text = "Логин";
            // 
            // colHeadAccess
            // 
            this.colHeadAccess.Text = "Доступ";
            // 
            // tabPageProductsManager
            // 
            this.tabPageProductsManager.Controls.Add(this.btnMaterialEditor);
            this.tabPageProductsManager.Controls.Add(this.btnAddProductStructure);
            this.tabPageProductsManager.Controls.Add(this.btnAddSupply);
            this.tabPageProductsManager.Controls.Add(this.btnAddProduct);
            this.tabPageProductsManager.Controls.Add(this.label2);
            this.tabPageProductsManager.Controls.Add(this.btnLoadSupplies);
            this.tabPageProductsManager.Controls.Add(this.label1);
            this.tabPageProductsManager.Controls.Add(this.lvProductStructure);
            this.tabPageProductsManager.Controls.Add(this.label11);
            this.tabPageProductsManager.Controls.Add(this.lvSupplies);
            this.tabPageProductsManager.Controls.Add(this.label10);
            this.tabPageProductsManager.Controls.Add(this.pictureBoxPhoto);
            this.tabPageProductsManager.Controls.Add(this.lvProducts);
            this.tabPageProductsManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductsManager.Name = "tabPageProductsManager";
            this.tabPageProductsManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductsManager.Size = new System.Drawing.Size(1469, 654);
            this.tabPageProductsManager.TabIndex = 1;
            this.tabPageProductsManager.Text = "Products manager";
            this.tabPageProductsManager.UseVisualStyleBackColor = true;
            // 
            // btnMaterialEditor
            // 
            this.btnMaterialEditor.Location = new System.Drawing.Point(1180, 610);
            this.btnMaterialEditor.Name = "btnMaterialEditor";
            this.btnMaterialEditor.Size = new System.Drawing.Size(128, 23);
            this.btnMaterialEditor.TabIndex = 40;
            this.btnMaterialEditor.Text = "Редактор материалов";
            this.btnMaterialEditor.UseVisualStyleBackColor = true;
            this.btnMaterialEditor.Click += new System.EventHandler(this.btnMaterialEditor_Click);
            // 
            // btnAddProductStructure
            // 
            this.btnAddProductStructure.Location = new System.Drawing.Point(947, 586);
            this.btnAddProductStructure.Name = "btnAddProductStructure";
            this.btnAddProductStructure.Size = new System.Drawing.Size(145, 23);
            this.btnAddProductStructure.TabIndex = 39;
            this.btnAddProductStructure.Text = "Добавить состав товара";
            this.btnAddProductStructure.UseVisualStyleBackColor = true;
            this.btnAddProductStructure.Click += new System.EventHandler(this.btnAddProductStructure_Click);
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Location = new System.Drawing.Point(10, 586);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(118, 23);
            this.btnAddSupply.TabIndex = 38;
            this.btnAddSupply.Text = "Добавить поставку";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddSupply_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(272, 586);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 23);
            this.btnAddProduct.TabIndex = 37;
            this.btnAddProduct.Text = "Добавить продукт";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1149, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Фото";
            // 
            // btnLoadSupplies
            // 
            this.btnLoadSupplies.Location = new System.Drawing.Point(6, 6);
            this.btnLoadSupplies.Name = "btnLoadSupplies";
            this.btnLoadSupplies.Size = new System.Drawing.Size(142, 23);
            this.btnLoadSupplies.TabIndex = 35;
            this.btnLoadSupplies.Text = "Загрузить поставки";
            this.btnLoadSupplies.UseVisualStyleBackColor = true;
            this.btnLoadSupplies.Click += new System.EventHandler(this.btnLoadSupplies_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Состав товара";
            // 
            // lvProductStructure
            // 
            this.lvProductStructure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadMaterial,
            this.colHeadMaterialCount});
            this.lvProductStructure.FullRowSelect = true;
            this.lvProductStructure.Location = new System.Drawing.Point(947, 59);
            this.lvProductStructure.MultiSelect = false;
            this.lvProductStructure.Name = "lvProductStructure";
            this.lvProductStructure.Size = new System.Drawing.Size(199, 521);
            this.lvProductStructure.TabIndex = 33;
            this.lvProductStructure.UseCompatibleStateImageBehavior = false;
            this.lvProductStructure.View = System.Windows.Forms.View.Details;
            // 
            // colHeadMaterial
            // 
            this.colHeadMaterial.Text = "Материал";
            this.colHeadMaterial.Width = 77;
            // 
            // colHeadMaterialCount
            // 
            this.colHeadMaterialCount.Text = "Количество";
            this.colHeadMaterialCount.Width = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Поставки";
            // 
            // lvSupplies
            // 
            this.lvSupplies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadId,
            this.colHeadDeliveryDate});
            this.lvSupplies.FullRowSelect = true;
            this.lvSupplies.Location = new System.Drawing.Point(7, 59);
            this.lvSupplies.MultiSelect = false;
            this.lvSupplies.Name = "lvSupplies";
            this.lvSupplies.Size = new System.Drawing.Size(259, 521);
            this.lvSupplies.TabIndex = 31;
            this.lvSupplies.UseCompatibleStateImageBehavior = false;
            this.lvSupplies.View = System.Windows.Forms.View.Details;
            this.lvSupplies.SelectedIndexChanged += new System.EventHandler(this.lvSupplies_SelectedIndexChanged);
            // 
            // colHeadId
            // 
            this.colHeadId.Text = "Id";
            this.colHeadId.Width = 38;
            // 
            // colHeadDeliveryDate
            // 
            this.colHeadDeliveryDate.Text = "Дата поступления";
            this.colHeadDeliveryDate.Width = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Продукты";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(1152, 59);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(249, 338);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 1;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadProductId,
            this.colHeadName,
            this.colHeadCategory,
            this.colHeadSize,
            this.colHeadColor,
            this.colHeadPrice,
            this.colHeadProductCount,
            this.colHeadIdSupply});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.Location = new System.Drawing.Point(272, 59);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(669, 521);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            // 
            // colHeadProductId
            // 
            this.colHeadProductId.Text = "Id";
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Название";
            this.colHeadName.Width = 95;
            // 
            // colHeadCategory
            // 
            this.colHeadCategory.Text = "Категория";
            this.colHeadCategory.Width = 88;
            // 
            // colHeadSize
            // 
            this.colHeadSize.Text = "Размер";
            this.colHeadSize.Width = 76;
            // 
            // colHeadColor
            // 
            this.colHeadColor.Text = "Цвет";
            this.colHeadColor.Width = 73;
            // 
            // colHeadPrice
            // 
            this.colHeadPrice.Text = "Цена";
            this.colHeadPrice.Width = 84;
            // 
            // colHeadProductCount
            // 
            this.colHeadProductCount.Text = "Количество";
            this.colHeadProductCount.Width = 77;
            // 
            // colHeadIdSupply
            // 
            this.colHeadIdSupply.Text = "Id поставки";
            this.colHeadIdSupply.Width = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FPersonalAreaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 704);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripAdmin);
            this.MainMenuStrip = this.menuStripAdmin;
            this.Name = "FPersonalAreaAdmin";
            this.Text = "FPersonalAreaAdmin";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageUsersManager.ResumeLayout(false);
            this.tabPageProductsManager.ResumeLayout(false);
            this.tabPageProductsManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageUsersManager;
        private System.Windows.Forms.TabPage tabPageProductsManager;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader colHeadFIO;
        private System.Windows.Forms.ColumnHeader colHeadLogin;
        private System.Windows.Forms.ColumnHeader colHeadAccess;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvSupplies;
        private System.Windows.Forms.ColumnHeader colHeadId;
        private System.Windows.Forms.ColumnHeader colHeadDeliveryDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader colHeadProductId;
        private System.Windows.Forms.ColumnHeader colHeadCategory;
        private System.Windows.Forms.ColumnHeader colHeadSize;
        private System.Windows.Forms.ColumnHeader colHeadColor;
        private System.Windows.Forms.ColumnHeader colHeadPrice;
        private System.Windows.Forms.ColumnHeader colHeadIdSupply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvProductStructure;
        private System.Windows.Forms.ColumnHeader colHeadMaterial;
        private System.Windows.Forms.ColumnHeader colHeadMaterialCount;
        private System.Windows.Forms.Button btnLoadSupplies;
        private System.Windows.Forms.ColumnHeader colHeadProductCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddProductStructure;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnMaterialEditor;
        private System.Windows.Forms.Button button1;
    }
}