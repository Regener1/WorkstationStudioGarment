namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FPersonalAreaUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.blSurname = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGrowth = new System.Windows.Forms.TextBox();
            this.tbWaist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChest = new System.Windows.Forms.TextBox();
            this.tbHip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblCountProducts = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 486);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.btnDeleteUser);
            this.tabPage1.Controls.Add(this.btnEditClient);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки профиля";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(269, 402);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(164, 33);
            this.btnDeleteUser.TabIndex = 64;
            this.btnDeleteUser.Text = "Удалить аккаунт";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(269, 363);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(164, 33);
            this.btnEditClient.TabIndex = 63;
            this.btnEditClient.Text = "Редактировать данные";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPassword);
            this.groupBox3.Controls.Add(this.lblPassword);
            this.groupBox3.Location = new System.Drawing.Point(221, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 67);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки безопасности";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(6, 36);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(245, 21);
            this.tbPassword.TabIndex = 49;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPassword.Location = new System.Drawing.Point(6, 20);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 15);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.Text = "Пароль";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSurname);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.blSurname);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.tbPatronymic);
            this.groupBox2.Controls.Add(this.lblPatronymic);
            this.groupBox2.Controls.Add(this.tbMail);
            this.groupBox2.Location = new System.Drawing.Point(56, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 225);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Личная информация";
            // 
            // tbSurname
            // 
            this.tbSurname.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbSurname.Location = new System.Drawing.Point(6, 37);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(245, 21);
            this.tbSurname.TabIndex = 51;
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbName.Location = new System.Drawing.Point(6, 76);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 21);
            this.tbName.TabIndex = 50;
            // 
            // tbPhone
            // 
            this.tbPhone.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbPhone.Location = new System.Drawing.Point(6, 194);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(245, 21);
            this.tbPhone.TabIndex = 58;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblName.Location = new System.Drawing.Point(6, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 15);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Имя";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPhone.Location = new System.Drawing.Point(6, 178);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 15);
            this.lblPhone.TabIndex = 59;
            this.lblPhone.Text = "Телефон";
            // 
            // blSurname
            // 
            this.blSurname.AutoSize = true;
            this.blSurname.ForeColor = System.Drawing.Color.DarkCyan;
            this.blSurname.Location = new System.Drawing.Point(6, 21);
            this.blSurname.Name = "blSurname";
            this.blSurname.Size = new System.Drawing.Size(62, 15);
            this.blSurname.TabIndex = 53;
            this.blSurname.Text = "Фамилия";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMail.Location = new System.Drawing.Point(6, 138);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(158, 15);
            this.lblMail.TabIndex = 57;
            this.lblMail.Text = "Адрес электронной почты";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbPatronymic.Location = new System.Drawing.Point(6, 115);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(245, 21);
            this.tbPatronymic.TabIndex = 54;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPatronymic.Location = new System.Drawing.Point(6, 99);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(63, 15);
            this.lblPatronymic.TabIndex = 56;
            this.lblPatronymic.Text = "Отчество";
            // 
            // tbMail
            // 
            this.tbMail.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbMail.Location = new System.Drawing.Point(6, 154);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(245, 21);
            this.tbMail.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGrowth);
            this.groupBox1.Controls.Add(this.tbWaist);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbChest);
            this.groupBox1.Controls.Add(this.tbHip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(367, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 184);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // tbGrowth
            // 
            this.tbGrowth.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbGrowth.Location = new System.Drawing.Point(6, 37);
            this.tbGrowth.Name = "tbGrowth";
            this.tbGrowth.Size = new System.Drawing.Size(245, 21);
            this.tbGrowth.TabIndex = 40;
            // 
            // tbWaist
            // 
            this.tbWaist.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbWaist.Location = new System.Drawing.Point(6, 115);
            this.tbWaist.Name = "tbWaist";
            this.tbWaist.Size = new System.Drawing.Size(245, 21);
            this.tbWaist.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Объём груди";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Объём талии";
            // 
            // tbChest
            // 
            this.tbChest.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbChest.Location = new System.Drawing.Point(6, 76);
            this.tbChest.Name = "tbChest";
            this.tbChest.Size = new System.Drawing.Size(245, 21);
            this.tbChest.TabIndex = 42;
            // 
            // tbHip
            // 
            this.tbHip.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbHip.Location = new System.Drawing.Point(6, 154);
            this.tbHip.Name = "tbHip";
            this.tbHip.Size = new System.Drawing.Size(245, 21);
            this.tbHip.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Рост";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Объём бёдер";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.panelProduct);
            this.tabPage2.Controls.Add(this.btnMain);
            this.tabPage2.Controls.Add(this.lblCountProducts);
            this.tabPage2.Controls.Add(this.lblInfo);
            this.tabPage2.Controls.Add(this.btnCreateOrder);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Корзина";
            // 
            // panelProduct
            // 
            this.panelProduct.AutoScroll = true;
            this.panelProduct.BackColor = System.Drawing.Color.Lavender;
            this.panelProduct.Location = new System.Drawing.Point(0, 41);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(665, 367);
            this.panelProduct.TabIndex = 5;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(497, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(167, 39);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Перейти к выбору товара";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Visible = false;
            this.btnMain.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCountProducts
            // 
            this.lblCountProducts.AutoSize = true;
            this.lblCountProducts.Location = new System.Drawing.Point(6, 14);
            this.lblCountProducts.Name = "lblCountProducts";
            this.lblCountProducts.Size = new System.Drawing.Size(125, 15);
            this.lblCountProducts.TabIndex = 3;
            this.lblCountProducts.Text = "Товаров в корзине : ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(201, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(280, 15);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Ваша корзина пуста. Начните покупать сейчас!";
            this.lblInfo.Visible = false;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(488, 414);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(167, 39);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Сделать заказ";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Lavender;
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(667, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            // 
            // FPersonalAreaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(675, 486);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "FPersonalAreaUser";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.FPersonalAreaUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbGrowth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHip;
        private System.Windows.Forms.TextBox tbChest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWaist;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label blSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblCountProducts;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Panel panelProduct;
    }
}