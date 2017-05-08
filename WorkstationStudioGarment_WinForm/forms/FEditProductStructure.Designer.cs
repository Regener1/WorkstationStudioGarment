namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FEditProductStructure
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
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lvProductStucture = new System.Windows.Forms.ListView();
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChange = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveFromList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(12, 12);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cbMaterial.TabIndex = 0;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(245, 12);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(42, 23);
            this.btnAddToList.TabIndex = 2;
            this.btnAddToList.Text = "+";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // lvProductStucture
            // 
            this.lvProductStucture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadName,
            this.colHeadCount});
            this.lvProductStucture.FullRowSelect = true;
            this.lvProductStucture.Location = new System.Drawing.Point(12, 41);
            this.lvProductStucture.MultiSelect = false;
            this.lvProductStucture.Name = "lvProductStucture";
            this.lvProductStucture.Size = new System.Drawing.Size(321, 97);
            this.lvProductStucture.TabIndex = 3;
            this.lvProductStucture.UseCompatibleStateImageBehavior = false;
            this.lvProductStucture.View = System.Windows.Forms.View.Details;
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Наименование";
            this.colHeadName.Width = 95;
            // 
            // colHeadCount
            // 
            this.colHeadCount.Text = "Количество";
            this.colHeadCount.Width = 75;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(245, 149);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(88, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(139, 12);
            this.nudCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(100, 20);
            this.nudCount.TabIndex = 5;
            // 
            // btnRemoveFromList
            // 
            this.btnRemoveFromList.Location = new System.Drawing.Point(293, 12);
            this.btnRemoveFromList.Name = "btnRemoveFromList";
            this.btnRemoveFromList.Size = new System.Drawing.Size(40, 23);
            this.btnRemoveFromList.TabIndex = 6;
            this.btnRemoveFromList.Text = "-";
            this.btnRemoveFromList.UseVisualStyleBackColor = true;
            this.btnRemoveFromList.Click += new System.EventHandler(this.btnRemoveFromList_Click);
            // 
            // FEditProductStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 187);
            this.Controls.Add(this.btnRemoveFromList);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lvProductStucture);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.cbMaterial);
            this.Name = "FEditProductStructure";
            this.Text = "FAddProductStructure";
            this.Load += new System.EventHandler(this.FEditProductStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ListView lvProductStucture;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadCount;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Button btnRemoveFromList;
    }
}