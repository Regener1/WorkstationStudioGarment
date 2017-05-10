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
            this.pbMannequin = new System.Windows.Forms.PictureBox();
            this.panelMannequin = new System.Windows.Forms.Panel();
            this.listBoxClothesOnMannequin = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblClientLogin = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMannequin)).BeginInit();
            this.panelMannequin.SuspendLayout();
            this.SuspendLayout();
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
            this.panelMannequin.Location = new System.Drawing.Point(698, 92);
            this.panelMannequin.Name = "panelMannequin";
            this.panelMannequin.Size = new System.Drawing.Size(214, 537);
            this.panelMannequin.TabIndex = 4;
            this.panelMannequin.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragDrop);
            this.panelMannequin.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragEnter);
            // 
            // listBoxClothesOnMannequin
            // 
            this.listBoxClothesOnMannequin.FormattingEnabled = true;
            this.listBoxClothesOnMannequin.Location = new System.Drawing.Point(698, 653);
            this.listBoxClothesOnMannequin.Name = "listBoxClothesOnMannequin";
            this.listBoxClothesOnMannequin.Size = new System.Drawing.Size(216, 69);
            this.listBoxClothesOnMannequin.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "FTanya";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.LargeImageList = this.imageList;
            this.listViewProducts.Location = new System.Drawing.Point(210, 92);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(482, 537);
            this.listViewProducts.SmallImageList = this.imageList;
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(711, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Здравствуйте,";
            // 
            // lblClientLogin
            // 
            this.lblClientLogin.Location = new System.Drawing.Point(800, 63);
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
            this.metroLabel2.Location = new System.Drawing.Point(698, 636);
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
            this.metroPanel1.Location = new System.Drawing.Point(911, 723);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 49);
            this.metroPanel1.TabIndex = 96;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 745);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMannequin)).EndInit();
            this.panelMannequin.ResumeLayout(false);
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
    }
}