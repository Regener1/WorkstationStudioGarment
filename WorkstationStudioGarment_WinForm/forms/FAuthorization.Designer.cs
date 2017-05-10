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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.linkRegistration = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAuthorization = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.White;
            this.tbLogin.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbLogin.Location = new System.Drawing.Point(54, 123);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(245, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Tag = "";
            this.tbLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbLogin_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "________________________________________________";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(54, 165);
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
            this.lblError.Location = new System.Drawing.Point(107, 89);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(148, 15);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Неверный логин/пароль";
            this.lblError.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(318, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Для входа в систему введите свой логин и пароль";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(54, 143);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(54, 19);
            this.metroLabel13.TabIndex = 91;
            this.metroLabel13.Text = "Пароль";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(54, 101);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(47, 19);
            this.metroLabel12.TabIndex = 90;
            this.metroLabel12.Text = "Логин";
            // 
            // linkRegistration
            // 
            this.linkRegistration.Location = new System.Drawing.Point(172, 233);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(127, 23);
            this.linkRegistration.TabIndex = 92;
            this.linkRegistration.Text = "Зарегистрироваться";
            this.linkRegistration.UseSelectable = true;
            this.linkRegistration.Click += new System.EventHandler(this.linkRegistration_LinkClicked);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 233);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 93;
            this.metroLabel2.Text = "Впервые здесь?";
            // 
            // btnAuthorization
            // 
            this.btnAuthorization.Location = new System.Drawing.Point(132, 191);
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorization.TabIndex = 94;
            this.btnAuthorization.Text = "Войти";
            this.btnAuthorization.UseSelectable = true;
            this.btnAuthorization.Click += new System.EventHandler(this.bAuthorization_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(340, 253);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 49);
            this.metroPanel1.TabIndex = 95;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 287);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnAuthorization);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLogin);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "FAuthorization";
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private System.Windows.Forms.Label lblError;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLink linkRegistration;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAuthorization;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}