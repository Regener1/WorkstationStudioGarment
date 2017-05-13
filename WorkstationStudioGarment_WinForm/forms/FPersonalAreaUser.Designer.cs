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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblMail = new MetroFramework.Controls.MetroLabel();
            this.lblPatronymic = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.blSurname = new MetroFramework.Controls.MetroLabel();
            this.tbPhone = new MetroFramework.Controls.MetroTextBox();
            this.tbMail = new MetroFramework.Controls.MetroTextBox();
            this.tbPatronymic = new MetroFramework.Controls.MetroTextBox();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.tbSurname = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbHip = new MetroFramework.Controls.MetroTextBox();
            this.tbWaist = new MetroFramework.Controls.MetroTextBox();
            this.tbChest = new MetroFramework.Controls.MetroTextBox();
            this.tbGrowth = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnEditClient = new MetroFramework.Controls.MetroButton();
            this.btnDeleteUser = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMain = new MetroFramework.Controls.MetroButton();
            this.lblCountProducts = new MetroFramework.Controls.MetroLabel();
            this.btnCreateOrder = new MetroFramework.Controls.MetroButton();
            this.tabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.mGridClientOrders = new MetroFramework.Controls.MetroGrid();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridClientOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(188, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(298, 19);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Ваша корзина пуста. Начните покупать сейчас!";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblPassword);
            this.groupBox3.Controls.Add(this.tbPassword);
            this.groupBox3.Location = new System.Drawing.Point(198, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 67);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки безопасности";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 16);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 19);
            this.lblPassword.TabIndex = 50;
            this.lblPassword.Text = "Пароль";
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(6, 38);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(251, 23);
            this.tbPassword.TabIndex = 49;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.lblPatronymic);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.blSurname);
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.tbMail);
            this.groupBox2.Controls.Add(this.tbPatronymic);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.tbSurname);
            this.groupBox2.Location = new System.Drawing.Point(39, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 266);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Личная информация";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 213);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 19);
            this.lblPhone.TabIndex = 76;
            this.lblPhone.Text = "Телефон";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 165);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 19);
            this.lblMail.TabIndex = 75;
            this.lblMail.Text = "E-mail";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(6, 117);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(65, 19);
            this.lblPatronymic.TabIndex = 74;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 19);
            this.lblName.TabIndex = 73;
            this.lblName.Text = "Имя";
            // 
            // blSurname
            // 
            this.blSurname.AutoSize = true;
            this.blSurname.Location = new System.Drawing.Point(6, 21);
            this.blSurname.Name = "blSurname";
            this.blSurname.Size = new System.Drawing.Size(65, 19);
            this.blSurname.TabIndex = 72;
            this.blSurname.Text = "Фамилия";
            // 
            // tbPhone
            // 
            // 
            // 
            // 
            this.tbPhone.CustomButton.Image = null;
            this.tbPhone.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbPhone.CustomButton.Name = "";
            this.tbPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPhone.CustomButton.TabIndex = 1;
            this.tbPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPhone.CustomButton.UseSelectable = true;
            this.tbPhone.CustomButton.Visible = false;
            this.tbPhone.Lines = new string[0];
            this.tbPhone.Location = new System.Drawing.Point(6, 235);
            this.tbPhone.MaxLength = 32767;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPhone.SelectedText = "";
            this.tbPhone.SelectionLength = 0;
            this.tbPhone.SelectionStart = 0;
            this.tbPhone.ShortcutsEnabled = true;
            this.tbPhone.Size = new System.Drawing.Size(245, 23);
            this.tbPhone.TabIndex = 71;
            this.tbPhone.UseSelectable = true;
            this.tbPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMail
            // 
            // 
            // 
            // 
            this.tbMail.CustomButton.Image = null;
            this.tbMail.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbMail.CustomButton.Name = "";
            this.tbMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMail.CustomButton.TabIndex = 1;
            this.tbMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMail.CustomButton.UseSelectable = true;
            this.tbMail.CustomButton.Visible = false;
            this.tbMail.Lines = new string[0];
            this.tbMail.Location = new System.Drawing.Point(6, 187);
            this.tbMail.MaxLength = 32767;
            this.tbMail.Name = "tbMail";
            this.tbMail.PasswordChar = '\0';
            this.tbMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMail.SelectedText = "";
            this.tbMail.SelectionLength = 0;
            this.tbMail.SelectionStart = 0;
            this.tbMail.ShortcutsEnabled = true;
            this.tbMail.Size = new System.Drawing.Size(245, 23);
            this.tbMail.TabIndex = 70;
            this.tbMail.UseSelectable = true;
            this.tbMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPatronymic
            // 
            // 
            // 
            // 
            this.tbPatronymic.CustomButton.Image = null;
            this.tbPatronymic.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbPatronymic.CustomButton.Name = "";
            this.tbPatronymic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPatronymic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPatronymic.CustomButton.TabIndex = 1;
            this.tbPatronymic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPatronymic.CustomButton.UseSelectable = true;
            this.tbPatronymic.CustomButton.Visible = false;
            this.tbPatronymic.Lines = new string[0];
            this.tbPatronymic.Location = new System.Drawing.Point(6, 139);
            this.tbPatronymic.MaxLength = 32767;
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.PasswordChar = '\0';
            this.tbPatronymic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPatronymic.SelectedText = "";
            this.tbPatronymic.SelectionLength = 0;
            this.tbPatronymic.SelectionStart = 0;
            this.tbPatronymic.ShortcutsEnabled = true;
            this.tbPatronymic.Size = new System.Drawing.Size(245, 23);
            this.tbPatronymic.TabIndex = 69;
            this.tbPatronymic.UseSelectable = true;
            this.tbPatronymic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPatronymic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(6, 91);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(245, 23);
            this.tbName.TabIndex = 68;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbSurname
            // 
            // 
            // 
            // 
            this.tbSurname.CustomButton.Image = null;
            this.tbSurname.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbSurname.CustomButton.Name = "";
            this.tbSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSurname.CustomButton.TabIndex = 1;
            this.tbSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSurname.CustomButton.UseSelectable = true;
            this.tbSurname.CustomButton.Visible = false;
            this.tbSurname.Lines = new string[0];
            this.tbSurname.Location = new System.Drawing.Point(6, 43);
            this.tbSurname.MaxLength = 32767;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.PasswordChar = '\0';
            this.tbSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSurname.SelectedText = "";
            this.tbSurname.SelectionLength = 0;
            this.tbSurname.SelectionStart = 0;
            this.tbSurname.ShortcutsEnabled = true;
            this.tbSurname.Size = new System.Drawing.Size(245, 23);
            this.tbSurname.TabIndex = 67;
            this.tbSurname.UseSelectable = true;
            this.tbSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tbHip);
            this.groupBox1.Controls.Add(this.tbWaist);
            this.groupBox1.Controls.Add(this.tbChest);
            this.groupBox1.Controls.Add(this.tbGrowth);
            this.groupBox1.Location = new System.Drawing.Point(365, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 219);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 74;
            this.metroLabel4.Text = "Обхват бедер";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 73;
            this.metroLabel3.Text = "Обхват талии";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 72;
            this.metroLabel2.Text = "Обхват груди";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 71;
            this.metroLabel1.Text = "Рост";
            // 
            // tbHip
            // 
            // 
            // 
            // 
            this.tbHip.CustomButton.Image = null;
            this.tbHip.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbHip.CustomButton.Name = "";
            this.tbHip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbHip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbHip.CustomButton.TabIndex = 1;
            this.tbHip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbHip.CustomButton.UseSelectable = true;
            this.tbHip.CustomButton.Visible = false;
            this.tbHip.Lines = new string[0];
            this.tbHip.Location = new System.Drawing.Point(6, 187);
            this.tbHip.MaxLength = 32767;
            this.tbHip.Name = "tbHip";
            this.tbHip.PasswordChar = '\0';
            this.tbHip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbHip.SelectedText = "";
            this.tbHip.SelectionLength = 0;
            this.tbHip.SelectionStart = 0;
            this.tbHip.ShortcutsEnabled = true;
            this.tbHip.Size = new System.Drawing.Size(245, 23);
            this.tbHip.TabIndex = 70;
            this.tbHip.UseSelectable = true;
            this.tbHip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbHip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbWaist
            // 
            // 
            // 
            // 
            this.tbWaist.CustomButton.Image = null;
            this.tbWaist.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbWaist.CustomButton.Name = "";
            this.tbWaist.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbWaist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbWaist.CustomButton.TabIndex = 1;
            this.tbWaist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbWaist.CustomButton.UseSelectable = true;
            this.tbWaist.CustomButton.Visible = false;
            this.tbWaist.Lines = new string[0];
            this.tbWaist.Location = new System.Drawing.Point(5, 139);
            this.tbWaist.MaxLength = 32767;
            this.tbWaist.Name = "tbWaist";
            this.tbWaist.PasswordChar = '\0';
            this.tbWaist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbWaist.SelectedText = "";
            this.tbWaist.SelectionLength = 0;
            this.tbWaist.SelectionStart = 0;
            this.tbWaist.ShortcutsEnabled = true;
            this.tbWaist.Size = new System.Drawing.Size(245, 23);
            this.tbWaist.TabIndex = 69;
            this.tbWaist.UseSelectable = true;
            this.tbWaist.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbWaist.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbChest
            // 
            // 
            // 
            // 
            this.tbChest.CustomButton.Image = null;
            this.tbChest.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbChest.CustomButton.Name = "";
            this.tbChest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbChest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbChest.CustomButton.TabIndex = 1;
            this.tbChest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbChest.CustomButton.UseSelectable = true;
            this.tbChest.CustomButton.Visible = false;
            this.tbChest.Lines = new string[0];
            this.tbChest.Location = new System.Drawing.Point(6, 91);
            this.tbChest.MaxLength = 32767;
            this.tbChest.Name = "tbChest";
            this.tbChest.PasswordChar = '\0';
            this.tbChest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbChest.SelectedText = "";
            this.tbChest.SelectionLength = 0;
            this.tbChest.SelectionStart = 0;
            this.tbChest.ShortcutsEnabled = true;
            this.tbChest.Size = new System.Drawing.Size(245, 23);
            this.tbChest.TabIndex = 68;
            this.tbChest.UseSelectable = true;
            this.tbChest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbChest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbGrowth
            // 
            // 
            // 
            // 
            this.tbGrowth.CustomButton.Image = null;
            this.tbGrowth.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.tbGrowth.CustomButton.Name = "";
            this.tbGrowth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbGrowth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGrowth.CustomButton.TabIndex = 1;
            this.tbGrowth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGrowth.CustomButton.UseSelectable = true;
            this.tbGrowth.CustomButton.Visible = false;
            this.tbGrowth.Lines = new string[0];
            this.tbGrowth.Location = new System.Drawing.Point(6, 43);
            this.tbGrowth.MaxLength = 32767;
            this.tbGrowth.Name = "tbGrowth";
            this.tbGrowth.PasswordChar = '\0';
            this.tbGrowth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbGrowth.SelectedText = "";
            this.tbGrowth.SelectionLength = 0;
            this.tbGrowth.SelectionStart = 0;
            this.tbGrowth.ShortcutsEnabled = true;
            this.tbGrowth.Size = new System.Drawing.Size(245, 23);
            this.tbGrowth.TabIndex = 67;
            this.tbGrowth.UseSelectable = true;
            this.tbGrowth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGrowth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(701, 507);
            this.metroTabControl1.TabIndex = 41;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditClient);
            this.tabPage1.Controls.Add(this.btnDeleteUser);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(693, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки профиля";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(242, 406);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(164, 23);
            this.btnEditClient.TabIndex = 66;
            this.btnEditClient.Text = "Сохранить изменения";
            this.btnEditClient.UseSelectable = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(242, 435);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(164, 23);
            this.btnDeleteUser.TabIndex = 65;
            this.btnDeleteUser.Text = "Удалить аккаунт";
            this.btnDeleteUser.UseSelectable = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelProduct);
            this.tabPage2.Controls.Add(this.btnMain);
            this.tabPage2.Controls.Add(this.lblCountProducts);
            this.tabPage2.Controls.Add(this.lblInfo);
            this.tabPage2.Controls.Add(this.btnCreateOrder);
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(693, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Корзина";
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // panelProduct
            // 
            this.panelProduct.AutoScroll = true;
            this.panelProduct.BackColor = System.Drawing.Color.White;
            this.panelProduct.Location = new System.Drawing.Point(3, 40);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(670, 382);
            this.panelProduct.TabIndex = 9;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(492, 11);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(181, 23);
            this.btnMain.TabIndex = 8;
            this.btnMain.Text = "Перейти к выбору товара";
            this.btnMain.UseSelectable = true;
            this.btnMain.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCountProducts
            // 
            this.lblCountProducts.AutoSize = true;
            this.lblCountProducts.Location = new System.Drawing.Point(3, 11);
            this.lblCountProducts.Name = "lblCountProducts";
            this.lblCountProducts.Size = new System.Drawing.Size(130, 19);
            this.lblCountProducts.TabIndex = 6;
            this.lblCountProducts.Text = "Товаров в корзине:";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(549, 428);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(124, 23);
            this.btnCreateOrder.TabIndex = 7;
            this.btnCreateOrder.Text = "Сделать заказ";
            this.btnCreateOrder.UseSelectable = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mGridClientOrders);
            this.tabPage3.HorizontalScrollbarBarColor = true;
            this.tabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage3.HorizontalScrollbarSize = 10;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(693, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.VerticalScrollbarBarColor = true;
            this.tabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage3.VerticalScrollbarSize = 10;
            // 
            // mGridClientOrders
            // 
            this.mGridClientOrders.AllowUserToAddRows = false;
            this.mGridClientOrders.AllowUserToDeleteRows = false;
            this.mGridClientOrders.AllowUserToResizeRows = false;
            this.mGridClientOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridClientOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridClientOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridClientOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridClientOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridClientOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colCategory,
            this.colSize,
            this.colColor,
            this.colDate,
            this.colTime,
            this.colPrice,
            this.colCount,
            this.colSum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridClientOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridClientOrders.EnableHeadersVisualStyles = false;
            this.mGridClientOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridClientOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridClientOrders.Location = new System.Drawing.Point(3, 3);
            this.mGridClientOrders.Name = "mGridClientOrders";
            this.mGridClientOrders.ReadOnly = true;
            this.mGridClientOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridClientOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridClientOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridClientOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridClientOrders.Size = new System.Drawing.Size(690, 462);
            this.mGridClientOrders.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "id";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Наименование";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Категория";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Размер";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Цвет";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Время";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Цена";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "Количество";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // colSum
            // 
            this.colSum.HeaderText = "Сумма";
            this.colSum.Name = "colSum";
            this.colSum.ReadOnly = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(723, 553);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(51, 49);
            this.metroPanel1.TabIndex = 96;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FPersonalAreaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 587);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "FPersonalAreaUser";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.FPersonalAreaUser_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridClientOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnEditClient;
        private MetroFramework.Controls.MetroButton btnDeleteUser;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private MetroFramework.Controls.MetroTabPage tabPage3;
        private MetroFramework.Controls.MetroTextBox tbPhone;
        private MetroFramework.Controls.MetroTextBox tbMail;
        private MetroFramework.Controls.MetroTextBox tbPatronymic;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroTextBox tbSurname;
        private MetroFramework.Controls.MetroTextBox tbHip;
        private MetroFramework.Controls.MetroTextBox tbWaist;
        private MetroFramework.Controls.MetroTextBox tbChest;
        private MetroFramework.Controls.MetroTextBox tbGrowth;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblMail;
        private MetroFramework.Controls.MetroLabel lblPatronymic;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel blSurname;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblInfo;
        private MetroFramework.Controls.MetroLabel lblCountProducts;
        private MetroFramework.Controls.MetroButton btnMain;
        private MetroFramework.Controls.MetroButton btnCreateOrder;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid mGridClientOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.FlowLayoutPanel panelProduct;
    }
}