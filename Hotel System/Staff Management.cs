using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class Staff_Management : Form
    {
        public Staff_Management()
        {
            InitializeComponent();
            ReadAllData();
            lstStaff.Hide();
            btnDelete.Hide();
        }
        public void admin()

        {
            
            if (txtPass.Text == "admin" && txtUser.Text == "admin")
            { ShowData(); }
            else
            {
                MessageBox.Show("Please enter correct username and password");
            }
        }
        public void ShowData()
        {
            lstStaff.Show();
            btnDelete.Show();
            lbadmin.Hide();
            txtPass.Hide();
            txtUser.Hide();
            panel1.Hide();
            panel2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            btnSignIn.Hide();
        }
        public void ReadAllData()
        {
            lstStaff.Clear();
            SqlConnection con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "Select * from tblStaff ";
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem N = new ListViewItem();
                N = lstStaff.Items.Add(dr[0].ToString());
                N.SubItems.Add(dr[1].ToString());
            }
            con.Close();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "DELETE FROM tblStaff where username=@u ";
            ListViewItem item = lstStaff.SelectedItems[0];
            cm.Parameters.AddWithValue("@u", item.SubItems[0].Text);
            cm.ExecuteNonQuery();
            
            con.Close();
            ReadAllData();
        }
        
       

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            admin();
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void TxtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }
    }
}
