namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FAddProductStructure
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
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
            this.lvProductStucture.Name = "lvProductStucture";
            this.lvProductStucture.Size = new System.Drawing.Size(275, 97);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // FAddProductStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 187);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvProductStucture);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.cbMaterial);
            this.Name = "FAddProductStructure";
            this.Text = "FAddProductStructure";
            this.Load += new System.EventHandler(this.FAddProductStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ListView lvProductStucture;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudCount;
    }
}