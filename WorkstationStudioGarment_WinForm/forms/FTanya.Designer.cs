namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FTanya
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
            this.bAddClient = new System.Windows.Forms.Button();
            this.dGClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGClient)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(370, 21);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(187, 28);
            this.bAddClient.TabIndex = 3;
            this.bAddClient.Text = "bAddClient";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // dGClient
            // 
            this.dGClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGClient.Location = new System.Drawing.Point(126, 55);
            this.dGClient.Name = "dGClient";
            this.dGClient.Size = new System.Drawing.Size(431, 300);
            this.dGClient.TabIndex = 2;
            // 
            // FTanya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 460);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.dGClient);
            this.Name = "FTanya";
            this.Text = "FTanya";
            ((System.ComponentModel.ISupportInitialize)(this.dGClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.DataGridView dGClient;
    }
}