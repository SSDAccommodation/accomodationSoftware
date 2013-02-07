//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;
using accomodationSoftware;

namespace addCustomer
{
    public partial class accomodationInfo : Form
    {
        public int accommodation_id { get; set; }
        public int user_id { get; set; }


        public accomodationInfo()
        {
            InitializeComponent();
            /*
            try
            {

                int accId = 1;

                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand("select * from accommodations where acc_id =  " + accId, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {
                        string name = reader.GetString(reader.GetOrdinal("acc_name"));
                        string adress_city = reader.GetString(reader.GetOrdinal("acc_adress_city"));
                        string adress_county = reader.GetString(reader.GetOrdinal("acc_adress_county"));
                        string adress_postcode = reader.GetString(reader.GetOrdinal("acc_adress_postcode"));
                        string adress_street = reader.GetString(reader.GetOrdinal("acc_adress_street"));
                        string adress_number = reader.GetString(reader.GetOrdinal("acc_adress_number"));
                        string description = reader.GetString(reader.GetOrdinal("acc_description"));
                        string picture_url = reader.GetString(reader.GetOrdinal("acc_picture_url"));
                        //MessageBox.Show(string.Format("{0}, {1}, {2}", name, adress_city, picture_url));
                        accommodation_id = accId;
                    // Insert real user here
                        user_id = 1;

                        //Daten in form einfügen
                        l_hotelname.Text = name;
                        rtb_address.Text = name + "\n" + adress_street + " " + adress_number + "\n" + adress_city + "\n" + adress_postcode + "\n" + adress_county;
                        rtb_description.Text = description;
                        pb_hotel.Load("pictures\\" + picture_url);
                    }

                connection.Close();
                
            }
            catch (Exception et)
            {
                MessageBox.Show(et.ToString());
            }*/
            
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_bookingDetails_Click(object sender, EventArgs e)
        {
            bookingDetails bookForm = new bookingDetails(accommodation_id, user_id);
            bookForm.Show();
        }

    }
}
