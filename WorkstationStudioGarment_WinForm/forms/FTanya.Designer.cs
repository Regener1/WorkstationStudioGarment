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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.blSurname = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGClient)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddClient
            // 
            this.bAddClient.Location = new System.Drawing.Point(458, 104);
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
            this.dGClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dGClient.Location = new System.Drawing.Point(12, 12);
            this.dGClient.Name = "dGClient";
            this.dGClient.ReadOnly = true;
            this.dGClient.Size = new System.Drawing.Size(431, 60);
            this.dGClient.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 239);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(115, 200);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(245, 20);
            this.tbSurname.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblName.Location = new System.Drawing.Point(115, 223);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Имя";
            // 
            // blSurname
            // 
            this.blSurname.AutoSize = true;
            this.blSurname.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.blSurname.Location = new System.Drawing.Point(115, 184);
            this.blSurname.Name = "blSurname";
            this.blSurname.Size = new System.Drawing.Size(56, 13);
            this.blSurname.TabIndex = 7;
            this.blSurname.Text = "Фамилия";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblMail.Location = new System.Drawing.Point(115, 301);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(139, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Адрес электронной почты";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPatronymic.Location = new System.Drawing.Point(115, 262);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(54, 13);
            this.lblPatronymic.TabIndex = 10;
            this.lblPatronymic.Text = "Отчество";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(115, 317);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(245, 20);
            this.tbMail.TabIndex = 9;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(115, 278);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(245, 20);
            this.tbPatronymic.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(186, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Адрес электронной почты";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPhone.Location = new System.Drawing.Point(115, 341);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Телефон";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 502);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 20);
            this.textBox2.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPassword.Location = new System.Drawing.Point(115, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblLogin.Location = new System.Drawing.Point(115, 106);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Логин";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(115, 161);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(245, 20);
            this.tbPassword.TabIndex = 17;
            // 
            // tbLogin
            // 
            this.tbLogin.ForeColor = System.Drawing.Color.Lime;
            this.tbLogin.Location = new System.Drawing.Point(115, 122);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(245, 20);
            this.tbLogin.TabIndex = 16;
            // 
            // FTanya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 552);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.blSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.dGClient);
            this.Name = "FTanya";
            this.Text = "FTanya";
            ((System.ComponentModel.ISupportInitialize)(this.dGClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.DataGridView dGClient;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label blSurname;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
    }
}