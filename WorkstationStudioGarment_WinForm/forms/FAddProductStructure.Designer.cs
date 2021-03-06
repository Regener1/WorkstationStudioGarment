﻿namespace WorkstationStudioGarment_WinForm.forms
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
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lvProductStucture = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnAddToList = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(23, 74);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(140, 21);
            this.cbMaterial.TabIndex = 0;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(169, 75);
            this.nudCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(100, 20);
            this.nudCount.TabIndex = 5;
            // 
            // lvProductStucture
            // 
            this.lvProductStucture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProductStucture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvProductStucture.FullRowSelect = true;
            this.lvProductStucture.Location = new System.Drawing.Point(23, 101);
            this.lvProductStucture.Name = "lvProductStucture";
            this.lvProductStucture.OwnerDraw = true;
            this.lvProductStucture.Size = new System.Drawing.Size(275, 97);
            this.lvProductStucture.TabIndex = 7;
            this.lvProductStucture.UseCompatibleStateImageBehavior = false;
            this.lvProductStucture.UseSelectable = true;
            this.lvProductStucture.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Количество";
            this.columnHeader2.Width = 108;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackgroundImage = global::WorkstationStudioGarment_WinForm.Properties.Resources.button_plus_red;
            this.btnAddToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddToList.Location = new System.Drawing.Point(275, 71);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(23, 23);
            this.btnAddToList.TabIndex = 6;
            this.btnAddToList.UseSelectable = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(300, 240);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 49);
            this.metroPanel1.TabIndex = 96;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FAddProductStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 257);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvProductStucture);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.cbMaterial);
            this.Name = "FAddProductStructure";
            this.Text = "Добавить состав товара";
            this.Load += new System.EventHandler(this.FAddProductStructure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.NumericUpDown nudCount;
        private MetroFramework.Controls.MetroLink btnAddToList;
        private MetroFramework.Controls.MetroListView lvProductStucture;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}