namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FAddProduct
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
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnLoadPhoto = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(126, 224);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(192, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(126, 198);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(192, 20);
            this.tbColor.TabIndex = 5;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(126, 172);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(192, 20);
            this.tbSize.TabIndex = 4;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(126, 146);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(192, 20);
            this.tbCategory.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 120);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(192, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(370, 333);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(156, 23);
            this.tbPath.TabIndex = 26;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(324, 63);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(283, 264);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 24;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(126, 250);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(192, 20);
            this.tbCount.TabIndex = 27;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Наименование";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Категория";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 173);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Размер";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 199);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Цвет";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 225);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Цена";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 251);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 19);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Количество";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(329, 337);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Путь";
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Location = new System.Drawing.Point(532, 333);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPhoto.TabIndex = 38;
            this.btnLoadPhoto.Text = "Загрузить";
            this.btnLoadPhoto.UseSelectable = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(532, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(585, 420);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 49);
            this.metroPanel1.TabIndex = 96;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 437);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbSize);
            this.Name = "FAddProduct";
            this.Text = "Добавить товар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.TextBox tbCount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnLoadPhoto;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}