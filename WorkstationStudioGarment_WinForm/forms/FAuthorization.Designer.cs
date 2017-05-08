namespace WorkstationStudioGarment_WinForm.forms
{
    partial class FAuthorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.bAuthorization = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для входа в систему  введите свой логин и пароль";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPassword.Location = new System.Drawing.Point(89, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblLogin.Location = new System.Drawing.Point(89, 59);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 22;
            this.lblLogin.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.White;
            this.tbLogin.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbLogin.Location = new System.Drawing.Point(89, 75);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(245, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Tag = "";
            this.tbLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbLogin_MouseDown);
            // 
            // bAuthorization
            // 
            this.bAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bAuthorization.Location = new System.Drawing.Point(154, 143);
            this.bAuthorization.Name = "bAuthorization";
            this.bAuthorization.Size = new System.Drawing.Size(106, 22);
            this.bAuthorization.TabIndex = 3;
            this.bAuthorization.Text = "Войти";
            this.bAuthorization.UseVisualStyleBackColor = true;
            this.bAuthorization.Click += new System.EventHandler(this.bAuthorization_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(86, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Впервые здесь?";
            // 
            // linkRegistration
            // 
            this.linkRegistration.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.DisabledLinkColor = System.Drawing.Color.DarkCyan;
            this.linkRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkRegistration.ForeColor = System.Drawing.Color.DarkCyan;
            this.linkRegistration.LinkColor = System.Drawing.Color.DarkCyan;
            this.linkRegistration.Location = new System.Drawing.Point(207, 185);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(144, 17);
            this.linkRegistration.TabIndex = 5;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Зарегистрироваться";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "________________________________________________";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(89, 117);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(245, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseDown);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(142, 41);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(148, 15);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Неверный логин/пароль";
            this.lblError.Visible = false;
            // 
            // FAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(418, 219);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bAuthorization);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "FAuthorization";
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button bAuthorization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private System.Windows.Forms.Label lblError;
    }
}