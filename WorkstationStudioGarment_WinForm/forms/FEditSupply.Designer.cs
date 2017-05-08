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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbDeliveryDate
            // 
            this.mtbDeliveryDate.Location = new System.Drawing.Point(101, 21);
            this.mtbDeliveryDate.Mask = "00/00/0000";
            this.mtbDeliveryDate.Name = "mtbDeliveryDate";
            this.mtbDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.mtbDeliveryDate.TabIndex = 0;
            this.mtbDeliveryDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата поставки";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(126, 47);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // FEditSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 80);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbDeliveryDate);
            this.Name = "FEditSupply";
            this.Text = "FAddSupply";
            this.Load += new System.EventHandler(this.FEditSupply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbDeliveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
    }
}