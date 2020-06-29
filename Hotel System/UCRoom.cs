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
    public partial class UCRoom : UserControl
    {
        public event ErrorEventHandler DarkMode;
        public UCRoom()
        {
            InitializeComponent();
            btnADD.Enabled = false;
            btnADD.BackColor = System.Drawing.Color.White;
            Disable_Input();
            ReadAllData();
        }
        public void OnDarkMode()
        {
            if (DarkMode != null) DarkMode(null, null);
            this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }
        public void OFFDarkMode()
        {
            if (DarkMode != null) DarkMode(null, null);
            this.BackColor = System.Drawing.Color.LightGreen;
        }
        public void Disable_Input()
        {
            txtRoom.Enabled = false;
            txtPrice.Enabled = false;
            txtDescription.Enabled = false;
            cmbFloor.Enabled = false;
            cmbType.Enabled = false;
        }
        public void Enable_Input()
        {
            txtRoom.Enabled = true;
            txtPrice.Enabled = true;
            txtDescription.Enabled = true;
            cmbFloor.Enabled = true;
            cmbType.Enabled = true;
        }
        public void ReadAllData()
        {
            lstRoom.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "Select * from tblRoom ";
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                _room info = new _room();
                info.floor = dr[0].ToString();
                info.roomnumber = dr[1].ToString();
                info.type = dr[2].ToString();
                info.price = dr[3].ToString();
                info.description = dr[4].ToString();
                info.AddToList(lstRoom);
            }           
        }
        public void clearTextbox()
        {
            cmbFloor.Text = null;
            cmbType.Text = null;
            txtRoom.Text = null;
            txtPrice.Text = null;
            txtDescription.Text = null;
        }
       
       
        public void AddItem()
        {
            _room info = new _room();
            info.floor = cmbFloor.Text;
            info.roomnumber = txtRoom.Text;
            info.type = cmbType.Text;
            info.price = txtPrice.Text;
            info.description = txtDescription.Text;        
            info.connect();
            
            if (btnADD.Text == "ADD")
            {
                info.Save();
                info.AddToCheckInCheckOut();
            }
            else
            {
                info.updateRoom();
            }
            clearTextbox();
            btnADD.Enabled = false;
            btnNew.Text = "NEW";
            btnADD.BackColor = System.Drawing.Color.White;
            ReadAllData();
        }
        public void EditList()
        {
            Enable_Input();
            btnNew.Text = "CANCEL";
            btnADD.Text = "UPDATE";
            btnSearch.BackColor = System.Drawing.Color.White;
            btnSearch.Enabled = false;
            btnADD.BackColor = System.Drawing.Color.Blue;
            btnADD.ForeColor = System.Drawing.Color.White;
            btnADD.Enabled = true;
            cmbFloor.Enabled = false;
            txtRoom.Enabled = false;
            if (lstRoom.SelectedItems != null)
            {
                ListViewItem item = lstRoom.SelectedItems[0];
                cmbFloor.Text = item.SubItems[0].Text;
                txtRoom.Text = item.SubItems[1].Text;
                cmbType.Text = item.SubItems[2].Text;
                txtPrice.Text = item.SubItems[3].Text;
                txtDescription.Text = item.SubItems[4].Text;
            }
        }
        public void ClearList(ListView A)
        {
            for (int i = A.Items.Count - 1; i >= 0; i--)
            {
                var item = A.Items[i];
                A.Items.Remove(item);
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {

            if (btnNew.Text == "NEW")
            {
                clearTextbox();
                cmbFloor.Focus();
                btnADD.Enabled = true;
                btnADD.BackColor = System.Drawing.Color.DarkGreen;
                btnADD.ForeColor = System.Drawing.Color.White;
                btnSearch.BackColor = System.Drawing.Color.White;
                btnSearch.Enabled = false;
                Enable_Input();
                btnNew.Text = "CANCEL";
            }
            else if (btnNew.Text == "CANCEL")
            {
                btnNew.Text = "NEW";
                btnADD.Text = "ADD";
                btnADD.Enabled = false;
                btnSearch.Enabled = true;
                btnADD.ForeColor = System.Drawing.Color.Gray;
                btnADD.BackColor = System.Drawing.Color.White;
                btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
                clearTextbox();
                Disable_Input();

            }
            else if (btnNew.Text == "CANCEL SEARCH")
            {
                btnNew.Text = "NEW";
                btnADD.Enabled = false;
                btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
                btnADD.BackColor = System.Drawing.Color.White;
                btnADD.ForeColor = System.Drawing.Color.Gray;
                clearTextbox();
                ReadAllData();
            }
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            if (btnADD.Text == "ADD")
            {
                AddItem();
                Disable_Input();                              
            }
            if (btnADD.Text == "UPDATE")
            {             
                cmbFloor.Enabled = true;
                txtRoom.Enabled = true;
                AddItem();              
                btnADD.Text = "ADD";
                Disable_Input();
            }
        }

        private void LstRoom_DoubleClick(object sender, EventArgs e)
        {
            EditList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (lstRoom.SelectedItems != null)
            {
                for (int i = lstRoom.Items.Count - 1; i >= 0; i--)
                {
                    if (lstRoom.Items[i].Selected)
                    {
                        if (MessageBox.Show( "Do you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _room info = new _room();
                            info.roomnumber = lstRoom.Items[i].SubItems[1].Text;
                            info.connect();
                            info.delete();
                            ReadAllData();
                            MessageBox.Show("Deleted!");
                        }

                        else

                        {
                            //do something if NO
                        }
                       
                    }
                }
            }
           
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditList();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            for (int i = lstRoom.Items.Count - 1; i >= 0; i--)
            {
                var item = lstRoom.Items[i];
                lstRoom.Items.Remove(item);
            }
            ReadAllData();
            Enable_Input();
            btnSearch.BackColor = System.Drawing.Color.DarkBlue;
            if (cmbFloor.Text != "")
            {
                for (int i = lstRoom.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstRoom.Items[i];
                    if (item.Text.ToLower().Contains(cmbFloor.Text.ToLower()))
                    {
                    }
                    else
                    {
                        lstRoom.Items.Remove(item);
                    }
                }
                if (lstRoom.SelectedItems.Count == 1)
                {
                    lstRoom.Focus();
                }
            }
            else
            {
                ClearList(lstRoom);
                btnNew.Text = "CANCEL SEARCH";
            }
        }

        private void focusOn(KeyEventArgs e,TextBox tb, ComboBox cb, Button bt)
        {
            if (tb != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    tb.Focus();                  
                }
            }
            else
            {
            }
            if (cb != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cb.Focus();
                }
            }
            else
            {
            }
            if (bt != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    bt.Focus();
                }
            }
            else
            {
            }       
        }

        private void CmbFloor_KeyUp(object sender, KeyEventArgs e)
        {
            focusOn(e, txtRoom, null, null);
        }

        private void TxtRoom_KeyUp(object sender, KeyEventArgs e)
        {
            focusOn(e, null, cmbType,null);
        }

        private void CmbType_KeyUp(object sender, KeyEventArgs e)
        {
            focusOn(e, txtPrice, null, null);
        }

        private void TxtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            focusOn(e, txtDescription, null, null);
        }

        private void TxtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            focusOn(e, null, null, btnADD);
        }
    }
}
