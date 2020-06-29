namespace Hotel_System
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
           
            this.btnCheckInRep = new System.Windows.Forms.Button();
            this.btnCheckOutRep = new System.Windows.Forms.Button();
            this.btnCustomerRep = new System.Windows.Forms.Button();
            this.btnStaffRep = new System.Windows.Forms.Button();
            this.btnRoomRep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            
            this.SuspendLayout();
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            
            // 
          
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HotelDataSet";
            reportDataSource1.Value = this.tblCustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotel_System.HotelReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1177, 485);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.ReportViewer1_Print);
            // 
            // tblCustomerTableAdapter
            // 
          
            // 
            // btnCheckInRep
            // 
            this.btnCheckInRep.Location = new System.Drawing.Point(12, 26);
            this.btnCheckInRep.Name = "btnCheckInRep";
            this.btnCheckInRep.Size = new System.Drawing.Size(204, 34);
            this.btnCheckInRep.TabIndex = 1;
            this.btnCheckInRep.Text = "Check In";
            this.btnCheckInRep.UseVisualStyleBackColor = true;
            // 
            // btnCheckOutRep
            // 
            this.btnCheckOutRep.Location = new System.Drawing.Point(256, 26);
            this.btnCheckOutRep.Name = "btnCheckOutRep";
            this.btnCheckOutRep.Size = new System.Drawing.Size(204, 34);
            this.btnCheckOutRep.TabIndex = 1;
            this.btnCheckOutRep.Text = "Check Out";
            this.btnCheckOutRep.UseVisualStyleBackColor = true;
            // 
            // btnCustomerRep
            // 
            this.btnCustomerRep.Location = new System.Drawing.Point(503, 26);
            this.btnCustomerRep.Name = "btnCustomerRep";
            this.btnCustomerRep.Size = new System.Drawing.Size(204, 34);
            this.btnCustomerRep.TabIndex = 1;
            this.btnCustomerRep.Text = "Customer";
            this.btnCustomerRep.UseVisualStyleBackColor = true;
            // 
            // btnStaffRep
            // 
            this.btnStaffRep.Location = new System.Drawing.Point(985, 26);
            this.btnStaffRep.Name = "btnStaffRep";
            this.btnStaffRep.Size = new System.Drawing.Size(204, 34);
            this.btnStaffRep.TabIndex = 1;
            this.btnStaffRep.Text = "Staff";
            this.btnStaffRep.UseVisualStyleBackColor = true;
            // 
            // btnRoomRep
            // 
            this.btnRoomRep.Location = new System.Drawing.Point(744, 26);
            this.btnRoomRep.Name = "btnRoomRep";
            this.btnRoomRep.Size = new System.Drawing.Size(204, 34);
            this.btnRoomRep.TabIndex = 1;
            this.btnRoomRep.Text = "Room";
            this.btnRoomRep.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 579);
            this.Controls.Add(this.btnRoomRep);
            this.Controls.Add(this.btnStaffRep);
            this.Controls.Add(this.btnCustomerRep);
            this.Controls.Add(this.btnCheckOutRep);
            this.Controls.Add(this.btnCheckInRep);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Report_FormClosed);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
          
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        
        private System.Windows.Forms.Button btnCheckInRep;
        private System.Windows.Forms.Button btnCheckOutRep;
        private System.Windows.Forms.Button btnCustomerRep;
        private System.Windows.Forms.Button btnStaffRep;
        private System.Windows.Forms.Button btnRoomRep;
    }
}