namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FAddSupply
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
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mtbDeliveryDate
            // 
            this.mtbDeliveryDate.Location = new System.Drawing.Point(125, 82);
            this.mtbDeliveryDate.Mask = "00/00/0000";
            this.mtbDeliveryDate.Name = "mtbDeliveryDate";
            this.mtbDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.mtbDeliveryDate.TabIndex = 0;
            this.mtbDeliveryDate.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Дата поставки";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(232, 135);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 49);
            this.metroPanel1.TabIndex = 96;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FAddSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 159);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtbDeliveryDate);
            this.Name = "FAddSupply";
            this.Text = "Добавить поставку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbDeliveryDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}