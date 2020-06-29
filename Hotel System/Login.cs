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
    
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            txtPass.Text = "Password";
        }
        public void check(string a,string b)
        {
            SqlConnection con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "Select * from tblStaff ";
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                if (a == dr[0].ToString() && b == dr[1].ToString())
                {
                    this.Hide();
                    MainIU frm = new MainIU(a);
                    frm.Show();
                    return;
                }
                else
                {
                }                
            }          
            MessageBox.Show("Incorrect username or password ! please try again");
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            check(txtUser.Text, txtPass.Text);                      
        }

        private void TxtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.Show();
            this.Hide();
        }
        private void TxtPass_KeyUp(object sender, KeyEventArgs e)
        {
            //pass += txtPass.Text;
            //MessageBox.Show(pass);
            //txtPass.Clear();
            //s += "*";
            //txtPass.Text = s;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Management frm = new Staff_Management();
            frm.Show();
        }
    }
}
