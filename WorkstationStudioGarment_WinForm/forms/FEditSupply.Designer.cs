namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FEditSupply
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
            this.mtbDeliveryDate = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnChange = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mtbDeliveryDate
            // 
            this.mtbDeliveryDate.Location = new System.Drawing.Point(125, 69);
            this.mtbDeliveryDate.Mask = "00/00/0000";
            this.mtbDeliveryDate.Name = "mtbDeliveryDate";
            this.mtbDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.mtbDeliveryDate.TabIndex = 0;
            this.mtbDeliveryDate.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Дата поставки";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(150, 95);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseSelectable = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(233, 120);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 49);
            this.metroPanel1.TabIndex = 96;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FEditSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 141);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbDeliveryDate);
            this.Name = "FEditSupply";
            this.Text = "Изменить поставку";
            this.Load += new System.EventHandler(this.FEditSupply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbDeliveryDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnChange;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}