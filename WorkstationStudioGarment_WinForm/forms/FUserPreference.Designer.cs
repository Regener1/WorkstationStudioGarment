namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FUserPreference
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
            this.flpProductsView = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbPriceBegin = new System.Windows.Forms.TextBox();
            this.tbPriceEnd = new System.Windows.Forms.TextBox();
            this.checkedLBNames = new System.Windows.Forms.CheckedListBox();
            this.checkedLBCategories = new System.Windows.Forms.CheckedListBox();
            this.checkedLBColors = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProductsView
            // 
            this.flpProductsView.AutoScroll = true;
            this.flpProductsView.Location = new System.Drawing.Point(0, 28);
            this.flpProductsView.Name = "flpProductsView";
            this.flpProductsView.Size = new System.Drawing.Size(729, 448);
            this.flpProductsView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedLBColors);
            this.panel1.Controls.Add(this.checkedLBCategories);
            this.panel1.Controls.Add(this.checkedLBNames);
            this.panel1.Controls.Add(this.tbPriceEnd);
            this.panel1.Controls.Add(this.tbPriceBegin);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(735, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 448);
            this.panel1.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(133, 413);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Сформировать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbPriceBegin
            // 
            this.tbPriceBegin.Location = new System.Drawing.Point(24, 52);
            this.tbPriceBegin.Name = "tbPriceBegin";
            this.tbPriceBegin.Size = new System.Drawing.Size(80, 20);
            this.tbPriceBegin.TabIndex = 1;
            // 
            // tbPriceEnd
            // 
            this.tbPriceEnd.Location = new System.Drawing.Point(110, 52);
            this.tbPriceEnd.Name = "tbPriceEnd";
            this.tbPriceEnd.Size = new System.Drawing.Size(80, 20);
            this.tbPriceEnd.TabIndex = 2;
            // 
            // checkedLBNames
            // 
            this.checkedLBNames.FormattingEnabled = true;
            this.checkedLBNames.Location = new System.Drawing.Point(24, 92);
            this.checkedLBNames.Name = "checkedLBNames";
            this.checkedLBNames.Size = new System.Drawing.Size(166, 79);
            this.checkedLBNames.TabIndex = 3;
            this.checkedLBNames.SelectedValueChanged += new System.EventHandler(this.checkedLBNames_SelectedValueChanged);
            // 
            // checkedLBCategories
            // 
            this.checkedLBCategories.FormattingEnabled = true;
            this.checkedLBCategories.Location = new System.Drawing.Point(24, 192);
            this.checkedLBCategories.Name = "checkedLBCategories";
            this.checkedLBCategories.Size = new System.Drawing.Size(166, 79);
            this.checkedLBCategories.TabIndex = 4;
            this.checkedLBCategories.SelectedValueChanged += new System.EventHandler(this.checkedLBNames_SelectedValueChanged);
            // 
            // checkedLBColors
            // 
            this.checkedLBColors.FormattingEnabled = true;
            this.checkedLBColors.Location = new System.Drawing.Point(24, 290);
            this.checkedLBColors.Name = "checkedLBColors";
            this.checkedLBColors.Size = new System.Drawing.Size(166, 79);
            this.checkedLBColors.TabIndex = 5;
            this.checkedLBColors.SelectedValueChanged += new System.EventHandler(this.checkedLBNames_SelectedValueChanged);
            // 
            // FUserPreference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flpProductsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "FUserPreference";
            this.Text = "FUserPreference";
            this.Load += new System.EventHandler(this.FUserPreference_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductsView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbPriceEnd;
        private System.Windows.Forms.TextBox tbPriceBegin;
        private System.Windows.Forms.CheckedListBox checkedLBColors;
        private System.Windows.Forms.CheckedListBox checkedLBCategories;
        private System.Windows.Forms.CheckedListBox checkedLBNames;
    }
}