namespace WFA_TestMove
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_Klassenbuch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_userLogin = new System.Windows.Forms.Panel();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.btn_LoginOkay = new System.Windows.Forms.Button();
            this.btn_LoginCancel = new System.Windows.Forms.Button();
            this.tB_LoginPasswort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_LoginUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_Logout = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ausbildungsgruppeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCB_Berufsgruppen = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripCB_Berufe = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripCB_Klasse = new System.Windows.Forms.ToolStripComboBox();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausbildungsgruppeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lehrplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausbildungsgruppeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lehrplanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausbildungsgruppeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.berufToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berufsfeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_main.SuspendLayout();
            this.panel_Klassenbuch.SuspendLayout();
            this.panel_userLogin.SuspendLayout();
            this.groupBox_Login.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_main.Controls.Add(this.panel_Klassenbuch);
            this.panel_main.Controls.Add(this.panel_userLogin);
            this.panel_main.Location = new System.Drawing.Point(0, 161);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1814, 574);
            this.panel_main.TabIndex = 1;
            // 
            // panel_Klassenbuch
            // 
            this.panel_Klassenbuch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_Klassenbuch.Controls.Add(this.button1);
            this.panel_Klassenbuch.Location = new System.Drawing.Point(1345, 54);
            this.panel_Klassenbuch.Name = "panel_Klassenbuch";
            this.panel_Klassenbuch.Size = new System.Drawing.Size(340, 147);
            this.panel_Klassenbuch.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_userLogin
            // 
            this.panel_userLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_userLogin.Controls.Add(this.groupBox_Login);
            this.panel_userLogin.Location = new System.Drawing.Point(185, 54);
            this.panel_userLogin.Name = "panel_userLogin";
            this.panel_userLogin.Size = new System.Drawing.Size(970, 321);
            this.panel_userLogin.TabIndex = 0;
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.btn_LoginOkay);
            this.groupBox_Login.Controls.Add(this.btn_LoginCancel);
            this.groupBox_Login.Controls.Add(this.tB_LoginPasswort);
            this.groupBox_Login.Controls.Add(this.label2);
            this.groupBox_Login.Controls.Add(this.tB_LoginUsername);
            this.groupBox_Login.Controls.Add(this.label1);
            this.groupBox_Login.Location = new System.Drawing.Point(106, 50);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(570, 259);
            this.groupBox_Login.TabIndex = 0;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Login Klassenbuch";
            // 
            // btn_LoginOkay
            // 
            this.btn_LoginOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginOkay.Location = new System.Drawing.Point(385, 175);
            this.btn_LoginOkay.Name = "btn_LoginOkay";
            this.btn_LoginOkay.Size = new System.Drawing.Size(160, 44);
            this.btn_LoginOkay.TabIndex = 5;
            this.btn_LoginOkay.Text = "Okay";
            this.btn_LoginOkay.UseVisualStyleBackColor = true;
            this.btn_LoginOkay.Click += new System.EventHandler(this.btn_LoginOkay_Click);
            // 
            // btn_LoginCancel
            // 
            this.btn_LoginCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginCancel.Location = new System.Drawing.Point(167, 175);
            this.btn_LoginCancel.Name = "btn_LoginCancel";
            this.btn_LoginCancel.Size = new System.Drawing.Size(160, 44);
            this.btn_LoginCancel.TabIndex = 4;
            this.btn_LoginCancel.Text = "Cancel";
            this.btn_LoginCancel.UseVisualStyleBackColor = true;
            this.btn_LoginCancel.Click += new System.EventHandler(this.btn_LoginCancel_Click);
            // 
            // tB_LoginPasswort
            // 
            this.tB_LoginPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_LoginPasswort.Location = new System.Drawing.Point(167, 115);
            this.tB_LoginPasswort.Name = "tB_LoginPasswort";
            this.tB_LoginPasswort.PasswordChar = '*';
            this.tB_LoginPasswort.Size = new System.Drawing.Size(378, 29);
            this.tB_LoginPasswort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passwort";
            // 
            // tB_LoginUsername
            // 
            this.tB_LoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_LoginUsername.Location = new System.Drawing.Point(167, 48);
            this.tB_LoginUsername.Name = "tB_LoginUsername";
            this.tB_LoginUsername.Size = new System.Drawing.Size(378, 29);
            this.tB_LoginUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emailadresse";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_menu.Controls.Add(this.lbl_Logout);
            this.panel_menu.Controls.Add(this.menuStrip1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1814, 26);
            this.panel_menu.TabIndex = 0;
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.AutoSize = true;
            this.lbl_Logout.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.Location = new System.Drawing.Point(1705, 4);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(73, 16);
            this.lbl_Logout.TabIndex = 1;
            this.lbl_Logout.Text = "Ausloggen";
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            this.lbl_Logout.MouseEnter += new System.EventHandler(this.lbl_Logout_MouseEnter);
            this.lbl_Logout.MouseLeave += new System.EventHandler(this.lbl_Logout_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausbildungsgruppeToolStripMenuItem,
            this.optionenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ausbildungsgruppeToolStripMenuItem
            // 
            this.ausbildungsgruppeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCB_Berufsgruppen,
            this.toolStripCB_Berufe,
            this.toolStripCB_Klasse});
            this.ausbildungsgruppeToolStripMenuItem.Name = "ausbildungsgruppeToolStripMenuItem";
            this.ausbildungsgruppeToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.ausbildungsgruppeToolStripMenuItem.Text = "Klassenbucheintrag";
            // 
            // toolStripCB_Berufsgruppen
            // 
            this.toolStripCB_Berufsgruppen.DropDownWidth = 200;
            this.toolStripCB_Berufsgruppen.Name = "toolStripCB_Berufsgruppen";
            this.toolStripCB_Berufsgruppen.Size = new System.Drawing.Size(160, 23);
            this.toolStripCB_Berufsgruppen.TextChanged += new System.EventHandler(this.toolStripCB_Berufsgruppen_TextChanged);
            // 
            // toolStripCB_Berufe
            // 
            this.toolStripCB_Berufe.Name = "toolStripCB_Berufe";
            this.toolStripCB_Berufe.Size = new System.Drawing.Size(160, 23);
            this.toolStripCB_Berufe.Visible = false;
            this.toolStripCB_Berufe.TextChanged += new System.EventHandler(this.toolStripCB_Berufe_TextChanged);
            // 
            // toolStripCB_Klasse
            // 
            this.toolStripCB_Klasse.Name = "toolStripCB_Klasse";
            this.toolStripCB_Klasse.Size = new System.Drawing.Size(160, 23);
            this.toolStripCB_Klasse.Visible = false;
            this.toolStripCB_Klasse.TextChanged += new System.EventHandler(this.toolStripCB_Klasse_TextChanged);
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erstellenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausbildungsgruppeToolStripMenuItem1,
            this.lehrplanToolStripMenuItem});
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.erstellenToolStripMenuItem.Text = "Erstellen";
            // 
            // ausbildungsgruppeToolStripMenuItem1
            // 
            this.ausbildungsgruppeToolStripMenuItem1.Name = "ausbildungsgruppeToolStripMenuItem1";
            this.ausbildungsgruppeToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.ausbildungsgruppeToolStripMenuItem1.Text = "Ausbildungsgruppe";
            // 
            // lehrplanToolStripMenuItem
            // 
            this.lehrplanToolStripMenuItem.Name = "lehrplanToolStripMenuItem";
            this.lehrplanToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.lehrplanToolStripMenuItem.Text = "Lehrplan";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausbildungsgruppeToolStripMenuItem2,
            this.lehrplanToolStripMenuItem1});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // ausbildungsgruppeToolStripMenuItem2
            // 
            this.ausbildungsgruppeToolStripMenuItem2.Name = "ausbildungsgruppeToolStripMenuItem2";
            this.ausbildungsgruppeToolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
            this.ausbildungsgruppeToolStripMenuItem2.Text = "Ausbildungsgruppe";
            // 
            // lehrplanToolStripMenuItem1
            // 
            this.lehrplanToolStripMenuItem1.Name = "lehrplanToolStripMenuItem1";
            this.lehrplanToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.lehrplanToolStripMenuItem1.Text = "Lehrplan";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausbildungsgruppeToolStripMenuItem3,
            this.berufToolStripMenuItem,
            this.berufsfeldToolStripMenuItem});
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // ausbildungsgruppeToolStripMenuItem3
            // 
            this.ausbildungsgruppeToolStripMenuItem3.Name = "ausbildungsgruppeToolStripMenuItem3";
            this.ausbildungsgruppeToolStripMenuItem3.Size = new System.Drawing.Size(178, 22);
            this.ausbildungsgruppeToolStripMenuItem3.Text = "Ausbildungsgruppe";
            // 
            // berufToolStripMenuItem
            // 
            this.berufToolStripMenuItem.Name = "berufToolStripMenuItem";
            this.berufToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.berufToolStripMenuItem.Text = "Berufsgruppe";
            // 
            // berufsfeldToolStripMenuItem
            // 
            this.berufsfeldToolStripMenuItem.Name = "berufsfeldToolStripMenuItem";
            this.berufsfeldToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.berufsfeldToolStripMenuItem.Text = "Berufsfeld";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1814, 735);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ALBBW Klassenbuch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel_main.ResumeLayout(false);
            this.panel_Klassenbuch.ResumeLayout(false);
            this.panel_userLogin.ResumeLayout(false);
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_userLogin;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ausbildungsgruppeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausbildungsgruppeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lehrplanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausbildungsgruppeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem lehrplanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausbildungsgruppeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem berufToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berufsfeldToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Button btn_LoginOkay;
        private System.Windows.Forms.Button btn_LoginCancel;
        private System.Windows.Forms.TextBox tB_LoginPasswort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_LoginUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Logout;
        private System.Windows.Forms.ToolStripComboBox toolStripCB_Berufsgruppen;
        private System.Windows.Forms.ToolStripComboBox toolStripCB_Berufe;
        private System.Windows.Forms.ToolStripComboBox toolStripCB_Klasse;
        private System.Windows.Forms.Panel panel_Klassenbuch;
        private System.Windows.Forms.Button button1;
    }
}

