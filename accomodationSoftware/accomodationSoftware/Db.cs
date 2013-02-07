using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    class Db
    {
        public Db()
        {

        }
        public void createDB()
        {
            //SQLiteConnection.CreateFile("tourismus.db");

            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = String.Format("create table customer (cust_id integer not null primary key autoincrement, "+
                " title varchar(10) NOT NULL, firstname varchar(30) NOT NULL, surname varchar(30) NOT NULL, "+
                "birthday date NOT NULL, street varchar(40) NOT NULL, postcode varchar(10) NOT NULL, "+
                "city varchar(50) DEFAULT NULL, country varchar(50) DEFAULT NULL, "+
                "cardholder_name varchar(50) DEFAULT NULL, creditcard_number int(11) DEFAULT NULL, "+
                "expdate_month varchar(20) NOT NULL, expdate_year varchar(4) NOT NULL)", "Adressen");
            command.ExecuteNonQuery();


            connection.Close();  
        }
        public void insertNewCustomer(string title, string firstname, string surname, string byear, 
            string bmonth, string bday, string street, string postcode, string city, string country, 
            string cardholder, string creditnum, string expiremonth, string expireyear)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();

                string myInsertQuery = 
                    "INSERT INTO customer (title, firstname, surname, birthday, street, postcode, city, country,"+
                    " cardholder_name, creditcard_number, expdate_month, expdate_year )";
                myInsertQuery += " VALUES('" + title + "','" + firstname + "','" + 
                    surname + "','" + byear + "-" + bmonth + "-" + bday + "','" + 
                    street + "','" + postcode + "','" + city + "','" + country + "','" + 
                    cardholder + "','" + creditnum + "','" + expiremonth + "','" + expireyear + "')";


                SQLiteCommand command = new SQLiteCommand(connection);

                command.CommandText = myInsertQuery;
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            }
        }
        public void searchAccomodation()
        {
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
                Console.WriteLine(et.ToString());
            }
        }
    }
}
