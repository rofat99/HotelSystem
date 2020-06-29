using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    class Customer_
    {
        string name_;
        string gender_;
        string country_;
        string phone_;
        string id_;
        string room_;
        string checkin_;
        string checkout_;
        string staff_;
        string temp_;
        string unitprice_;
        string total_;
       

        SqlConnection con;
        SqlCommand cm;
       
        public Customer_(string name_, string gender_, string country_, string phone_, string id_, string room_, string checkin_, string checkout_)
        {
            this.name_ = name_;
            this.gender_ = gender_;
            this.country_ = country_;
            this.phone_ = phone_;
            this.id_ = id_;
            this.room_ = room_;
            this.checkin_ = checkin_;
            this.checkout_ = checkout_;
        }
        public Customer_() { }
        public string name
        {
            set { name_ = value; }
            get { return name_; }
        }
        public string gender
        {
            set { gender_ = value; }
            get { return gender_; }
        }
        public string country
        {
            set { country_ = value; }
            get { return country_; }
        }
        public string phone
        {
            set { phone_ = value; }
            get { return phone_; }
        }
        public string id
        {
            set { id_ = value; }
            get { return id_; }
        }
        public string room
        {
            set { room_ = value; }
            get { return room_; }
        }
        public string checkin
        {
            set { checkin_ = value; }
            get { return checkin_; }
        }
        public string checkout
        {
            set { checkout_ = value; }
            get { return checkout_; }
        }
        
        public string staff
        {
            set { staff_ = value; }
            get { return staff_; }
        }
        public string unitprice
        {
            set { unitprice_ = value; }
            get { return unitprice_; }
        }
        public string total
        {
            set { total_ = value; }
            get { return total_; }
        }
        public string temp
        {
            set { temp_ = value; }
            get { return temp_; }
        }
        public void AddToList(ListView A)
        {
            ListViewItem N = new ListViewItem();
            N = A.Items.Add(name_);
            N.SubItems.Add(gender_);
            N.SubItems.Add(country_);          
            N.SubItems.Add(id_);
            N.SubItems.Add(phone_);
            N.SubItems.Add(room_);
            N.SubItems.Add(checkin_);
            N.SubItems.Add(checkout_);
            N.SubItems.Add(unitprice_);
            N.SubItems.Add(total_);
            N.SubItems.Add(staff_);
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
            cm.CommandText = "INSERT into tblCustomer values (@n, @g, @c,@i, @p,@r, @ci,@co,@s )";
            cm.Parameters.AddWithValue("@n", name_);
            cm.Parameters.AddWithValue("@g", gender_);
            cm.Parameters.AddWithValue("@c", country_);
            cm.Parameters.AddWithValue("@p", phone_);
            cm.Parameters.AddWithValue("@r", room_);
            cm.Parameters.AddWithValue("@ci", checkin_);
            cm.Parameters.AddWithValue("@co", checkout_);
            cm.Parameters.AddWithValue("@i", id_);
            cm.Parameters.AddWithValue("@s", staff_);
            cm.ExecuteNonQuery();
            MessageBox.Show("added!");
            con.Close();
        }
        public void update()
        {
            cm.CommandText = "UPDATE tblCustomer SET  name=@n, gender=@g, country=@c,id=@i ,phone=@p,roomnum=@r, checkin=@ci,checkout=@co ,staff=@s Where roomnum=@r ";
            cm.Parameters.AddWithValue("@n", name_);
            cm.Parameters.AddWithValue("@g", gender_);
            cm.Parameters.AddWithValue("@c", country_);
            cm.Parameters.AddWithValue("@p", phone_);
            cm.Parameters.AddWithValue("@r", room_);
            cm.Parameters.AddWithValue("@ci", checkin_);
            cm.Parameters.AddWithValue("@co", checkout_);
            cm.Parameters.AddWithValue("@i", id_);
            cm.Parameters.AddWithValue("@s", staff_);
            cm.ExecuteNonQuery();
            MessageBox.Show("updated");
            con.Close();
        }
        public void updateList()
        {
            cm.CommandText = "UPDATE tblCustomer SET  name=@n, gender=@g, country=@c,id=@i ,phone=@p,roomnum=@r, checkin=@ci,checkout=@co Where checkin=@ci and roomnum=@r";
            cm.Parameters.AddWithValue("@n", name_);
            cm.Parameters.AddWithValue("@g", gender_);
            cm.Parameters.AddWithValue("@c", country_);
            cm.Parameters.AddWithValue("@p", phone_);
            cm.Parameters.AddWithValue("@r", room_);
            cm.Parameters.AddWithValue("@ci", checkin_);
            cm.Parameters.AddWithValue("@co", checkout_);
            cm.Parameters.AddWithValue("@i", id_);
            cm.Parameters.AddWithValue("@s", staff_);
            cm.ExecuteNonQuery();
            MessageBox.Show("updated list");
            con.Close();
        }
       
    }
}
