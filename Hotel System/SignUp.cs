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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();               
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "INSERT into tblStaff values (@u, @p )";
            cm.Parameters.AddWithValue("@u", txtUser.Text);
            cm.Parameters.AddWithValue("@p", txtPass.Text);          
            cm.ExecuteNonQuery();;
            con.Close();
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void TxtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
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
    }
}
