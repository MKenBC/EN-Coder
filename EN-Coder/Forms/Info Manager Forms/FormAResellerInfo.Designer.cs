namespace EN_Coder.Forms.Info_Manager_Forms
{
    partial class FormAResellerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAResellerInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgResellersInfo = new System.Windows.Forms.DataGridView();
            this.tbRPlatform = new System.Windows.Forms.TextBox();
            this.tbRName = new System.Windows.Forms.TextBox();
            this.tbRContact = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbRDescription = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbRID = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRDelete = new FontAwesome.Sharp.IconButton();
            this.btnRAdd = new FontAwesome.Sharp.IconButton();
            this.btnRUpdate = new FontAwesome.Sharp.IconButton();
            this.btnRClear = new FontAwesome.Sharp.IconButton();
            this.btnExtract = new FontAwesome.Sharp.IconButton();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResellersInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(177)))), ((int)(((byte)(195)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1082, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 753);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(354, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // dgResellersInfo
            // 
            this.dgResellersInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResellersInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResellersInfo.Location = new System.Drawing.Point(12, 205);
            this.dgResellersInfo.Name = "dgResellersInfo";
            this.dgResellersInfo.RowHeadersWidth = 51;
            this.dgResellersInfo.RowTemplate.Height = 24;
            this.dgResellersInfo.Size = new System.Drawing.Size(1058, 490);
            this.dgResellersInfo.TabIndex = 46;
            this.dgResellersInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgResellersInfo_MouseDoubleClick);
            // 
            // tbRPlatform
            // 
            this.tbRPlatform.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbRPlatform.BackColor = System.Drawing.SystemColors.Control;
            this.tbRPlatform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRPlatform.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.tbRPlatform.ForeColor = System.Drawing.Color.Gray;
            this.tbRPlatform.Location = new System.Drawing.Point(390, 121);
            this.tbRPlatform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRPlatform.Name = "tbRPlatform";
            this.tbRPlatform.Size = new System.Drawing.Size(241, 31);
            this.tbRPlatform.TabIndex = 47;
            this.tbRPlatform.Text = "Income Platform";
            this.tbRPlatform.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRPlatform_MouseClick);
            // 
            // tbRName
            // 
            this.tbRName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbRName.BackColor = System.Drawing.SystemColors.Control;
            this.tbRName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRName.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.tbRName.ForeColor = System.Drawing.Color.Gray;
            this.tbRName.Location = new System.Drawing.Point(390, 18);
            this.tbRName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRName.Name = "tbRName";
            this.tbRName.Size = new System.Drawing.Size(241, 31);
            this.tbRName.TabIndex = 50;
            this.tbRName.Text = "Resellers Name";
            this.tbRName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRName_MouseClick);
            // 
            // tbRContact
            // 
            this.tbRContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbRContact.BackColor = System.Drawing.SystemColors.Control;
            this.tbRContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRContact.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.tbRContact.ForeColor = System.Drawing.Color.Gray;
            this.tbRContact.Location = new System.Drawing.Point(63, 121);
            this.tbRContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRContact.Name = "tbRContact";
            this.tbRContact.Size = new System.Drawing.Size(241, 31);
            this.tbRContact.TabIndex = 56;
            this.tbRContact.Text = "Contact";
            this.tbRContact.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRContact_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(27, 122);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // tbRDescription
            // 
            this.tbRDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbRDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbRDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRDescription.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.tbRDescription.ForeColor = System.Drawing.Color.Gray;
            this.tbRDescription.Location = new System.Drawing.Point(717, 18);
            this.tbRDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRDescription.Name = "tbRDescription";
            this.tbRDescription.Size = new System.Drawing.Size(320, 31);
            this.tbRDescription.TabIndex = 53;
            this.tbRDescription.Text = "Description";
            this.tbRDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRDescription_MouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(681, 19);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(63, 173);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(241, 2);
            this.flowLayoutPanel3.TabIndex = 48;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(390, 173);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(241, 2);
            this.flowLayoutPanel5.TabIndex = 48;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(717, 70);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 2);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbRDescription, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbRID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbRName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbRPlatform, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbRContact, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 187);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(63, 70);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(241, 2);
            this.flowLayoutPanel2.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // tbRID
            // 
            this.tbRID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbRID.BackColor = System.Drawing.SystemColors.Control;
            this.tbRID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRID.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.tbRID.ForeColor = System.Drawing.Color.Gray;
            this.tbRID.Location = new System.Drawing.Point(63, 18);
            this.tbRID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRID.Name = "tbRID";
            this.tbRID.Size = new System.Drawing.Size(241, 31);
            this.tbRID.TabIndex = 55;
            this.tbRID.Text = "Resellers ID";
            this.tbRID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRID_MouseClick);
            this.tbRID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRID_KeyPress);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(390, 70);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(241, 2);
            this.flowLayoutPanel4.TabIndex = 48;
            // 
            // btnRDelete
            // 
            this.btnRDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(152)))), ((int)(((byte)(202)))));
            this.btnRDelete.Enabled = false;
            this.btnRDelete.FlatAppearance.BorderSize = 0;
            this.btnRDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDelete.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRDelete.IconColor = System.Drawing.Color.Black;
            this.btnRDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRDelete.Location = new System.Drawing.Point(304, 701);
            this.btnRDelete.Name = "btnRDelete";
            this.btnRDelete.Size = new System.Drawing.Size(140, 40);
            this.btnRDelete.TabIndex = 60;
            this.btnRDelete.Text = "Delete";
            this.btnRDelete.UseVisualStyleBackColor = false;
            this.btnRDelete.Click += new System.EventHandler(this.btnRDelete_Click);
            // 
            // btnRAdd
            // 
            this.btnRAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(152)))), ((int)(((byte)(202)))));
            this.btnRAdd.FlatAppearance.BorderSize = 0;
            this.btnRAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRAdd.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRAdd.IconColor = System.Drawing.Color.Black;
            this.btnRAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRAdd.Location = new System.Drawing.Point(12, 701);
            this.btnRAdd.Name = "btnRAdd";
            this.btnRAdd.Size = new System.Drawing.Size(140, 40);
            this.btnRAdd.TabIndex = 59;
            this.btnRAdd.Text = "Add";
            this.btnRAdd.UseVisualStyleBackColor = false;
            this.btnRAdd.Click += new System.EventHandler(this.btnRAdd_Click);
            // 
            // btnRUpdate
            // 
            this.btnRUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(152)))), ((int)(((byte)(202)))));
            this.btnRUpdate.Enabled = false;
            this.btnRUpdate.FlatAppearance.BorderSize = 0;
            this.btnRUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRUpdate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRUpdate.IconColor = System.Drawing.Color.Black;
            this.btnRUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRUpdate.Location = new System.Drawing.Point(158, 701);
            this.btnRUpdate.Name = "btnRUpdate";
            this.btnRUpdate.Size = new System.Drawing.Size(140, 40);
            this.btnRUpdate.TabIndex = 61;
            this.btnRUpdate.Text = "Update";
            this.btnRUpdate.UseVisualStyleBackColor = false;
            this.btnRUpdate.Click += new System.EventHandler(this.btnRUpdate_Click);
            // 
            // btnRClear
            // 
            this.btnRClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(152)))), ((int)(((byte)(202)))));
            this.btnRClear.FlatAppearance.BorderSize = 0;
            this.btnRClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRClear.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRClear.IconColor = System.Drawing.Color.Black;
            this.btnRClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRClear.Location = new System.Drawing.Point(450, 701);
            this.btnRClear.Name = "btnRClear";
            this.btnRClear.Size = new System.Drawing.Size(140, 40);
            this.btnRClear.TabIndex = 62;
            this.btnRClear.Text = "Clear";
            this.btnRClear.UseVisualStyleBackColor = false;
            this.btnRClear.Click += new System.EventHandler(this.btnRClear_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.btnExtract.FlatAppearance.BorderSize = 0;
            this.btnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtract.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtract.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExtract.IconColor = System.Drawing.Color.Black;
            this.btnExtract.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExtract.Location = new System.Drawing.Point(596, 701);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(140, 40);
            this.btnExtract.TabIndex = 63;
            this.btnExtract.Text = "Excel";
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrint.IconColor = System.Drawing.Color.Black;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.Location = new System.Drawing.Point(742, 701);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 40);
            this.btnPrint.TabIndex = 64;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormAResellerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnRClear);
            this.Controls.Add(this.btnRUpdate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRDelete);
            this.Controls.Add(this.btnRAdd);
            this.Controls.Add(this.dgResellersInfo);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormAResellerInfo";
            this.Text = "FormAResellersInfo";
            this.Load += new System.EventHandler(this.FormAResellerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResellersInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgResellersInfo;
        private System.Windows.Forms.TextBox tbRPlatform;
        private System.Windows.Forms.TextBox tbRName;
        private System.Windows.Forms.TextBox tbRContact;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbRDescription;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private FontAwesome.Sharp.IconButton btnRDelete;
        private FontAwesome.Sharp.IconButton btnRAdd;
        private FontAwesome.Sharp.IconButton btnRUpdate;
        private FontAwesome.Sharp.IconButton btnRClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbRID;
        private FontAwesome.Sharp.IconButton btnExtract;
        private FontAwesome.Sharp.IconButton btnPrint;
    }
}