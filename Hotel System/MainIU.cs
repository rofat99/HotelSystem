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
    public partial class MainIU : Form
    {
        public string staff;
        public Boolean a;
        public MainIU( string a)
        {
            InitializeComponent();
            
            this.MinimumSize = new Size(1450, 780);
            this.MaximumSize = new Size(1450, 780);
            clicked_room.Hide();
            clicked_customer.Hide();
            txtUser.Text = a;
            staff = a;
          
        }
        public MainIU()
        {
            InitializeComponent();

            this.MinimumSize = new Size(1450, 780);
            this.MaximumSize = new Size(1450, 780);
            clicked_room.Hide();
            clicked_customer.Hide();            
        }
        private void DarkModeOn(Button A,Panel B)
        {
            
            A.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            B.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnInfo.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnMinimize.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnExit.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);

        }
        private void DarkModeOff(Button A, Panel B)
        {
            btnInfo.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnMinimize.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnExit.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        }
        private void BtnIntCheckInOut_Click(object sender, EventArgs e)
        {

            ucCheckInOut1.ReadAllData();
            ucCustomer1.Hide();
            ucRoom1.Hide();
            ucCheckInOut1.Show();
            ucCheckInOut1.OnClickCh();
            clicked_checkinout.Show();
            clicked_customer.Hide();
            clicked_room.Hide();
            if (a == true)
            {
                titleAll1.OnDarkModeCheckInOut();
                ucCheckInOut1.OnDarkMode();
                DarkModeOn(btnIntCheckInOut,clicked_checkinout);
            }
            else
            {
                titleAll1.OnAfterBtnCheckInOutClick();
                btnIntCheckInOut.BackColor = System.Drawing.Color.MediumTurquoise;
                clicked_checkinout.BackColor = System.Drawing.Color.Teal;
            }

        }
       
        private void BtnIntCustomer_Click(object sender, EventArgs e)
        {
            ucCustomer1.ReadAllData();
            ucCheckInOut1.Hide();
            ucRoom1.Hide();
            ucCustomer1.Show();
            ucCustomer1.Refresh();
            //ucCustomer1.sendstaff(txtUser.Text);                        
            clicked_customer.Show();
            clicked_checkinout.Hide();
            clicked_room.Hide();
            if (a == true)
            {
                titleAll1.OnDarkModeCustomer();
                ucCustomer1.OnDarkMode();
                DarkModeOn(btnIntCustomer, clicked_customer);
            }
            else
            {
                titleAll1.OnAfterBtnCustomerClick();
                btnIntCustomer.BackColor = System.Drawing.Color.Magenta;
                clicked_customer.BackColor = System.Drawing.Color.MediumVioletRed;
            }
        }

        private void BtnIntRoom_Click(object sender, EventArgs e)
        {
            ucRoom1.ReadAllData();
            ucRoom1.Show();
            ucRoom1.Refresh();
            ucCustomer1.Hide();
            ucCheckInOut1.Hide();

            clicked_checkinout.Hide();
            clicked_customer.Hide();
            clicked_room.Show();
            if (a == true)
            {
                titleAll1.OnDarkModeRoom();
                ucRoom1.OnDarkMode();
                DarkModeOn(btnIntRoom, clicked_room);
            }
            else
            {
                titleAll1.OnAfterBtnRoomClick();
                btnIntRoom.BackColor = System.Drawing.Color.MediumSpringGreen;
                clicked_room.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
        }

        private void BtnIntSignOut_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UcCheckInOut1_ClickCh(object sender, EventArgs e)
        {
         //   ucCheckInOut1.OnClickCh();                
        }

        private void UcCheckInOut1_AfterBtnAddClick(object sender, EventArgs e)
        {
            ucCustomer1.sendstaff(txtUser.Text);
            ucCustomer1.SendtoCus();                       
            ucCheckInOut1.Hide();
            ucRoom1.Hide();
            ucCustomer1.Show();
            ucCustomer1.Refresh();
            clicked_customer.Show();
            clicked_checkinout.Hide();
            clicked_room.Hide();
            if (a == true)
            {
                titleAll1.OnDarkModeCustomer();
            }
            else
                titleAll1.OnAfterBtnCustomerClick();
        }

        private void UcCustomer1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDarkMode_Click(object sender, EventArgs e)
        {
            a = true;
            
            
            ucRoom1.OnDarkMode();            
            ucCustomer1.OnDarkMode();         
            ucCheckInOut1.OnDarkMode();
            btnIntCheckInOut.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            btnIntCustomer.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            btnIntRoom.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            clicked_checkinout.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            clicked_customer.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            clicked_room.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnIntReport.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnSignOut.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
            btnExit.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnMinimize.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnInfo.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            btnDarkMode.ForeColor = System.Drawing.Color.White;
            btnDarkMode.Enabled = false;
            btnColorful.Enabled = true;
            
            if (clicked_checkinout.Visible==true)
            {
                titleAll1.OnDarkModeCheckInOut();
            }
            else if (clicked_customer.Visible==true)
            {
                titleAll1.OnDarkModeCustomer();
            }
            else if(clicked_room.Visible==true)
            {        
                titleAll1.OnDarkModeRoom();
            }
        }

        private void BtnColorful_Click(object sender, EventArgs e)
        {
            btnDarkMode.Enabled = true;
            a = false;
           
           
            titleAll1.OnAfterBtnRoomClick();
            titleAll1.OnAfterBtnCustomerClick();
            titleAll1.OnAfterBtnCheckInOutClick();
            ucCheckInOut1.OFFDarkMode();
            ucCustomer1.OFFDarkMode();
            ucRoom1.OFFDarkMode();
            btnIntCheckInOut.BackColor = System.Drawing.Color.MediumTurquoise;
            clicked_checkinout.BackColor = System.Drawing.Color.Teal;
            btnIntCustomer.BackColor = System.Drawing.Color.Magenta;
            clicked_customer.BackColor = System.Drawing.Color.MediumVioletRed;
            btnIntRoom.BackColor = System.Drawing.Color.MediumSpringGreen;
            clicked_room.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnIntReport.BackColor = System.Drawing.Color.MediumPurple;
            btnSignOut.BackColor = System.Drawing.Color.Crimson;
            btnColorful.Enabled = false;
            if (clicked_checkinout.Visible == true)
            {
                titleAll1.OnAfterBtnCheckInOutClick();
            }
            else if (clicked_customer.Visible == true)
            {
                titleAll1.OnAfterBtnCustomerClick();
            }
            else if (clicked_room.Visible == true)
            {
                titleAll1.OnAfterBtnRoomClick();
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Group 5 \n 1.Sales Arofat \n 2.Shuk Sopheap \n 3.Seang Chanviwat \n 4.Nop Samnang \n 5.Chan Penh \n 6.Doung Kimseng \n 7.Chum KotUdom \n 8.Chhay Sereythornin");
        }

        private void BtnIntReport_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
