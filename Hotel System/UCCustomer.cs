using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Hotel_System
{
    public partial class UCCustomer : UserControl
    {
        string room_number_;
        string staff_name;
        SqlConnection con;
        SqlCommand cm;
        SqlDataReader dr;
        public event EventHandler senddatatoCus;
        public event EventHandler refreshCIO;
        public event ErrorEventHandler sendstaffname;
        public event ErrorEventHandler DarkMode;
        public UCCustomer()
        {
            InitializeComponent();
            ReadAllData();          
            btnOff();
        }
        private void btnOff()
        {
            btnCancel.Enabled = false;
            btnDone.Enabled = false;
            btnCancel.ForeColor = System.Drawing.Color.Gray;
            btnDone.ForeColor = System.Drawing.Color.Gray;
            btnCancel.BackColor = System.Drawing.Color.White;
            btnDone.BackColor = System.Drawing.Color.White;
        }
        private void btnOn()
        {
            btnDone.Enabled = true;
            btnCancel.Enabled = true;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnDone.ForeColor = System.Drawing.Color.White;
            btnCancel.BackColor = System.Drawing.Color.Red;
            btnDone.BackColor = System.Drawing.Color.Blue;
        }
        public void OnDarkMode()
        {
            if (DarkMode != null) DarkMode(null, null);
            this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }
        public void OFFDarkMode()
        {
            if (DarkMode != null) DarkMode(null, null);
            this.BackColor = System.Drawing.Color.Fuchsia;
        }
        public void SendtoCus()
        {
            if (senddatatoCus != null) senddatatoCus(null, null);
            con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "Select roomnum,checkin,checkout,phone from tblCustomer";
            dr = cm.ExecuteReader();
            while (dr.Read())
            {   
                if(dr[3].ToString()=="")
                {
                    txtRoom.Text = dr[0].ToString();
                    txtCheckIn.Text = dr[1].ToString();
                    txtCheckOut.Text = dr[2].ToString();

                }
               
               
                          
            }
            dr.Close();
            con.Close();
        }
        public void sendstaff(string a)
        {
            if (sendstaffname != null) sendstaffname(null, null);
            staff_name = a;
        }
        public void txtColorBlack()
        {
            changecolor(txtFirstName);
            changecolor(txtLastName);
            changecolor(txtCountry);
            changecolor(txtID);
            changecolor(txtPhone);
            changecolor(txtRoom);
            changecolor(txtCheckIn);
            changecolor(txtCheckOut);           
        }
        public void txtColorGrey()
        {
            changecolor1(txtFirstName);
            changecolor1(txtLastName);
            changecolor1(txtCountry);
            changecolor1(txtID);
            changecolor1(txtPhone);
            changecolor1(txtRoom);
            changecolor1(txtCheckIn);
            changecolor1(txtCheckOut);
        }
        public void Editlist()
        {
            if (lstCustomer.SelectedItems!=null)
            {
                try
                {
                    ListViewItem item = lstCustomer.SelectedItems[0];
                    string a = item.SubItems[0].Text;
                    string[] b = a.Split(' ');
                    txtFirstName.Text = b[0];
                    txtLastName.Text = b[1];
                    if (item.SubItems[1].Text == "Male")
                    {
                        btnMale.Checked = true;
                    }
                    else
                    {
                        btnFemale.Checked = true;
                    }
                    txtCountry.Text = item.SubItems[2].Text;
                    txtPhone.Text = item.SubItems[3].Text;
                    txtID.Text = item.SubItems[4].Text;
                    txtRoom.Text = item.SubItems[5].Text;
                    room_number_ = item.SubItems[5].Text;
                    txtCheckIn.Text = item.SubItems[6].Text;
                    txtCheckOut.Text = item.SubItems[7].Text;
                    staff_name = item.SubItems[8].Text;
                }
                catch (Exception)
                {

                }

            }
            txtColorBlack();

            txtCheckIn.Enabled = false;
            btnDone.Text = "Update";
            btnCancel.Text = "Cancel";
        }
        public void ReadAllData()
        {
            if (refreshCIO != null) refreshCIO(null, null);
            lstCustomer.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "Select tblCustomer.* , tblRoom.price from tblCustomer INNER JOIN tblRoom ON tblRoom.roomnum=tblCustomer.roomnum ";
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Customer_ info = new Customer_();
                info.name = dr[0].ToString();
                info.gender = dr[1].ToString();
                info.country = dr[2].ToString();
                info.id = dr[3].ToString();
                info.phone = dr[4].ToString();

                info.room = dr[5].ToString();
                info.checkin = dr[6].ToString();
                info.checkout = dr[7].ToString();
                info.unitprice = dr[10].ToString();
                info.total = dr[8].ToString();
                info.staff = dr[9].ToString(); ;
                info.AddToList(lstCustomer);
            }
            
        }

       
        public void clearTextbox()
        {
            btnFemale.Checked = false;
            btnMale.Checked = false;
            txtFirstName.Text = "First Name";
            txtLastName.Text = "Last Name";
            txtCountry.Text = "Country";
            txtID.Text = "Identity-card or Passport Number";
            txtPhone.Text = "Phone Number";
            txtRoom.Text = "Room Number";
            txtCheckIn.Text = "Check In";
            txtCheckOut.Text = "Check Out";
            txtColorGrey();
        }        
        public void AddItem()
        {           
            Customer_ info = new Customer_();
            info.name = txtFirstName.Text + " " + txtLastName.Text;
            if (btnMale.Checked == true)
            {
                info.gender = "Male";
            }
            else
            info.gender = "Female";
            info.country = txtCountry.Text;
            info.phone = txtPhone.Text;
            info.id = txtID.Text;
            info.room = txtRoom.Text;
            info.checkin = txtCheckIn.Text;
            info.checkout = txtCheckOut.Text;
            info.staff = staff_name;          
            info.connect();
            info.update();
        }
       
       
        public void changecolor(TextBox A)
        {
            A.ForeColor = System.Drawing.Color.Black;
        }
        public void changecolor1(TextBox A)
        {
            A.ForeColor = System.Drawing.Color.Gray;
        }
        public void textBoxClick(TextBox A, string B)
        {
            if (A.Text == B)
            {
                A.Text = null;
                A.ForeColor = System.Drawing.Color.Black;
            }
            else
                A.ForeColor = System.Drawing.Color.Black;
            btnOn();
        }
        private void btnnameupdate()
        {
            if (btnDone.Text == "Update")
            {
                btnOn();
            }
            else
            {
                btnDone.Text = "Done";
            }
        }
        private void BtnDone_Click(object sender, EventArgs e)
        {
            if (btnDone.Text == "Done")
            {
                AddItem();
                ReadAllData();
                clearTextbox();
            }
            else
            {
                
                    Customer_ info = new Customer_();
                    info.name = txtFirstName.Text + " " + txtLastName.Text;
                    if (btnMale.Checked == true)
                    {
                        info.gender = "Male";
                    }
                    else
                        info.gender = "Female";
                    info.country = txtCountry.Text;
                    info.phone = txtPhone.Text;
                    info.id = txtID.Text;
                    info.room = txtRoom.Text;
                    info.checkin = txtCheckIn.Text;
                    info.checkout = txtCheckOut.Text;
                    info.staff = staff_name;
                    info.connect();
                    info.updateList();
                btnOff();
                ReadAllData();
                clearTextbox();
            }           
        }
       
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text == "Cancel")
            {
                btnOff();
                clearTextbox();
                btnDone.Text = "Done";
            }
            else
            {
                if (lstCustomer.SelectedItems != null)
                {
                    for (int i = lstCustomer.Items.Count - 1; i >= 0; i--)
                    {
                        if (lstCustomer.Items[i].Selected)
                        {
                            lstCustomer.Items[i].Remove();

                        }
                    }
                }
                ReadAllData();
                btnDone.Text = "Done";
            }
            
        }

        private void LstCustomer_DoubleClick(object sender, EventArgs e)
        {
            Editlist();
            btnOff();
        }

        private void TxtRoom_Click(object sender, EventArgs e)
        {
            textBoxClick(txtRoom, "Room Number");

            btnnameupdate();
        }

        private void TxtCheckIn_Click(object sender, EventArgs e)
        {
            textBoxClick(txtCheckIn, "Check In");
            btnnameupdate();
        }

        private void TxtCheckOut_Click(object sender, EventArgs e)
        {
            textBoxClick(txtCheckOut,"Check Out");
            btnnameupdate();
        }

        private void LstCustomer_Click(object sender, EventArgs e)
        {
            btnDone.Text = "Edit";
            btnCancel.Text = "Delete";
            btnOn();
        }

        private void UCCustomer_Click(object sender, EventArgs e)
        {
            if (btnDone.Text == "Update")
            {
            }
            else { }
            btnCancel.Text = "Cancel";
            btnDone.Text = "Done";
        }

        private void TxtPhone_Click(object sender, EventArgs e)
        {
            textBoxClick(txtPhone, "Phone Number");
            btnnameupdate();
        }
        private void TxtID_Click(object sender, EventArgs e)
        {
            textBoxClick(txtID, "Identity-card or Passport Number");
            btnnameupdate();
        }
        private void TxtFirstName_Click(object sender, EventArgs e)
        {
            textBoxClick(txtFirstName, "First Name");
            btnnameupdate();
        }
        private void TxtLastName_Click(object sender, EventArgs e)
        {
            textBoxClick(txtLastName, "Last Name");
            btnnameupdate();
        }
        private void TxtCountry_Click(object sender, EventArgs e)
        {
            textBoxClick(txtCountry, "Country");
            btnnameupdate();
        }

        private void BtnMale_Click(object sender, EventArgs e)
        {
            btnnameupdate();
            
        }

        private void BtnFemale_Click(object sender, EventArgs e)
        {
            btnnameupdate();
        }
    }
}
