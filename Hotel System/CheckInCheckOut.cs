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
    class CheckInCheckOut
    {
        string _floor;
        string _roomnumber;
        string _type;
        string _price;
        string _available;
        string _checkin;
        string _checkout;
        string _total;
        SqlConnection con;
        SqlCommand cm;
               
        public CheckInCheckOut() { }

        public void connect()
        {
            con = new SqlConnection("Data Source=Rofat;Initial Catalog=hotel;Integrated Security=True");
            con.Open();
            cm = new SqlCommand();
            cm.Connection = con;
        }
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
        public string available
        {
            set { _available = value; }
            get { return _available; }
        }
        public string checkin
        {
            set { _checkin = value; }
            get { return _checkin; }
        }
        public string checkout
        {
            set { _checkout = value; }
            get { return _checkout; }
        }
        public string total
        {
            set { _total = value; }
            get { return _total; }
        }
        public void AddToList(ListView A)
        {
            ListViewItem N = new ListViewItem();
            N = A.Items.Add(_floor);
            N.SubItems.Add(_roomnumber);
            N.SubItems.Add(_type);
            N.SubItems.Add(_price);
            N.SubItems.Add(_available);
        }
       
        public void update()
        {
            cm.CommandText = "UPDATE tblCheckinout SET available=@a Where roomnum=@r";
            cm.Parameters.AddWithValue("@r", _roomnumber);
            cm.Parameters.AddWithValue("@a", _available);
            //cm.Parameters.AddWithValue("@ci", _checkin);
            //cm.Parameters.AddWithValue("@co", _checkout);
            cm.ExecuteNonQuery();
            //MessageBox.Show("updated");
            con.Close();

        }
        public void addToCustomer()
        {
            cm.CommandText = "Insert into tblCustomer(roomnum,checkin,checkout,total) " +
                    "values( '" + _roomnumber + "','" + _checkin
                    + "','" + _checkout +"','"+_total+ "')";
            cm.ExecuteNonQuery();
            con.Close();
        }
    }
}
