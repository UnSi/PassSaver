namespace PassSaver
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.cbSiteName = new System.Windows.Forms.ComboBox();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.btnCopyLogin = new System.Windows.Forms.Button();
            this.btnEditLogin = new System.Windows.Forms.Button();
            this.btnCopyPass = new System.Windows.Forms.Button();
            this.btnEditMail = new System.Windows.Forms.Button();
            this.btnCopyMail = new System.Windows.Forms.Button();
            this.btnEditPass = new System.Windows.Forms.Button();
            this.btnAddSite = new System.Windows.Forms.Button();
            this.btnVK = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRemoveSite = new System.Windows.Forms.Button();
            this.btnEditSite = new System.Windows.Forms.Button();
            this.btnSkype = new System.Windows.Forms.Button();
            this.btnYA = new System.Windows.Forms.Button();
            this.btnMru = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.lblChooseLogin = new System.Windows.Forms.Label();
            this.cbSiteLogin = new System.Windows.Forms.ComboBox();
            this.btnLngEn = new System.Windows.Forms.Button();
            this.btnLngRu = new System.Windows.Forms.Button();
            this.btnAddLogin = new System.Windows.Forms.Button();
            this.btnRemoveLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTopMost = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(-1, 84);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(42, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(-1, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(-1, 135);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(34, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail:";
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.Peru;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.tbLogin.ForeColor = System.Drawing.Color.Gold;
            this.tbLogin.Location = new System.Drawing.Point(61, 84);
            this.tbLogin.MaxLength = 0;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(248, 20);
            this.tbLogin.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Peru;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.tbPassword.ForeColor = System.Drawing.Color.Gold;
            this.tbPassword.Location = new System.Drawing.Point(61, 109);
            this.tbPassword.MaxLength = 0;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(248, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.Peru;
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.tbMail.ForeColor = System.Drawing.Color.Gold;
            this.tbMail.Location = new System.Drawing.Point(61, 135);
            this.tbMail.MaxLength = 0;
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(248, 20);
            this.tbMail.TabIndex = 5;
            // 
            // cbSiteName
            // 
            this.cbSiteName.BackColor = System.Drawing.Color.Olive;
            this.cbSiteName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSiteName.ForeColor = System.Drawing.Color.Cyan;
            this.cbSiteName.FormattingEnabled = true;
            this.cbSiteName.Location = new System.Drawing.Point(61, 29);
            this.cbSiteName.Name = "cbSiteName";
            this.cbSiteName.Size = new System.Drawing.Size(248, 23);
            this.cbSiteName.TabIndex = 6;
            this.cbSiteName.SelectedValueChanged += new System.EventHandler(this.cbSiteName_SelectedValueChanged);
            this.cbSiteName.DropDown += new System.EventHandler(this.cbSiteName_DropDown);
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.BackColor = System.Drawing.Color.Transparent;
            this.lblSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSiteName.ForeColor = System.Drawing.Color.White;
            this.lblSiteName.Location = new System.Drawing.Point(-1, 29);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(39, 16);
            this.lblSiteName.TabIndex = 7;
            this.lblSiteName.Text = "Site:";
            // 
            // btnCopyLogin
            // 
            this.btnCopyLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyLogin.BackgroundImage")));
            this.btnCopyLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyLogin.ForeColor = System.Drawing.Color.Lime;
            this.btnCopyLogin.Location = new System.Drawing.Point(315, 84);
            this.btnCopyLogin.Name = "btnCopyLogin";
            this.btnCopyLogin.Size = new System.Drawing.Size(98, 20);
            this.btnCopyLogin.TabIndex = 8;
            this.btnCopyLogin.Text = "Copy";
            this.btnCopyLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopyLogin.UseVisualStyleBackColor = true;
            this.btnCopyLogin.Click += new System.EventHandler(this.btnCopyLogin_Click);
            // 
            // btnEditLogin
            // 
            this.btnEditLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditLogin.BackgroundImage")));
            this.btnEditLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditLogin.ForeColor = System.Drawing.Color.Yellow;
            this.btnEditLogin.Location = new System.Drawing.Point(416, 84);
            this.btnEditLogin.Name = "btnEditLogin";
            this.btnEditLogin.Size = new System.Drawing.Size(77, 19);
            this.btnEditLogin.TabIndex = 9;
            this.btnEditLogin.Text = "Edit";
            this.btnEditLogin.UseVisualStyleBackColor = true;
            this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
            // 
            // btnCopyPass
            // 
            this.btnCopyPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyPass.BackgroundImage")));
            this.btnCopyPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyPass.ForeColor = System.Drawing.Color.Lime;
            this.btnCopyPass.Location = new System.Drawing.Point(315, 109);
            this.btnCopyPass.Name = "btnCopyPass";
            this.btnCopyPass.Size = new System.Drawing.Size(98, 20);
            this.btnCopyPass.TabIndex = 10;
            this.btnCopyPass.Text = "Copy";
            this.btnCopyPass.UseVisualStyleBackColor = true;
            this.btnCopyPass.Click += new System.EventHandler(this.btnCopyPass_Click);
            // 
            // btnEditMail
            // 
            this.btnEditMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditMail.BackgroundImage")));
            this.btnEditMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditMail.ForeColor = System.Drawing.Color.Yellow;
            this.btnEditMail.Location = new System.Drawing.Point(416, 135);
            this.btnEditMail.Name = "btnEditMail";
            this.btnEditMail.Size = new System.Drawing.Size(77, 20);
            this.btnEditMail.TabIndex = 11;
            this.btnEditMail.Text = "Edit";
            this.btnEditMail.UseVisualStyleBackColor = true;
            this.btnEditMail.Click += new System.EventHandler(this.btnEditMail_Click);
            // 
            // btnCopyMail
            // 
            this.btnCopyMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyMail.BackgroundImage")));
            this.btnCopyMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyMail.ForeColor = System.Drawing.Color.Lime;
            this.btnCopyMail.Location = new System.Drawing.Point(315, 135);
            this.btnCopyMail.Name = "btnCopyMail";
            this.btnCopyMail.Size = new System.Drawing.Size(98, 20);
            this.btnCopyMail.TabIndex = 12;
            this.btnCopyMail.Text = "Copy";
            this.btnCopyMail.UseVisualStyleBackColor = true;
            this.btnCopyMail.Click += new System.EventHandler(this.btnCopyMail_Click);
            // 
            // btnEditPass
            // 
            this.btnEditPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPass.BackgroundImage")));
            this.btnEditPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditPass.ForeColor = System.Drawing.Color.Yellow;
            this.btnEditPass.Location = new System.Drawing.Point(416, 109);
            this.btnEditPass.Name = "btnEditPass";
            this.btnEditPass.Size = new System.Drawing.Size(77, 20);
            this.btnEditPass.TabIndex = 13;
            this.btnEditPass.Text = "Edit";
            this.btnEditPass.UseVisualStyleBackColor = true;
            this.btnEditPass.Click += new System.EventHandler(this.btnEditPass_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSite.BackgroundImage")));
            this.btnAddSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSite.ForeColor = System.Drawing.Color.Lime;
            this.btnAddSite.Location = new System.Drawing.Point(315, 29);
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(103, 21);
            this.btnAddSite.TabIndex = 14;
            this.btnAddSite.Text = "Add";
            this.btnAddSite.UseVisualStyleBackColor = true;
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // btnVK
            // 
            this.btnVK.BackColor = System.Drawing.Color.Blue;
            this.btnVK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVK.ForeColor = System.Drawing.Color.White;
            this.btnVK.Location = new System.Drawing.Point(7, 194);
            this.btnVK.Name = "btnVK";
            this.btnVK.Size = new System.Drawing.Size(75, 23);
            this.btnVK.TabIndex = 15;
            this.btnVK.Text = "Vk.com";
            this.btnVK.UseVisualStyleBackColor = false;
            this.btnVK.Click += new System.EventHandler(this.btnVK_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(88, 194);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Odnoklassniki.ru";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRemoveSite
            // 
            this.btnRemoveSite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveSite.BackgroundImage")));
            this.btnRemoveSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveSite.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemoveSite.Location = new System.Drawing.Point(501, 29);
            this.btnRemoveSite.Name = "btnRemoveSite";
            this.btnRemoveSite.Size = new System.Drawing.Size(75, 21);
            this.btnRemoveSite.TabIndex = 17;
            this.btnRemoveSite.Text = "Remove";
            this.btnRemoveSite.UseVisualStyleBackColor = true;
            this.btnRemoveSite.Click += new System.EventHandler(this.btnRemoveSite_Click);
            // 
            // btnEditSite
            // 
            this.btnEditSite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditSite.BackgroundImage")));
            this.btnEditSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSite.ForeColor = System.Drawing.Color.Yellow;
            this.btnEditSite.Location = new System.Drawing.Point(416, 29);
            this.btnEditSite.Name = "btnEditSite";
            this.btnEditSite.Size = new System.Drawing.Size(87, 21);
            this.btnEditSite.TabIndex = 18;
            this.btnEditSite.Text = "Edit";
            this.btnEditSite.UseVisualStyleBackColor = true;
            this.btnEditSite.Click += new System.EventHandler(this.btnEditSite_Click);
            // 
            // btnSkype
            // 
            this.btnSkype.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSkype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkype.ForeColor = System.Drawing.Color.White;
            this.btnSkype.Location = new System.Drawing.Point(196, 194);
            this.btnSkype.Name = "btnSkype";
            this.btnSkype.Size = new System.Drawing.Size(75, 23);
            this.btnSkype.TabIndex = 19;
            this.btnSkype.Text = "Skype";
            this.btnSkype.UseVisualStyleBackColor = false;
            this.btnSkype.Click += new System.EventHandler(this.btnSkype_Click);
            // 
            // btnYA
            // 
            this.btnYA.BackColor = System.Drawing.Color.Red;
            this.btnYA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYA.ForeColor = System.Drawing.Color.White;
            this.btnYA.Location = new System.Drawing.Point(277, 194);
            this.btnYA.Name = "btnYA";
            this.btnYA.Size = new System.Drawing.Size(75, 23);
            this.btnYA.TabIndex = 20;
            this.btnYA.Text = "Yandex.ru";
            this.btnYA.UseVisualStyleBackColor = false;
            this.btnYA.Click += new System.EventHandler(this.btnYA_Click);
            // 
            // btnMru
            // 
            this.btnMru.BackColor = System.Drawing.Color.MediumBlue;
            this.btnMru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMru.Location = new System.Drawing.Point(358, 194);
            this.btnMru.Name = "btnMru";
            this.btnMru.Size = new System.Drawing.Size(75, 23);
            this.btnMru.TabIndex = 21;
            this.btnMru.Text = "Mail.ru";
            this.btnMru.UseVisualStyleBackColor = false;
            this.btnMru.Click += new System.EventHandler(this.btnMru_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.Color.Teal;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.ForeColor = System.Drawing.Color.Yellow;
            this.btnGoogle.Location = new System.Drawing.Point(439, 194);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(75, 23);
            this.btnGoogle.TabIndex = 22;
            this.btnGoogle.Text = "Google.com";
            this.btnGoogle.UseVisualStyleBackColor = false;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // lblChooseLogin
            // 
            this.lblChooseLogin.AutoSize = true;
            this.lblChooseLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseLogin.ForeColor = System.Drawing.Color.White;
            this.lblChooseLogin.Location = new System.Drawing.Point(-1, 60);
            this.lblChooseLogin.Name = "lblChooseLogin";
            this.lblChooseLogin.Size = new System.Drawing.Size(112, 13);
            this.lblChooseLogin.TabIndex = 23;
            this.lblChooseLogin.Text = "Choose your login:";
            // 
            // cbSiteLogin
            // 
            this.cbSiteLogin.BackColor = System.Drawing.Color.Tan;
            this.cbSiteLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSiteLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSiteLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.cbSiteLogin.Location = new System.Drawing.Point(128, 57);
            this.cbSiteLogin.Name = "cbSiteLogin";
            this.cbSiteLogin.Size = new System.Drawing.Size(181, 21);
            this.cbSiteLogin.TabIndex = 24;
            this.cbSiteLogin.SelectedValueChanged += new System.EventHandler(this.cbSiteLogin_SelectedValueChanged);
            this.cbSiteLogin.DropDown += new System.EventHandler(this.cbSiteLogin_DropDown);
            // 
            // btnLngEn
            // 
            this.btnLngEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLngEn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLngEn.Location = new System.Drawing.Point(472, 271);
            this.btnLngEn.Name = "btnLngEn";
            this.btnLngEn.Size = new System.Drawing.Size(42, 23);
            this.btnLngEn.TabIndex = 25;
            this.btnLngEn.Text = "ENG";
            this.btnLngEn.UseVisualStyleBackColor = false;
            this.btnLngEn.Click += new System.EventHandler(this.btnLngEn_Click);
            // 
            // btnLngRu
            // 
            this.btnLngRu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLngRu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLngRu.Location = new System.Drawing.Point(522, 271);
            this.btnLngRu.Name = "btnLngRu";
            this.btnLngRu.Size = new System.Drawing.Size(43, 23);
            this.btnLngRu.TabIndex = 26;
            this.btnLngRu.Text = "РУС";
            this.btnLngRu.UseVisualStyleBackColor = false;
            this.btnLngRu.Click += new System.EventHandler(this.btnLngRu_Click);
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddLogin.BackgroundImage")));
            this.btnAddLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddLogin.ForeColor = System.Drawing.Color.Lime;
            this.btnAddLogin.Location = new System.Drawing.Point(315, 56);
            this.btnAddLogin.Name = "btnAddLogin";
            this.btnAddLogin.Size = new System.Drawing.Size(103, 23);
            this.btnAddLogin.TabIndex = 28;
            this.btnAddLogin.Text = "Add";
            this.btnAddLogin.UseVisualStyleBackColor = true;
            this.btnAddLogin.Click += new System.EventHandler(this.btnAddLogin_Click);
            // 
            // btnRemoveLogin
            // 
            this.btnRemoveLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveLogin.BackgroundImage")));
            this.btnRemoveLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveLogin.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemoveLogin.Location = new System.Drawing.Point(501, 54);
            this.btnRemoveLogin.Name = "btnRemoveLogin";
            this.btnRemoveLogin.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveLogin.TabIndex = 29;
            this.btnRemoveLogin.Text = "Remove";
            this.btnRemoveLogin.UseVisualStyleBackColor = true;
            this.btnRemoveLogin.Click += new System.EventHandler(this.btnRemoveLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiLoad});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSave
            // 
            this.tsmiSave.ForeColor = System.Drawing.Color.Yellow;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(166, 20);
            this.tsmiSave.Text = "Сохранить резервную копию";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.ForeColor = System.Drawing.Color.Red;
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(163, 20);
            this.tsmiLoad.Text = "Загрузить резервную копию";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(106, 22);
            this.tsmiClose.Text = "Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // rbTopMost
            // 
            this.rbTopMost.AutoSize = true;
            this.rbTopMost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbTopMost.Location = new System.Drawing.Point(416, 6);
            this.rbTopMost.Name = "rbTopMost";
            this.rbTopMost.Size = new System.Drawing.Size(30, 17);
            this.rbTopMost.TabIndex = 31;
            this.rbTopMost.TabStop = true;
            this.rbTopMost.Text = "5";
            this.rbTopMost.UseVisualStyleBackColor = true;
            this.rbTopMost.Click += new System.EventHandler(this.rbTopMost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 306);
            this.Controls.Add(this.rbTopMost);
            this.Controls.Add(this.btnRemoveLogin);
            this.Controls.Add(this.btnAddLogin);
            this.Controls.Add(this.btnLngRu);
            this.Controls.Add(this.btnLngEn);
            this.Controls.Add(this.cbSiteLogin);
            this.Controls.Add(this.lblChooseLogin);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.btnMru);
            this.Controls.Add(this.btnYA);
            this.Controls.Add(this.btnSkype);
            this.Controls.Add(this.btnEditSite);
            this.Controls.Add(this.btnRemoveSite);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnVK);
            this.Controls.Add(this.btnAddSite);
            this.Controls.Add(this.btnEditPass);
            this.Controls.Add(this.btnCopyMail);
            this.Controls.Add(this.btnEditMail);
            this.Controls.Add(this.btnCopyPass);
            this.Controls.Add(this.btnEditLogin);
            this.Controls.Add(this.btnCopyLogin);
            this.Controls.Add(this.lblSiteName);
            this.Controls.Add(this.cbSiteName);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PassSaver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.ComboBox cbSiteName;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.Button btnCopyLogin;
        private System.Windows.Forms.Button btnEditLogin;
        private System.Windows.Forms.Button btnCopyPass;
        private System.Windows.Forms.Button btnEditMail;
        private System.Windows.Forms.Button btnCopyMail;
        private System.Windows.Forms.Button btnEditPass;
        private System.Windows.Forms.Button btnAddSite;
        private System.Windows.Forms.Button btnVK;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRemoveSite;
        private System.Windows.Forms.Button btnEditSite;
        private System.Windows.Forms.Button btnSkype;
        private System.Windows.Forms.Button btnYA;
        private System.Windows.Forms.Button btnMru;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Label lblChooseLogin;
        private System.Windows.Forms.ComboBox cbSiteLogin;
        private System.Windows.Forms.Button btnLngEn;
        private System.Windows.Forms.Button btnLngRu;
        private System.Windows.Forms.Button btnAddLogin;
        private System.Windows.Forms.Button btnRemoveLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.RadioButton rbTopMost;
    }
}

