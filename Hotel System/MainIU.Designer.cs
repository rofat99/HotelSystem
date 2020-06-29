namespace Hotel_System
{
    partial class MainIU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainIU));
            this.btnIntCheckInOut = new System.Windows.Forms.Button();
            this.btnIntCustomer = new System.Windows.Forms.Button();
            this.btnIntRoom = new System.Windows.Forms.Button();
            this.btnIntReport = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.clicked_checkinout = new System.Windows.Forms.Panel();
            this.clicked_customer = new System.Windows.Forms.Panel();
            this.clicked_room = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.btnColorful = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbChangeTheme = new System.Windows.Forms.Label();
            this.titleAll1 = new Hotel_System.TitleAll();
            this.ucCheckInOut1 = new Hotel_System.UCCheckInOut();
            this.ucRoom1 = new Hotel_System.UCRoom();
            this.ucCustomer1 = new Hotel_System.UCCustomer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIntCheckInOut
            // 
            this.btnIntCheckInOut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIntCheckInOut.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntCheckInOut.ForeColor = System.Drawing.Color.White;
            this.btnIntCheckInOut.Location = new System.Drawing.Point(-2, 219);
            this.btnIntCheckInOut.Name = "btnIntCheckInOut";
            this.btnIntCheckInOut.Size = new System.Drawing.Size(311, 151);
            this.btnIntCheckInOut.TabIndex = 1;
            this.btnIntCheckInOut.Text = "Check In-Out";
            this.btnIntCheckInOut.UseVisualStyleBackColor = false;
            this.btnIntCheckInOut.Click += new System.EventHandler(this.BtnIntCheckInOut_Click);
            // 
            // btnIntCustomer
            // 
            this.btnIntCustomer.BackColor = System.Drawing.Color.Magenta;
            this.btnIntCustomer.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntCustomer.ForeColor = System.Drawing.Color.White;
            this.btnIntCustomer.Location = new System.Drawing.Point(-2, 365);
            this.btnIntCustomer.Name = "btnIntCustomer";
            this.btnIntCustomer.Size = new System.Drawing.Size(311, 151);
            this.btnIntCustomer.TabIndex = 5;
            this.btnIntCustomer.Text = "Customer";
            this.btnIntCustomer.UseVisualStyleBackColor = false;
            this.btnIntCustomer.Click += new System.EventHandler(this.BtnIntCustomer_Click);
            // 
            // btnIntRoom
            // 
            this.btnIntRoom.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnIntRoom.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntRoom.ForeColor = System.Drawing.Color.White;
            this.btnIntRoom.Location = new System.Drawing.Point(-2, 513);
            this.btnIntRoom.Name = "btnIntRoom";
            this.btnIntRoom.Size = new System.Drawing.Size(311, 151);
            this.btnIntRoom.TabIndex = 6;
            this.btnIntRoom.Text = "Room";
            this.btnIntRoom.UseVisualStyleBackColor = false;
            this.btnIntRoom.Click += new System.EventHandler(this.BtnIntRoom_Click);
            // 
            // btnIntReport
            // 
            this.btnIntReport.BackColor = System.Drawing.Color.MediumPurple;
            this.btnIntReport.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntReport.ForeColor = System.Drawing.Color.White;
            this.btnIntReport.Location = new System.Drawing.Point(-2, 661);
            this.btnIntReport.Name = "btnIntReport";
            this.btnIntReport.Size = new System.Drawing.Size(311, 151);
            this.btnIntReport.TabIndex = 7;
            this.btnIntReport.Text = "Report";
            this.btnIntReport.UseVisualStyleBackColor = false;
            this.btnIntReport.Click += new System.EventHandler(this.BtnIntReport_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Crimson;
            this.btnSignOut.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(-2, 808);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(311, 151);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.BtnIntSignOut_Click);
            // 
            // clicked_checkinout
            // 
            this.clicked_checkinout.BackColor = System.Drawing.Color.Teal;
            this.clicked_checkinout.Location = new System.Drawing.Point(-2, 222);
            this.clicked_checkinout.Name = "clicked_checkinout";
            this.clicked_checkinout.Size = new System.Drawing.Size(16, 145);
            this.clicked_checkinout.TabIndex = 9;
            // 
            // clicked_customer
            // 
            this.clicked_customer.BackColor = System.Drawing.Color.MediumVioletRed;
            this.clicked_customer.Location = new System.Drawing.Point(-2, 368);
            this.clicked_customer.Name = "clicked_customer";
            this.clicked_customer.Size = new System.Drawing.Size(16, 145);
            this.clicked_customer.TabIndex = 10;
            // 
            // clicked_room
            // 
            this.clicked_room.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.clicked_room.Location = new System.Drawing.Point(-2, 517);
            this.clicked_room.Name = "clicked_room";
            this.clicked_room.Size = new System.Drawing.Size(16, 145);
            this.clicked_room.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1812, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(1812, 63);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(108, 24);
            this.txtUser.TabIndex = 12;
            this.txtUser.Text = "Username";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExit.Font = new System.Drawing.Font("Antique-Olive Wd", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1873, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 32);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMinimize.Font = new System.Drawing.Font("Antique-Olive Wd", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1813, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 32);
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.Text = "--";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInfo.Font = new System.Drawing.Font("Antique-Olive Wd", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(1751, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(45, 32);
            this.btnInfo.TabIndex = 17;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.btnDarkMode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarkMode.ForeColor = System.Drawing.Color.White;
            this.btnDarkMode.Location = new System.Drawing.Point(1768, 181);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(69, 31);
            this.btnDarkMode.TabIndex = 18;
            this.btnDarkMode.Text = "Dark";
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.BtnDarkMode_Click);
            // 
            // btnColorful
            // 
            this.btnColorful.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnColorful.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorful.ForeColor = System.Drawing.Color.Black;
            this.btnColorful.Location = new System.Drawing.Point(1851, 181);
            this.btnColorful.Name = "btnColorful";
            this.btnColorful.Size = new System.Drawing.Size(69, 31);
            this.btnColorful.TabIndex = 19;
            this.btnColorful.Text = "Color";
            this.btnColorful.UseVisualStyleBackColor = false;
            this.btnColorful.Click += new System.EventHandler(this.BtnColorful_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hotel_System.Properties.Resources.icons8_name_52;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1768, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbChangeTheme
            // 
            this.lbChangeTheme.AutoSize = true;
            this.lbChangeTheme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbChangeTheme.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeTheme.Location = new System.Drawing.Point(1799, 149);
            this.lbChangeTheme.Name = "lbChangeTheme";
            this.lbChangeTheme.Size = new System.Drawing.Size(88, 19);
            this.lbChangeTheme.TabIndex = 20;
            this.lbChangeTheme.Text = "Appearance";
            // 
            // titleAll1
            // 
            this.titleAll1.BackColor = System.Drawing.Color.White;
            this.titleAll1.Getvalue = false;
            this.titleAll1.Location = new System.Drawing.Point(-112, -7);
            this.titleAll1.Name = "titleAll1";
            this.titleAll1.Size = new System.Drawing.Size(2201, 226);
            this.titleAll1.TabIndex = 0;
            // 
            // ucCheckInOut1
            // 
            this.ucCheckInOut1.BackColor = System.Drawing.Color.Cyan;
            this.ucCheckInOut1.Getvalue = false;
            this.ucCheckInOut1.Location = new System.Drawing.Point(311, 219);
            this.ucCheckInOut1.Name = "ucCheckInOut1";
            this.ucCheckInOut1.Size = new System.Drawing.Size(1712, 764);
            this.ucCheckInOut1.TabIndex = 4;
            this.ucCheckInOut1.AfterBtnAddClick += new System.EventHandler(this.UcCheckInOut1_AfterBtnAddClick);
            this.ucCheckInOut1.ClickCh += new System.EventHandler(this.UcCheckInOut1_ClickCh);
            // 
            // ucRoom1
            // 
            this.ucRoom1.BackColor = System.Drawing.Color.LightGreen;
            this.ucRoom1.Location = new System.Drawing.Point(311, 219);
            this.ucRoom1.Name = "ucRoom1";
            this.ucRoom1.Size = new System.Drawing.Size(1712, 743);
            this.ucRoom1.TabIndex = 2;
            // 
            // ucCustomer1
            // 
            this.ucCustomer1.BackColor = System.Drawing.Color.Fuchsia;
            this.ucCustomer1.Location = new System.Drawing.Point(311, 218);
            this.ucCustomer1.Name = "ucCustomer1";
            this.ucCustomer1.Size = new System.Drawing.Size(1699, 740);
            this.ucCustomer1.TabIndex = 3;
            this.ucCustomer1.Click += new System.EventHandler(this.UcCustomer1_Click);
            // 
            // MainIU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 959);
            this.Controls.Add(this.lbChangeTheme);
            this.Controls.Add(this.btnColorful);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.clicked_room);
            this.Controls.Add(this.clicked_customer);
            this.Controls.Add(this.clicked_checkinout);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnIntReport);
            this.Controls.Add(this.btnIntRoom);
            this.Controls.Add(this.btnIntCustomer);
            this.Controls.Add(this.btnIntCheckInOut);
            this.Controls.Add(this.titleAll1);
            this.Controls.Add(this.ucCheckInOut1);
            this.Controls.Add(this.ucRoom1);
            this.Controls.Add(this.ucCustomer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainIU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainIU";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TitleAll titleAll1;
        private System.Windows.Forms.Button btnIntCheckInOut;
        private UCRoom ucRoom1;
        private UCCustomer ucCustomer1;
        private UCCheckInOut ucCheckInOut1;
        private System.Windows.Forms.Button btnIntCustomer;
        private System.Windows.Forms.Button btnIntRoom;
        private System.Windows.Forms.Button btnIntReport;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel clicked_checkinout;
        private System.Windows.Forms.Panel clicked_customer;
        private System.Windows.Forms.Panel clicked_room;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Button btnColorful;
        private System.Windows.Forms.Label lbChangeTheme;
    }
}