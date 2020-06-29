using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.tblCustomer' table. You can move, or remove it, as needed.
          
            this.reportViewer1.RefreshReport();
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void ReportViewer1_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {

        }
    }
}
