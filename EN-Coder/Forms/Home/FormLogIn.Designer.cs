namespace EN_Coder.Forms.Home
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.pCreateAcc = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnShow = new System.Windows.Forms.Label();
            this.btmLogIn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbLoginPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.pCreateAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginUsername.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginUsername.ForeColor = System.Drawing.Color.Gray;
            this.tbLoginUsername.Location = new System.Drawing.Point(146, 139);
            this.tbLoginUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(287, 20);
            this.tbLoginUsername.TabIndex = 3;
            this.tbLoginUsername.Text = "Username";
            this.tbLoginUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbCreateUserName_MouseClick);
            // 
            // pCreateAcc
            // 
            this.pCreateAcc.BackColor = System.Drawing.SystemColors.Control;
            this.pCreateAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pCreateAcc.Controls.Add(this.cbRole);
            this.pCreateAcc.Controls.Add(this.btnExit);
            this.pCreateAcc.Controls.Add(this.btnShow);
            this.pCreateAcc.Controls.Add(this.btmLogIn);
            this.pCreateAcc.Controls.Add(this.flowLayoutPanel2);
            this.pCreateAcc.Controls.Add(this.flowLayoutPanel1);
            this.pCreateAcc.Controls.Add(this.pictureBox3);
            this.pCreateAcc.Controls.Add(this.pictureBox2);
            this.pCreateAcc.Controls.Add(this.tbLoginPass);
            this.pCreateAcc.Controls.Add(this.tbLoginUsername);
            this.pCreateAcc.Controls.Add(this.label4);
            this.pCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCreateAcc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pCreateAcc.Location = new System.Drawing.Point(250, 0);
            this.pCreateAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pCreateAcc.Name = "pCreateAcc";
            this.pCreateAcc.Size = new System.Drawing.Size(550, 450);
            this.pCreateAcc.TabIndex = 16;
            this.pCreateAcc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pCreateAcc_MouseDown);
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.cbRole.Location = new System.Drawing.Point(110, 283);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(311, 28);
            this.cbRole.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(515, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Gray;
            this.btnShow.Location = new System.Drawing.Point(379, 225);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(42, 18);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btmLogIn
            // 
            this.btmLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(190)))), ((int)(((byte)(131)))));
            this.btmLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmLogIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btmLogIn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLogIn.ForeColor = System.Drawing.Color.Black;
            this.btmLogIn.Location = new System.Drawing.Point(140, 380);
            this.btmLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmLogIn.Name = "btmLogIn";
            this.btmLogIn.Size = new System.Drawing.Size(287, 34);
            this.btmLogIn.TabIndex = 12;
            this.btmLogIn.Text = "Log In";
            this.btmLogIn.UseVisualStyleBackColor = false;
            this.btmLogIn.Click += new System.EventHandler(this.btmLogIn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(110, 164);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(317, 2);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(110, 248);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(317, 2);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(110, 212);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 129);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tbLoginPass
            // 
            this.tbLoginPass.BackColor = System.Drawing.SystemColors.Control;
            this.tbLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginPass.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tbLoginPass.ForeColor = System.Drawing.Color.Gray;
            this.tbLoginPass.Location = new System.Drawing.Point(146, 222);
            this.tbLoginPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLoginPass.Name = "tbLoginPass";
            this.tbLoginPass.Size = new System.Drawing.Size(287, 20);
            this.tbLoginPass.TabIndex = 4;
            this.tbLoginPass.Text = "Password";
            this.tbLoginPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbCreatePass_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(154, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 49);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "PRODUCT MANAGEMENT SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.White;
            this.lName.Location = new System.Drawing.Point(59, 52);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(130, 40);
            this.lName.TabIndex = 18;
            this.lName.Text = "Encoder";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pCreateAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogIn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogIn_MouseDown);
            this.pCreateAcc.ResumeLayout(false);
            this.pCreateAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.Panel pCreateAcc;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label btnShow;
        private System.Windows.Forms.Button btmLogIn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbLoginPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ComboBox cbRole;
    }
}