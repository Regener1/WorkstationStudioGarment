namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FSemanticNetProducts
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
            this.panelGraph = new System.Windows.Forms.Panel();
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.checkedLBMaterials = new System.Windows.Forms.CheckedListBox();
            this.checkedLBProducts = new System.Windows.Forms.CheckedListBox();
            this.cbAdditionalInfo = new System.Windows.Forms.CheckBox();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.pbGraph);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGraph.Location = new System.Drawing.Point(0, 0);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(943, 657);
            this.panelGraph.TabIndex = 0;
            // 
            // pbGraph
            // 
            this.pbGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGraph.Location = new System.Drawing.Point(0, 0);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(943, 657);
            this.pbGraph.TabIndex = 0;
            this.pbGraph.TabStop = false;
            this.pbGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGraph_MouseDown);
            this.pbGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGraph_MouseMove);
            this.pbGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbGraph_MouseUp);
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.cbAdditionalInfo);
            this.panelTools.Controls.Add(this.checkedLBMaterials);
            this.panelTools.Controls.Add(this.checkedLBProducts);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTools.Location = new System.Drawing.Point(949, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(198, 657);
            this.panelTools.TabIndex = 1;
            // 
            // checkedLBMaterials
            // 
            this.checkedLBMaterials.CheckOnClick = true;
            this.checkedLBMaterials.FormattingEnabled = true;
            this.checkedLBMaterials.Location = new System.Drawing.Point(0, 230);
            this.checkedLBMaterials.Name = "checkedLBMaterials";
            this.checkedLBMaterials.Size = new System.Drawing.Size(192, 154);
            this.checkedLBMaterials.TabIndex = 1;
            this.checkedLBMaterials.SelectedIndexChanged += new System.EventHandler(this.checkedLBMaterials_SelectedIndexChanged);
            // 
            // checkedLBProducts
            // 
            this.checkedLBProducts.CheckOnClick = true;
            this.checkedLBProducts.FormattingEnabled = true;
            this.checkedLBProducts.Location = new System.Drawing.Point(0, 70);
            this.checkedLBProducts.Name = "checkedLBProducts";
            this.checkedLBProducts.Size = new System.Drawing.Size(192, 154);
            this.checkedLBProducts.TabIndex = 0;
            this.checkedLBProducts.SelectedIndexChanged += new System.EventHandler(this.checkedLBProducts_SelectedIndexChanged);
            // 
            // cbAdditionalInfo
            // 
            this.cbAdditionalInfo.AutoSize = true;
            this.cbAdditionalInfo.Location = new System.Drawing.Point(3, 47);
            this.cbAdditionalInfo.Name = "cbAdditionalInfo";
            this.cbAdditionalInfo.Size = new System.Drawing.Size(179, 17);
            this.cbAdditionalInfo.TabIndex = 2;
            this.cbAdditionalInfo.Text = "Дополнительная информация";
            this.cbAdditionalInfo.UseVisualStyleBackColor = true;
            this.cbAdditionalInfo.CheckedChanged += new System.EventHandler(this.cbAdditionalInfo_CheckedChanged);
            // 
            // FSemanticNetProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 657);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panelGraph);
            this.DoubleBuffered = true;
            this.Name = "FSemanticNetProducts";
            this.Text = "FSemanticNetProducts";
            this.Load += new System.EventHandler(this.FSemanticNetProducts_Load);
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.CheckedListBox checkedLBMaterials;
        private System.Windows.Forms.CheckedListBox checkedLBProducts;
        private System.Windows.Forms.CheckBox cbAdditionalInfo;
    }
}