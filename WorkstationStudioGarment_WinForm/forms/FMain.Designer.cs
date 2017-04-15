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
            this.lblClientLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pbMannequin = new System.Windows.Forms.PictureBox();
            this.panelMannequin = new System.Windows.Forms.Panel();
            this.listBoxClothesOnMannequin = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMannequin)).BeginInit();
            this.panelMannequin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientLogin
            // 
            this.lblClientLogin.AutoSize = true;
            this.lblClientLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientLogin.LinkColor = System.Drawing.Color.DarkCyan;
            this.lblClientLogin.Location = new System.Drawing.Point(578, 9);
            this.lblClientLogin.Name = "lblClientLogin";
            this.lblClientLogin.Size = new System.Drawing.Size(96, 15);
            this.lblClientLogin.TabIndex = 0;
            this.lblClientLogin.TabStop = true;
            this.lblClientLogin.Text = "our client\'s login";
            this.lblClientLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClientLogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Привет,";
            // 
            // listViewProducts
            // 
            this.listViewProducts.LargeImageList = this.imageList;
            this.listViewProducts.Location = new System.Drawing.Point(5, 37);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(178, 537);
            this.listViewProducts.SmallImageList = this.imageList;
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList.ImageSize = new System.Drawing.Size(100, 250);
            this.imageList.TransparentColor = System.Drawing.Color.DarkGray;
            // 
            // pbMannequin
            // 
            this.pbMannequin.BackColor = System.Drawing.Color.White;
            this.pbMannequin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMannequin.ImageLocation = "";
            this.pbMannequin.InitialImage = null;
            this.pbMannequin.Location = new System.Drawing.Point(0, 0);
            this.pbMannequin.Name = "pbMannequin";
            this.pbMannequin.Size = new System.Drawing.Size(214, 537);
            this.pbMannequin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMannequin.TabIndex = 3;
            this.pbMannequin.TabStop = false;
            // 
            // panelMannequin
            // 
            this.panelMannequin.AllowDrop = true;
            this.panelMannequin.Controls.Add(this.pbMannequin);
            this.panelMannequin.Location = new System.Drawing.Point(207, 37);
            this.panelMannequin.Name = "panelMannequin";
            this.panelMannequin.Size = new System.Drawing.Size(214, 537);
            this.panelMannequin.TabIndex = 4;
            this.panelMannequin.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragDrop);
            this.panelMannequin.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragEnter);
            // 
            // listBoxClothesOnMannequin
            // 
            this.listBoxClothesOnMannequin.FormattingEnabled = true;
            this.listBoxClothesOnMannequin.Location = new System.Drawing.Point(207, 580);
            this.listBoxClothesOnMannequin.Name = "listBoxClothesOnMannequin";
            this.listBoxClothesOnMannequin.Size = new System.Drawing.Size(216, 108);
            this.listBoxClothesOnMannequin.TabIndex = 5;
            this.listBoxClothesOnMannequin.SelectedIndexChanged += new System.EventHandler(this.listBoxClothesOnMannequin_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вы добавили на манекен: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkCyan;
            this.linkLabel1.Location = new System.Drawing.Point(599, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Корзина";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(730, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxClothesOnMannequin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panelMannequin);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.lblClientLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "Ателье по продаже и пошиву одежды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMannequin)).EndInit();
            this.panelMannequin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblClientLogin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ImageList imageList;
        public System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Panel panelMannequin;
        private System.Windows.Forms.ListBox listBoxClothesOnMannequin;
        private System.Windows.Forms.PictureBox pbMannequin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}