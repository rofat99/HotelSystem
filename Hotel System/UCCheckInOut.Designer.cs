namespace Hotel_System
{
    partial class UCCheckInOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.DTCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.DTCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.lstCheckInCheckOut = new System.Windows.Forms.ListView();
            this.column_Floor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbType.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin",
            "VIP"});
            this.cmbType.Location = new System.Drawing.Point(911, 29);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(278, 39);
            this.cmbType.TabIndex = 69;
            // 
            // cmbFloor
            // 
            this.cmbFloor.BackColor = System.Drawing.SystemColors.Info;
            this.cmbFloor.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFloor.ForeColor = System.Drawing.Color.Black;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Items.AddRange(new object[] {
            "G",
            "1",
            "2",
            "3"});
            this.cmbFloor.Location = new System.Drawing.Point(470, 28);
            this.cmbFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(267, 39);
            this.cmbFloor.TabIndex = 68;
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbType.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbType.Location = new System.Drawing.Point(735, 27);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(178, 41);
            this.lbType.TabIndex = 66;
            this.lbType.Text = "Type";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFloor
            // 
            this.lbFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbFloor.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFloor.Location = new System.Drawing.Point(292, 28);
            this.lbFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(178, 40);
            this.lbFloor.TabIndex = 65;
            this.lbFloor.Text = "Floor";
            this.lbFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(501, 653);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(296, 65);
            this.btnCheckIn.TabIndex = 72;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // DTCheckOut
            // 
            this.DTCheckOut.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.DTCheckOut.CustomFormat = "yyyy-MM-dd";
            this.DTCheckOut.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.DTCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTCheckOut.Location = new System.Drawing.Point(948, 597);
            this.DTCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.DTCheckOut.Name = "DTCheckOut";
            this.DTCheckOut.Size = new System.Drawing.Size(186, 36);
            this.DTCheckOut.TabIndex = 71;
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbCheckOut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbCheckOut.Location = new System.Drawing.Point(828, 597);
            this.lbCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(112, 36);
            this.lbCheckOut.TabIndex = 70;
            this.lbCheckOut.Text = "To";
            this.lbCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDate.Location = new System.Drawing.Point(501, 597);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(125, 36);
            this.lbDate.TabIndex = 67;
            this.lbDate.Text = "From";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTCheckIn
            // 
            this.DTCheckIn.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.DTCheckIn.CustomFormat = "yyyy-MM-dd";
            this.DTCheckIn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.DTCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTCheckIn.Location = new System.Drawing.Point(634, 597);
            this.DTCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.DTCheckIn.Name = "DTCheckIn";
            this.DTCheckIn.Size = new System.Drawing.Size(186, 36);
            this.DTCheckIn.TabIndex = 64;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(838, 653);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(296, 65);
            this.btnCheckOut.TabIndex = 63;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.Color.DimGray;
            this.btnAvailable.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnAvailable.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAvailable.Location = new System.Drawing.Point(1196, 28);
            this.btnAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(216, 40);
            this.btnAvailable.TabIndex = 61;
            this.btnAvailable.Text = "Search";
            this.btnAvailable.UseVisualStyleBackColor = false;
            this.btnAvailable.Click += new System.EventHandler(this.BtnAvailable_Click);
            // 
            // lstCheckInCheckOut
            // 
            this.lstCheckInCheckOut.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstCheckInCheckOut.BackColor = System.Drawing.SystemColors.Info;
            this.lstCheckInCheckOut.CausesValidation = false;
            this.lstCheckInCheckOut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Floor,
            this.column_Room,
            this.column_Type,
            this.column_Price,
            this.column_Available});
            this.lstCheckInCheckOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstCheckInCheckOut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCheckInCheckOut.FullRowSelect = true;
            this.lstCheckInCheckOut.GridLines = true;
            this.lstCheckInCheckOut.HideSelection = false;
            this.lstCheckInCheckOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            this.lstCheckInCheckOut.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lstCheckInCheckOut.LabelWrap = false;
            this.lstCheckInCheckOut.Location = new System.Drawing.Point(204, 78);
            this.lstCheckInCheckOut.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lstCheckInCheckOut.Name = "lstCheckInCheckOut";
            this.lstCheckInCheckOut.RightToLeftLayout = true;
            this.lstCheckInCheckOut.Size = new System.Drawing.Size(1293, 509);
            this.lstCheckInCheckOut.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstCheckInCheckOut.TabIndex = 62;
            this.lstCheckInCheckOut.UseCompatibleStateImageBehavior = false;
            this.lstCheckInCheckOut.View = System.Windows.Forms.View.Details;
            
            // 
            // column_Floor
            // 
            this.column_Floor.Text = "Floor";
            this.column_Floor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Floor.Width = 180;
            // 
            // column_Room
            // 
            this.column_Room.Text = "Room";
            this.column_Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Room.Width = 180;
            // 
            // column_Type
            // 
            this.column_Type.Text = "Type";
            this.column_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Type.Width = 180;
            // 
            // column_Price
            // 
            this.column_Price.Text = "Price";
            this.column_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Price.Width = 180;
            // 
            // column_Available
            // 
            this.column_Available.Text = "Available";
            this.column_Available.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_Available.Width = 250;
            // 
            // UCCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbFloor);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbFloor);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.DTCheckOut);
            this.Controls.Add(this.lbCheckOut);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.DTCheckIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.lstCheckInCheckOut);
            this.Name = "UCCheckInOut";
            this.Size = new System.Drawing.Size(1705, 813);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.DateTimePicker DTCheckOut;
        private System.Windows.Forms.Label lbCheckOut;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker DTCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.ListView lstCheckInCheckOut;
        private System.Windows.Forms.ColumnHeader column_Floor;
        private System.Windows.Forms.ColumnHeader column_Room;
        private System.Windows.Forms.ColumnHeader column_Type;
        private System.Windows.Forms.ColumnHeader column_Price;
        private System.Windows.Forms.ColumnHeader column_Available;
    }
}
