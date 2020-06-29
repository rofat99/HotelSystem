using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_System
{
    class _room
    {
        string _floor;
        string _roomnumber;
        string _type;
        string _price;
        string _description;
       
        SqlConnection con;
        SqlCommand cm;
        SqlDataReader dr;

        public _room(string _floor, string _roomnumber, string _type, string _price, string _description)
        {
            this._floor = _floor;
            this._roomnumber = _roomnumber;
            this._type = _type;
            this._price = _price;
            this._description = _description;
        }
        public _room() { }
        public string floor
        {
            set { _floor = value; }
            get { return _floor; }
        }
        public string roomnumber
        {
            set { _roomnumber = value; }
            get { return _roomnumber; }
        }
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        public string price
        {
            set { _price = value; }
            get { return _price; }
        }
        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        
        public void AddToList(ListView A)
        {
            ListViewItem N = new ListViewItem();
            N = A.Items.Add(_floor);
            N.SubItems.Add(_roomnumber);
            N.SubItems.Add(_type);
            N.SubItems.Add(_price);
            N.SubItems.Add(_description);
        }
        public void connect()
        {
            con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            cm = new SqlCommand();
            cm.Connection = con;
        }
        public void Save()
        {
            cm.CommandText = "Select * from tblRoom where roomnum='" +  _roomnumber + "'";
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Room number is existed");
                dr.Close();        
            }
            else
            {
                dr.Close();

                cm.CommandText = "Insert into tblRoom " +
                     "values('" + _floor + "','" + _roomnumber + "','" +
                    _type + "','" + _price + "','" + _description + "')";
                cm.ExecuteNonQuery();

                MessageBox.Show(" Added !");       
            }
         dr.Close();                     
        }
        public void updateRoom()
        {
           


            cm.CommandText = "UPDATE tblRoom SET floor=@f, type=@t, price=@p, description=@d Where roomnum=@r ";
            cm.Parameters.AddWithValue("@r", _roomnumber);
            cm.Parameters.AddWithValue("@f", _floor);
            cm.Parameters.AddWithValue("@t", _type);
            cm.Parameters.AddWithValue("@p", _price);
            cm.Parameters.AddWithValue("@d", _description);
            cm.ExecuteNonQuery();
            MessageBox.Show("updated");
            con.Close();
            
        }
        public void AddToCheckInCheckOut()
        {
            cm.CommandText = "Select * from tblCheckinout where roomnum='" + _roomnumber + "'";
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Room number is existed");
                dr.Close();
            }
            else
            {
                dr.Close();

                cm.CommandText = "Insert into tblCheckinout " +
                     "values('" + _roomnumber + "','" + "YES" + "')";
                cm.ExecuteNonQuery();

                MessageBox.Show(" added to check in-out !");
            }

            con.Close();
          
        }
        public void delete()
        {
            cm.CommandText = "DELETE FROM tblRoom WHERE roomnum=@r";
            cm.Parameters.AddWithValue("@r", _roomnumber);
            cm.ExecuteNonQuery();
            con.Close();
        }
    }
}
