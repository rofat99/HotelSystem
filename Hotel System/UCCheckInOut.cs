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
    public partial class UCCheckInOut : UserControl
    {
        public UCCheckInOut()
        {
            InitializeComponent();
            ReadAllData();
            
           


        }
        string room_number;
        string checkin;
        string checkout;
        double diff;
        public event EventHandler AfterBtnAddClick;
        public event EventHandler ClickCh;
        public event ErrorEventHandler DarkMode;
        public bool Getvalue { set; get; }     
        
        public void OnDarkMode()
        {
            if (DarkMode != null) DarkMode(null, null);
            this.BackColor = System.Drawing.Color.FromArgb(64,64,64);
            
        }
        public void OFFDarkMode()
        {
            if (DarkMode != null) DarkMode(null, null);
            this.BackColor = System.Drawing.Color.Cyan;
        }

        public void OnClickCh()
        {

            if (ClickCh != null) ClickCh(null, null);
            ClearList(lstCheckInCheckOut);
            ReadAllData();

        }
        public void OnAfterBtnAddClick()
        {
            if (AfterBtnAddClick != null) AfterBtnAddClick(null, null);
            this.Hide();
            
        }
        public void ReadAllData()
        {
            lstCheckInCheckOut.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "SELECT tblRoom.floor, tblCheckinout.roomnum, tblRoom.type, tblRoom.price, tblCheckinout.available FROM tblRoom INNER JOIN tblCheckinout ON tblRoom.roomnum=tblCheckinout.roomnum";
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CheckInCheckOut info = new CheckInCheckOut();
                info.floor = dr[0].ToString();
                info.roomnumber = dr[1].ToString();
                info.type = dr[2].ToString();
                info.price = dr[3].ToString();
                info.available = dr[4].ToString();
                info.AddToList(lstCheckInCheckOut);
                }                         
        }
        
        public void addCheckDate()
        {
            checkin = DTCheckIn.Value.ToShortDateString();
            checkout = DTCheckOut.Value.ToShortDateString();
            diff = Math.Ceiling((DTCheckOut.Value - DTCheckIn.Value).TotalDays);
           
        }
        public void CheckIn()
        {                        
            if (lstCheckInCheckOut.SelectedItems != null)
            {
                ListViewItem item = lstCheckInCheckOut.SelectedItems[0];

                CheckInCheckOut info = new CheckInCheckOut();
                info.floor = item.SubItems[0].Text;
                info.roomnumber = item.SubItems[1].Text;
                room_number = item.SubItems[1].Text;
                addCheckDate();
                info.type = item.SubItems[2].Text;
                info.price = item.SubItems[3].Text;
                info.checkin = checkin;
                info.checkout = checkout;
                info.available = "NO";
                double Uprice = double.Parse(item.SubItems[3].Text);
                info.total = Uprice *diff+"$";
                info.connect();
                info.update();
                info.connect();
                info.addToCustomer();

            }
            ReadAllData();
            //MessageBox.Show("Done");
        }
        public void CheckOut()
        {
            try
            {
                if (lstCheckInCheckOut.SelectedItems != null)
                {
                    ListViewItem item = lstCheckInCheckOut.SelectedItems[0];
                    CheckInCheckOut info = new CheckInCheckOut();                   
                    info.roomnumber = item.SubItems[1].Text;                   
                    info.available = "YES";
                    info.connect();
                    info.update();

                }
            }
            catch (Exception) { }
            ReadAllData();
        }
        public void ClearList(ListView A)
        {
            for (int i = A.Items.Count - 1; i >= 0; i--)
            {
                var item = A.Items[i];
                A.Items.Remove(item);
            }
        }
        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(lstCheckInCheckOut.SelectedItems[0].Text);
                ListViewItem item = lstCheckInCheckOut.SelectedItems[0];
                if (item.SubItems[4].Text == "NO")
                {
                    MessageBox.Show("Please select available room!");
                }
                else
                {
                    CheckIn();                                                          
                    OnAfterBtnAddClick();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select room");
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut(); 
        }

        private void BtnAvailable_Click(object sender, EventArgs e)
        {
            ClearList(lstCheckInCheckOut);
            ReadAllData();
            if (cmbFloor.Text != "")
            {
                for (int i = lstCheckInCheckOut.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstCheckInCheckOut.Items[i];
                    if (item.Text.ToLower().Contains(cmbFloor.Text.ToLower()))
                    {

                    }
                    else
                    {
                        lstCheckInCheckOut.Items.Remove(item);
                    }
                }
                if (lstCheckInCheckOut.SelectedItems.Count == 1)
                {
                    lstCheckInCheckOut.Focus();
                }
                cmbFloor.Text = null;
            }
            else if (cmbFloor.Text == "" && cmbType.Text != "")
            {
                for (int i = lstCheckInCheckOut.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstCheckInCheckOut.Items[i];
                    var sub = lstCheckInCheckOut.Items[i].SubItems[2];
                    if (sub.Text.ToLower().Contains(cmbType.Text.ToLower()))
                    {

                    }
                    else
                    {
                        lstCheckInCheckOut.Items.Remove(item);
                    }
                }
                if (lstCheckInCheckOut.SelectedItems.Count == 1)
                {
                    lstCheckInCheckOut.Focus();
                }
                cmbFloor.Text = null;
                cmbType.Text = null;
            }
            else
            {
                ClearList(lstCheckInCheckOut);
                ReadAllData();
            }
        }       
    }
}
