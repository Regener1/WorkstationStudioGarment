namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FMaterialEditor
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
            this.btnLoadMaterials = new System.Windows.Forms.Button();
            this.lvMaterials = new System.Windows.Forms.ListView();
            this.colHeadId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadMaterials
            // 
            this.btnLoadMaterials.Location = new System.Drawing.Point(210, 310);
            this.btnLoadMaterials.Name = "btnLoadMaterials";
            this.btnLoadMaterials.Size = new System.Drawing.Size(139, 23);
            this.btnLoadMaterials.TabIndex = 0;
            this.btnLoadMaterials.Text = "Загрузить материалы";
            this.btnLoadMaterials.UseVisualStyleBackColor = true;
            this.btnLoadMaterials.Click += new System.EventHandler(this.btnLoadMaterials_Click);
            // 
            // lvMaterials
            // 
            this.lvMaterials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadId,
            this.colHeadName,
            this.colHeadCount});
            this.lvMaterials.FullRowSelect = true;
            this.lvMaterials.Location = new System.Drawing.Point(12, 35);
            this.lvMaterials.MultiSelect = false;
            this.lvMaterials.Name = "lvMaterials";
            this.lvMaterials.Size = new System.Drawing.Size(337, 269);
            this.lvMaterials.TabIndex = 1;
            this.lvMaterials.UseCompatibleStateImageBehavior = false;
            this.lvMaterials.View = System.Windows.Forms.View.Details;
            // 
            // colHeadId
            // 
            this.colHeadId.Text = "Id";
            this.colHeadId.Width = 45;
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Наименование";
            this.colHeadName.Width = 100;
            // 
            // colHeadCount
            // 
            this.colHeadCount.Text = "Количество";
            this.colHeadCount.Width = 100;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(458, 105);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(124, 23);
            this.btnAddMaterial.TabIndex = 2;
            this.btnAddMaterial.Text = "Добавить материал";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(454, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(128, 20);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(454, 79);
            this.nudCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(128, 20);
            this.nudCount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество";
            // 
            // FMaterialEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.lvMaterials);
            this.Controls.Add(this.btnLoadMaterials);
            this.Name = "FMaterialEditor";
            this.Text = "FMaterialEditor";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadMaterials;
        private System.Windows.Forms.ListView lvMaterials;
        private System.Windows.Forms.ColumnHeader colHeadId;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadCount;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label2;
    }
}