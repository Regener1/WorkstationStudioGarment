namespace WorkstationStudioGarment_WinForm.user_controls
{
    partial class UserControlBasket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBasket));
            this.pb = new System.Windows.Forms.PictureBox();
            this.nUDCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new MetroFramework.Controls.MetroTextBox();
            this.btnRemove = new MetroFramework.Controls.MetroLink();
            this.tbInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pb, "pb");
            this.pb.Name = "pb";
            this.pb.TabStop = false;
            // 
            // nUDCount
            // 
            this.nUDCount.BackColor = System.Drawing.Color.White;
            this.nUDCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.nUDCount, "nUDCount");
            this.nUDCount.Name = "nUDCount";
            this.nUDCount.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbTotal
            // 
            // 
            // 
            // 
            this.tbTotal.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tbTotal.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.tbTotal.CustomButton.Name = "";
            this.tbTotal.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.tbTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTotal.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.tbTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTotal.CustomButton.UseSelectable = true;
            this.tbTotal.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.tbTotal.Lines = new string[0];
            resources.ApplyResources(this.tbTotal, "tbTotal");
            this.tbTotal.MaxLength = 32767;
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTotal.SelectedText = "";
            this.tbTotal.SelectionLength = 0;
            this.tbTotal.SelectionStart = 0;
            this.tbTotal.ShortcutsEnabled = true;
            this.tbTotal.UseSelectable = true;
            this.tbTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::WorkstationStudioGarment_WinForm.Properties.Resources.cross;
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseSelectable = true;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.White;
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbInfo, "tbInfo");
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            // 
            // UserControlBasket
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDCount);
            this.Controls.Add(this.pb);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "UserControlBasket";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pb;
        public System.Windows.Forms.NumericUpDown nUDCount;
        public MetroFramework.Controls.MetroTextBox tbTotal;
        public MetroFramework.Controls.MetroLink btnRemove;
        public System.Windows.Forms.TextBox tbInfo;
    }
}
