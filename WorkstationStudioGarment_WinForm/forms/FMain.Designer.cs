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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMannequin)).BeginInit();
            this.panelMannequin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientLogin
            // 
            this.lblClientLogin.AutoSize = true;
            this.lblClientLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientLogin.LinkColor = System.Drawing.Color.DarkCyan;
            this.lblClientLogin.Location = new System.Drawing.Point(745, 7);
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
            this.label1.Location = new System.Drawing.Point(695, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Привет,";
            // 
            // listViewProducts
            // 
            this.listViewProducts.LargeImageList = this.imageList;
            this.listViewProducts.Location = new System.Drawing.Point(1, 37);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(371, 537);
            this.listViewProducts.SmallImageList = this.imageList;
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList.ImageSize = new System.Drawing.Size(150, 220);
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
            this.pbMannequin.Size = new System.Drawing.Size(222, 537);
            this.pbMannequin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMannequin.TabIndex = 3;
            this.pbMannequin.TabStop = false;
            // 
            // panelMannequin
            // 
            this.panelMannequin.AllowDrop = true;
            this.panelMannequin.Controls.Add(this.pbMannequin);
            this.panelMannequin.Location = new System.Drawing.Point(462, 72);
            this.panelMannequin.Name = "panelMannequin";
            this.panelMannequin.Size = new System.Drawing.Size(222, 537);
            this.panelMannequin.TabIndex = 4;
            this.panelMannequin.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragDrop);
            this.panelMannequin.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelMannequin_DragEnter);
            // 
            // listBoxClothesOnMannequin
            // 
            this.listBoxClothesOnMannequin.FormattingEnabled = true;
            this.listBoxClothesOnMannequin.Location = new System.Drawing.Point(292, 558);
            this.listBoxClothesOnMannequin.Name = "listBoxClothesOnMannequin";
            this.listBoxClothesOnMannequin.Size = new System.Drawing.Size(194, 108);
            this.listBoxClothesOnMannequin.TabIndex = 5;
            this.listBoxClothesOnMannequin.SelectedIndexChanged += new System.EventHandler(this.listBoxClothesOnMannequin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вы добавили на манекен:";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(853, 710);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxClothesOnMannequin);
            this.Controls.Add(this.panelMannequin);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.lblClientLogin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "Ателье по продаже и пошиву одежды";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbMannequin;
    }
}