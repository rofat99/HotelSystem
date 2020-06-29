using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class TitleAll : UserControl
    {
        public event EventHandler AfterBtnCheckInOutClick;
        public event EventHandler AfterBtnCustomerClick;
        public event EventHandler AfterBtnRoomClick;
        public event EventHandler DarkModeCheckInOutClick;
        public event EventHandler DarkModeCustomerClick;
        public event EventHandler DarkModeRoomClick;

        public bool Getvalue { set; get; }
        public TitleAll()
        {
            InitializeComponent();
            label2.Text = "Check In-Out";
            label2.Location = new System.Drawing.Point(670, 55);
            label2.BackColor = System.Drawing.Color.DarkCyan;
            label2.ForeColor = System.Drawing.Color.White;
            panel1.BackColor = System.Drawing.Color.DarkCyan;
        }
        public void darkMode()
        {
            label2.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            label2.ForeColor = System.Drawing.Color.White;
            panel1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        }
        public void OnAfterBtnCheckInOutClick()
        {
            if (AfterBtnCheckInOutClick != null) AfterBtnCheckInOutClick(null, null);
            label2.Text = "Check In-Out";
            label2.Location = new System.Drawing.Point(670, 55);
            label2.BackColor = System.Drawing.Color.DarkCyan;
            label2.ForeColor = System.Drawing.Color.White;
            panel1.BackColor = System.Drawing.Color.DarkCyan;
        }
        public void OnAfterBtnCustomerClick()
        {
            if (AfterBtnCustomerClick != null) AfterBtnCustomerClick(null, null);
            label2.Text = "Customer";
            label2.Location = new System.Drawing.Point(720,55);          
            label2.BackColor = System.Drawing.Color.DeepPink;
            label2.ForeColor = System.Drawing.Color.White;
            panel1.BackColor = System.Drawing.Color.DeepPink;
        }
        public void OnAfterBtnRoomClick()
        {
            if (AfterBtnRoomClick != null) AfterBtnRoomClick(null, null);
            label2.Text = "Room";
            label2.Location = new System.Drawing.Point(750, 55);
            label2.BackColor = System.Drawing.Color.DarkGreen;
            label2.ForeColor = System.Drawing.Color.White;
            panel1.BackColor = System.Drawing.Color.DarkGreen;
        }
        public void OnDarkModeCheckInOut()
        {
            if (DarkModeCheckInOutClick != null) DarkModeCheckInOutClick(null, null);
            label2.Text = "Check In-Out";   
            label2.Location = new System.Drawing.Point(670, 55);
            darkMode();
        }
        public void OnDarkModeCustomer()
        {
            if (DarkModeCustomerClick != null) DarkModeCustomerClick(null, null);
            label2.Text = "Customer";
            label2.Location = new System.Drawing.Point(720, 55);
            darkMode();
        }
        public void OnDarkModeRoom()
        {
            if (DarkModeRoomClick != null) DarkModeRoomClick(null, null);
            label2.Text = "Room";
            label2.Location = new System.Drawing.Point(750, 55);
            darkMode();
        }
    }
}
