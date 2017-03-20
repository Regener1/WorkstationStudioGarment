namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FMain
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
            this.lblClientLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClientLogin
            // 
            this.lblClientLogin.AutoSize = true;
            this.lblClientLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientLogin.LinkColor = System.Drawing.Color.DarkCyan;
            this.lblClientLogin.Location = new System.Drawing.Point(604, 7);
            this.lblClientLogin.Name = "lblClientLogin";
            this.lblClientLogin.Size = new System.Drawing.Size(96, 15);
            this.lblClientLogin.TabIndex = 0;
            this.lblClientLogin.TabStop = true;
            this.lblClientLogin.Text = "our client\'s login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(554, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Привет,";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.lblClientLogin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "FMain";
            this.Text = "Ателье по продаже и пошиву одежды";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblClientLogin;
        private System.Windows.Forms.Label label1;
    }
}