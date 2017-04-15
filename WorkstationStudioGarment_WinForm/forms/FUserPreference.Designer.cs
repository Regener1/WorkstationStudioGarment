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
            this.panelProductsView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelProductsView
            // 
            this.panelProductsView.AutoScroll = true;
            this.panelProductsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductsView.Location = new System.Drawing.Point(0, 0);
            this.panelProductsView.Name = "panelProductsView";
            this.panelProductsView.Size = new System.Drawing.Size(714, 476);
            this.panelProductsView.TabIndex = 0;
            // 
            // FUserPreference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.panelProductsView);
            this.Name = "FUserPreference";
            this.Text = "FUserPreference";
            this.Load += new System.EventHandler(this.FUserPreference_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductsView;
    }
}