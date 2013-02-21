﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace accomodationSoftware
{
    public class Db
    {
        public Db()
        {
            createDB();
        }
        public void createDB()
        {
            try
            {
                //SQLiteConnection.CreateFile("tourismus.db");

                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = String.Format("create table if not exists customer (cust_id integer not null primary key autoincrement, " +
                    " title varchar(10) NOT NULL, firstname varchar(30) NOT NULL, surname varchar(30) NOT NULL, " +
                    "birthday date NOT NULL, street varchar(40) NOT NULL, postcode varchar(10) NOT NULL, " +
                    "city varchar(50) DEFAULT NULL, country varchar(50) DEFAULT NULL, " +
                    "cardholder_name varchar(50) DEFAULT NULL, creditcard_number integer DEFAULT NULL, " +
                    "expdate_month varchar(20) NOT NULL, expdate_year varchar(4) NOT NULL)", "Adressen");
                command.ExecuteNonQuery();


                connection.Close();
            }catch(Exception e){
                System.Console.WriteLine(e.ToString());
            }
        }
        public void insertNewCustomer(Customer c)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();

                string myInsertQuery = 
                    "INSERT INTO customer (title, firstname, surname, birthday, street, postcode, city, country,"+
                    " cardholder_name, creditcard_number, expdate_month, expdate_year )";
                myInsertQuery += " VALUES('" + c.Title + "','" + c.Firstname + "','" + 
                    c.Surname + "','" + c.Birthday + "','" + 
                    c.Street + "','" + c.Postcode + "','" + c.City + "','" + c.Country + "','" + 
                    c.CardholderName + "','" + c.Cardnumber + "','" + c.Expiremonth + "','" + c.Expireyear + "')";


                SQLiteCommand command = new SQLiteCommand(connection);

                command.CommandText = myInsertQuery;
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("A new user" + c.Firstname + " " + c.Surname + "has been created!");
            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            }
            
        }
        public Accomodation searchAccomodation(int acc_id, int customer_id)
        {
            
            try
            {
                
                int accommodation_id = acc_id;
                int user_id = customer_id;
                Accomodation ac = null;
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand("select * from accommodations where acc_id =  " + accommodation_id, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
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
                        ac = new Accomodation(name, adress_city, adress_county, adress_postcode, adress_street, adress_number, description, picture_url);
                        //MessageBox.Show(string.Format("{0}, {1}, {2}", name, adress_city, picture_url));


                        
                    }

                }
                connection.Close();
                return ac;
                
            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            } 
            return null;
        }


        public ArrayList getCustomers()
        {
            ArrayList customerList = new ArrayList();
            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand("select * from customer", connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //title, firstname, surname, birthday, street, postcode, city, country, cardholder_name, creditcard_number, expdate_month, expdate_year


String title = reader.GetString(reader.GetOrdinal("title"));
String surname = reader.GetString(reader.GetOrdinal("surname"));
String firstname = reader.GetString(reader.GetOrdinal("firstname"));
String birthday = reader.GetString(reader.GetOrdinal("birthday"));
String street = reader.GetString(reader.GetOrdinal("street"));
String postcode = reader.GetString(reader.GetOrdinal("postcode"));
String city = reader.GetString(reader.GetOrdinal("city"));
String country = reader.GetString(reader.GetOrdinal("country"));
String cardholder = reader.GetString(reader.GetOrdinal("cardholder_name"));
int creditcardnumber = reader.GetInt32(reader.GetOrdinal("creditcard_number"));
String expdatemonth = reader.GetString(reader.GetOrdinal("expdate_month"));
String expdateyear = reader.GetString(reader.GetOrdinal("expdate_year"));

Customer c = new Customer(title, surname, firstname, birthday, street, postcode, city, country, cardholder, "" + creditcardnumber, expdatemonth, expdateyear);
                        c.custi_id = reader.GetInt32(reader.GetOrdinal("cust_id"));
                        customerList.Add(c);

                    }

                }
                connection.Close();

                return customerList;
         }

        



    }
}
