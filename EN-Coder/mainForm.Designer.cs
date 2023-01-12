namespace EN_Coder
{
    partial class mainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEncode = new FontAwesome.Sharp.IconButton();
            this.btnStatistics = new FontAwesome.Sharp.IconButton();
            this.btnResellersIncome = new FontAwesome.Sharp.IconButton();
            this.btnCashMonitor = new FontAwesome.Sharp.IconButton();
            this.btnProductInventory = new FontAwesome.Sharp.IconButton();
            this.panelSubButtons = new System.Windows.Forms.Panel();
            this.btnAccountsInfo = new System.Windows.Forms.Button();
            this.btnProductInfo = new System.Windows.Forms.Button();
            this.btnResellersInfo = new System.Windows.Forms.Button();
            this.btnInfoManager = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.pProfile = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPDelete = new FontAwesome.Sharp.IconButton();
            this.btnPUpdate = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnRestore = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lChange = new System.Windows.Forms.Label();
            this.iconChange = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lClock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelSubButtons.SuspendLayout();
            this.pLogo.SuspendLayout();
            this.pTitleBar.SuspendLayout();
            this.pProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChange)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.btnEncode);
            this.panelMenu.Controls.Add(this.btnStatistics);
            this.panelMenu.Controls.Add(this.btnResellersIncome);
            this.panelMenu.Controls.Add(this.btnCashMonitor);
            this.panelMenu.Controls.Add(this.btnProductInventory);
            this.panelMenu.Controls.Add(this.panelSubButtons);
            this.panelMenu.Controls.Add(this.btnInfoManager);
            this.panelMenu.Controls.Add(this.pLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 653);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // btnEncode
            // 
            this.btnEncode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEncode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncode.FlatAppearance.BorderSize = 0;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncode.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            this.btnEncode.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEncode.IconSize = 32;
            this.btnEncode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.Location = new System.Drawing.Point(0, 564);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEncode.Size = new System.Drawing.Size(250, 60);
            this.btnEncode.TabIndex = 7;
            this.btnEncode.Text = "ENCODER";
            this.btnEncode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStatistics.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnStatistics.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnStatistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistics.IconSize = 32;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 504);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStatistics.Size = new System.Drawing.Size(250, 60);
            this.btnStatistics.TabIndex = 6;
            this.btnStatistics.Text = "Statictics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnResellersIncome
            // 
            this.btnResellersIncome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResellersIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResellersIncome.FlatAppearance.BorderSize = 0;
            this.btnResellersIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResellersIncome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnResellersIncome.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnResellersIncome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnResellersIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResellersIncome.IconSize = 32;
            this.btnResellersIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResellersIncome.Location = new System.Drawing.Point(0, 444);
            this.btnResellersIncome.Name = "btnResellersIncome";
            this.btnResellersIncome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnResellersIncome.Size = new System.Drawing.Size(250, 60);
            this.btnResellersIncome.TabIndex = 5;
            this.btnResellersIncome.Text = "Resellers Income";
            this.btnResellersIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResellersIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResellersIncome.UseVisualStyleBackColor = true;
            this.btnResellersIncome.Click += new System.EventHandler(this.btnRI_Click);
            // 
            // btnCashMonitor
            // 
            this.btnCashMonitor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCashMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashMonitor.FlatAppearance.BorderSize = 0;
            this.btnCashMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashMonitor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCashMonitor.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnCashMonitor.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCashMonitor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCashMonitor.IconSize = 32;
            this.btnCashMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashMonitor.Location = new System.Drawing.Point(0, 384);
            this.btnCashMonitor.Name = "btnCashMonitor";
            this.btnCashMonitor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCashMonitor.Size = new System.Drawing.Size(250, 60);
            this.btnCashMonitor.TabIndex = 4;
            this.btnCashMonitor.Text = "Cash Monitor";
            this.btnCashMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashMonitor.UseVisualStyleBackColor = true;
            this.btnCashMonitor.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // btnProductInventory
            // 
            this.btnProductInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProductInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductInventory.FlatAppearance.BorderSize = 0;
            this.btnProductInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInventory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductInventory.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnProductInventory.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductInventory.IconSize = 32;
            this.btnProductInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductInventory.Location = new System.Drawing.Point(0, 324);
            this.btnProductInventory.Name = "btnProductInventory";
            this.btnProductInventory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductInventory.Size = new System.Drawing.Size(250, 60);
            this.btnProductInventory.TabIndex = 3;
            this.btnProductInventory.Text = "Product Inventory";
            this.btnProductInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductInventory.UseVisualStyleBackColor = true;
            this.btnProductInventory.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // panelSubButtons
            // 
            this.panelSubButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.panelSubButtons.Controls.Add(this.btnAccountsInfo);
            this.panelSubButtons.Controls.Add(this.btnProductInfo);
            this.panelSubButtons.Controls.Add(this.btnResellersInfo);
            this.panelSubButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubButtons.Location = new System.Drawing.Point(0, 200);
            this.panelSubButtons.Name = "panelSubButtons";
            this.panelSubButtons.Size = new System.Drawing.Size(250, 124);
            this.panelSubButtons.TabIndex = 2;
            // 
            // btnAccountsInfo
            // 
            this.btnAccountsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnAccountsInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountsInfo.FlatAppearance.BorderSize = 0;
            this.btnAccountsInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.btnAccountsInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(139)))), ((int)(((byte)(166)))));
            this.btnAccountsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountsInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccountsInfo.Location = new System.Drawing.Point(0, 80);
            this.btnAccountsInfo.Name = "btnAccountsInfo";
            this.btnAccountsInfo.Size = new System.Drawing.Size(250, 40);
            this.btnAccountsInfo.TabIndex = 2;
            this.btnAccountsInfo.Text = "Accounts Info";
            this.btnAccountsInfo.UseVisualStyleBackColor = false;
            this.btnAccountsInfo.Click += new System.EventHandler(this.btnBInfo_Click);
            // 
            // btnProductInfo
            // 
            this.btnProductInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnProductInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductInfo.FlatAppearance.BorderSize = 0;
            this.btnProductInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.btnProductInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(139)))), ((int)(((byte)(166)))));
            this.btnProductInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductInfo.Location = new System.Drawing.Point(0, 40);
            this.btnProductInfo.Name = "btnProductInfo";
            this.btnProductInfo.Size = new System.Drawing.Size(250, 40);
            this.btnProductInfo.TabIndex = 1;
            this.btnProductInfo.Text = "Product Info";
            this.btnProductInfo.UseVisualStyleBackColor = false;
            this.btnProductInfo.Click += new System.EventHandler(this.btnPInfo_Click);
            // 
            // btnResellersInfo
            // 
            this.btnResellersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnResellersInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResellersInfo.FlatAppearance.BorderSize = 0;
            this.btnResellersInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
            this.btnResellersInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(139)))), ((int)(((byte)(166)))));
            this.btnResellersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResellersInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnResellersInfo.Location = new System.Drawing.Point(0, 0);
            this.btnResellersInfo.Name = "btnResellersInfo";
            this.btnResellersInfo.Size = new System.Drawing.Size(250, 40);
            this.btnResellersInfo.TabIndex = 0;
            this.btnResellersInfo.Text = "Reseller Info";
            this.btnResellersInfo.UseVisualStyleBackColor = false;
            this.btnResellersInfo.Click += new System.EventHandler(this.btnRInfo_Click);
            // 
            // btnInfoManager
            // 
            this.btnInfoManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInfoManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoManager.FlatAppearance.BorderSize = 0;
            this.btnInfoManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoManager.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInfoManager.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfoManager.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnInfoManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfoManager.IconSize = 32;
            this.btnInfoManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoManager.Location = new System.Drawing.Point(0, 140);
            this.btnInfoManager.Name = "btnInfoManager";
            this.btnInfoManager.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInfoManager.Size = new System.Drawing.Size(250, 60);
            this.btnInfoManager.TabIndex = 1;
            this.btnInfoManager.Text = "Information Manager";
            this.btnInfoManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfoManager.UseVisualStyleBackColor = true;
            this.btnInfoManager.Click += new System.EventHandler(this.btnIM_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.lName);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(250, 140);
            this.pLogo.TabIndex = 0;
            this.pLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pLogo_MouseClick);
            this.pLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pLogo_MouseDown);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lName.Location = new System.Drawing.Point(57, 30);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(130, 40);
            this.lName.TabIndex = 0;
            this.lName.Text = "Encoder";
            this.lName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pTitleBar.Controls.Add(this.pProfile);
            this.pTitleBar.Controls.Add(this.btnProfile);
            this.pTitleBar.Controls.Add(this.btnRestore);
            this.pTitleBar.Controls.Add(this.btnExit);
            this.pTitleBar.Controls.Add(this.lChange);
            this.pTitleBar.Controls.Add(this.iconChange);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pTitleBar.Location = new System.Drawing.Point(250, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(832, 80);
            this.pTitleBar.TabIndex = 8;
            this.pTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleBar_MouseDown);
            // 
            // pProfile
            // 
            this.pProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pProfile.Controls.Add(this.tableLayoutPanel1);
            this.pProfile.Location = new System.Drawing.Point(595, 30);
            this.pProfile.Name = "pProfile";
            this.pProfile.Size = new System.Drawing.Size(237, 50);
            this.pProfile.TabIndex = 8;
            this.pProfile.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPDelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPUpdate, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 44);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnPDelete
            // 
            this.btnPDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(152)))), ((int)(((byte)(202)))));
            this.btnPDelete.FlatAppearance.BorderSize = 0;
            this.btnPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDelete.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnPDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPDelete.IconColor = System.Drawing.Color.Black;
            this.btnPDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPDelete.Location = new System.Drawing.Point(120, 5);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(105, 34);
            this.btnPDelete.TabIndex = 83;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = false;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(152)))), ((int)(((byte)(202)))));
            this.btnPUpdate.FlatAppearance.BorderSize = 0;
            this.btnPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUpdate.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnPUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPUpdate.IconColor = System.Drawing.Color.Black;
            this.btnPUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPUpdate.Location = new System.Drawing.Point(7, 5);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnPUpdate.TabIndex = 82;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.UseVisualStyleBackColor = false;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnProfile.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 20;
            this.btnProfile.Location = new System.Drawing.Point(715, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(35, 35);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestore.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestore.IconSize = 20;
            this.btnRestore.Location = new System.Drawing.Point(756, 0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(35, 35);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(797, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lChange
            // 
            this.lChange.AutoSize = true;
            this.lChange.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lChange.Location = new System.Drawing.Point(70, 30);
            this.lChange.Name = "lChange";
            this.lChange.Size = new System.Drawing.Size(57, 23);
            this.lChange.TabIndex = 1;
            this.lChange.Text = "Home";
            // 
            // iconChange
            // 
            this.iconChange.BackColor = System.Drawing.Color.Transparent;
            this.iconChange.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChange.IconColor = System.Drawing.Color.White;
            this.iconChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChange.IconSize = 40;
            this.iconChange.Location = new System.Drawing.Point(27, 22);
            this.iconChange.Name = "iconChange";
            this.iconChange.Size = new System.Drawing.Size(40, 40);
            this.iconChange.TabIndex = 0;
            this.iconChange.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 10);
            this.panel1.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelContainer.Controls.Add(this.lClock);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("Calibri Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContainer.Location = new System.Drawing.Point(250, 90);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(832, 563);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContainer_MouseDown);
            // 
            // lClock
            // 
            this.lClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lClock.AutoSize = true;
            this.lClock.Font = new System.Drawing.Font("Calibri Light", 36F);
            this.lClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lClock.Location = new System.Drawing.Point(281, 272);
            this.lClock.Name = "lClock";
            this.lClock.Size = new System.Drawing.Size(244, 73);
            this.lClock.TabIndex = 2;
            this.lClock.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(270, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Management System";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(292, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encoder";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pTitleBar);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encoder";
            this.panelMenu.ResumeLayout(false);
            this.panelSubButtons.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            this.pTitleBar.ResumeLayout(false);
            this.pTitleBar.PerformLayout();
            this.pProfile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconChange)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnInfoManager;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Panel panelSubButtons;
        private System.Windows.Forms.Button btnAccountsInfo;
        private System.Windows.Forms.Button btnProductInfo;
        private System.Windows.Forms.Button btnResellersInfo;
        private FontAwesome.Sharp.IconButton btnProductInventory;
        private FontAwesome.Sharp.IconButton btnCashMonitor;
        private FontAwesome.Sharp.IconButton btnResellersIncome;
        private FontAwesome.Sharp.IconButton btnStatistics;
        private System.Windows.Forms.Panel pTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconChange;
        private System.Windows.Forms.Label lChange;
        private FontAwesome.Sharp.IconButton btnEncode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lClock;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnRestore;
        private FontAwesome.Sharp.IconButton btnProfile;
        private System.Windows.Forms.Panel pProfile;
        private FontAwesome.Sharp.IconButton btnPDelete;
        private FontAwesome.Sharp.IconButton btnPUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

