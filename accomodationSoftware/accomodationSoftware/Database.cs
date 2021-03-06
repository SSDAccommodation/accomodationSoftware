﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace accomodationSoftware
{
    public class Database
    {

        public Log logger { get; set; }

        public Database()
        {
            if (!File.Exists("tourismus.db"))
                createDB();
            logger = new Log();
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
                    "expdate_month varchar(20) NOT NULL, expdate_year varchar(4) NOT NULL)");// , "Adressen"
                command.ExecuteNonQuery();
                command.CommandText = String.Format("create table if not exists accommodations (acc_id integer primary key autoincrement," +
                    " acc_name varchar(40) not null, acc_adress_city varchar(50) not null, "+
                    "acc_adress_county varchar(50) not null, acc_adress_postcode varchar(6) not null, "+
                    "acc_adress_street varchar(50) not null,acc_adress_number varchar(5) not null, "+
                    "acc_description  varchar(800) not null,acc_picture_url varchar(80) not null, acco_feedback varchar(800) not null)");
                command.ExecuteNonQuery();
                command.CommandText = String.Format("create table if not exists rooms (room_id integer primary key autoincrement, "+
                    "room_number integer not null, acc_id integer references accommodations not null,bedcount integer not null)");
                command.ExecuteNonQuery();
                command.CommandText = String.Format("create table if not exists bookings(book_id integer primary key autoincrement, "+
                    "acc_id integer references accommodations not null, room_id integer references rooms, "+
                    "room_number integer references rooms, cust_id integer references customer, "+
                    "start_date date not null, end_date date not null)");
                command.ExecuteNonQuery();
                command.CommandText = String.Format("create table if not exists closedaccounts (cust_id integer not null primary key, " +
                    " title varchar(10) NOT NULL, firstname varchar(30) NOT NULL, surname varchar(30) NOT NULL, " +
                    "birthday date NOT NULL, street varchar(40) NOT NULL, postcode varchar(10) NOT NULL, " +
                    "city varchar(50) DEFAULT NULL, country varchar(50) DEFAULT NULL, " +
                    "cardholder_name varchar(50) DEFAULT NULL, creditcard_number integer DEFAULT NULL, " +
                    "expdate_month varchar(20) NOT NULL, expdate_year varchar(4) NOT NULL)");
                command.ExecuteNonQuery();
                command.CommandText = String.Format("CREATE TABLE IF NOT EXISTS facility (fac_id integer NOT NULL primary key autoincrement,"+
                    "name varchar(100) NOT NULL, type varchar(50) NOT NULL, adress_city varchar(300) NOT NULL, "+
                    "adress_country varchar(50) NOT NULL, adress_postcode varchar(6) NOT NULL,"+
                    " adress_street varchar(50) NOT NULL, adress_number varchar(5) NOT NULL, "+
                    "information varchar(800), feedback varchar(800) not null, picture_url varchar(80) not null )");
                command.ExecuteNonQuery();
                connection.Close();
             
                insertTestValues();
            }catch(Exception e){
                System.Console.WriteLine(e.ToString());
            }
        }
        public void insertTestValues()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);
            //insert accomodations
            command.CommandText = String.Format("insert into accommodations ( acc_name, acc_adress_city, acc_adress_county, " +
                "acc_adress_postcode, acc_adress_street, acc_adress_number, acc_description, " +
                "acc_picture_url, acco_feedback) values ('super hotel', 'southampton', 'hampshire', 'SO13', " +
                "'Main Street', '4a', 'A very neat hotel', 'hotel1.jpg','');");
            command.ExecuteNonQuery();
            //insert accomodations
            command.CommandText = String.Format("insert into accommodations ( acc_name, acc_adress_city, acc_adress_county, "+
                "acc_adress_postcode, acc_adress_street, acc_adress_number, acc_description, " +
                "acc_picture_url, acco_feedback) values ('mega hotel', 'southampton', 'hampshire', 'SO13', " +
                "'Main Street', '45', 'One of the nicest hotels with lots of rooms', 'hotel2.jpg','');");
            command.ExecuteNonQuery();
            //insert accomodations
            command.CommandText = String.Format("insert into accommodations ( acc_name, acc_adress_city, acc_adress_county, " +
                "acc_adress_postcode, acc_adress_street, acc_adress_number, acc_description, " +
                "acc_picture_url, acco_feedback) values ('Grand Inn', 'London', 'Londonshire', 'LO11', " +
                "'Main Street', '4a', 'A very neat hotel', 'hotel1.jpg','');");
            command.ExecuteNonQuery();
            //insert accomodations
            command.CommandText = String.Format("insert into accommodations ( acc_name, acc_adress_city, acc_adress_county, " +
                "acc_adress_postcode, acc_adress_street, acc_adress_number, acc_description, " +
                "acc_picture_url, acco_feedback) values ('Metro Hotel', 'London', 'Londonshire', 'LO14', " +
                "'Main Street', '4a', 'A very neat hotel', 'hotel1.jpg', '');");
            command.ExecuteNonQuery();
            //insert accomodations
            command.CommandText = String.Format("insert into accommodations ( acc_name, acc_adress_city, acc_adress_county, " +
                "acc_adress_postcode, acc_adress_street, acc_adress_number, acc_description, " +
                "acc_picture_url, acco_feedback) values ('City Stay', 'York', 'Yorkshire', 'YO13', " +
                "'Main Street', '4a', 'A very neat hotel', 'hotel2.jpg','');");
            command.ExecuteNonQuery();

            //insert customers
            command.CommandText = String.Format("insert into customer (title, firstname, surname, birthday, street, postcode, city, " +
                "country, cardholder_name, creditcard_number, expdate_month, expdate_year)" + 
                " values('Mr.', 'Peter', 'Parker', '2010-03-4', '7 KopStreet', 'SO14', 'Southampton', 'United Kingdom', 'Peter Parker', '700000', 'March', '2015');");
            command.ExecuteNonQuery();
            //insert customers
            command.CommandText = String.Format("insert into customer (title, firstname, surname, birthday, street, postcode, city, " +
                "country, cardholder_name, creditcard_number, expdate_month, expdate_year)" +
                " values('Mr.', 'Hans', 'Paddel', '2010-03-4', '2 ParkStreet', 'SO14', 'Southampton', 'United Kingdom', 'Hans Paddel', '5002340', 'March', '2015');");
            command.ExecuteNonQuery();
            //insert customers
            command.CommandText = String.Format("insert into customer (title, firstname, surname, birthday, street, postcode, city, " +
                "country, cardholder_name, creditcard_number, expdate_month, expdate_year)" +
                " values('Mrs.', 'Ann', 'Smith', '2010-03-4', '4 abroStreet', 'SO15', 'Southampton', 'United Kingdom', 'Ann Smith', '1223450', 'March', '2015');");
            command.ExecuteNonQuery();
            //insert customers
            command.CommandText = String.Format("insert into customer (title, firstname, surname, birthday, street, postcode, city, " +
                "country, cardholder_name, creditcard_number, expdate_month, expdate_year)" +
                " values('Mrs.', 'Linda', 'Smoll', '2010-03-4', '23 Tor Road', 'SO19', 'Southampton', 'United Kingdom', 'Linda Smoll', '1288450', 'March', '2015');");
            command.ExecuteNonQuery();
            //insert customers
            command.CommandText = String.Format("insert into customer (title, firstname, surname, birthday, street, postcode, city, " +
                "country, cardholder_name, creditcard_number, expdate_month, expdate_year)" +
                " values('Mr.', 'Dieter', 'Dietrich', '2010-03-4', '45 Penen Road', 'SO19', 'Southampton', 'United Kingdom', 'Dieter Dietrich', '5288450', 'March', '2015');");
            command.ExecuteNonQuery();
            //insert customers
            command.CommandText = String.Format("insert into customer (title, firstname, surname, birthday, street, postcode, city, " +
                "country, cardholder_name, creditcard_number, expdate_month, expdate_year)" +
                " values('Mr.', 'Ulf', 'von der Alm', '2010-03-4', 'Kaeseweg 4', 'asdasd', 'Den haag', 'Netherlands', 'Ulf von der Alm', '6688450', 'March', '2015');");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(101, 1, 2);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(102, 1, 2);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(103, 1, 3);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(104, 1, 4);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(105, 1, 3);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(106, 1, 4);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(1, 2, 2);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(2, 2, 2);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(3, 2, 3);");
            command.ExecuteNonQuery();
            //insert rooms
            command.CommandText = String.Format("insert into rooms (room_number, acc_id, bedcount) values(4, 2, 3);");
            command.ExecuteNonQuery();
            //insert bookings
            command.CommandText = String.Format("insert into bookings (acc_id, room_id, room_number, " +
                "cust_id, start_date, end_date) values(1, 1, 101, 1, '2013-01-13', '2013-02-01');");
            command.ExecuteNonQuery();
            //insert bookings
            command.CommandText = String.Format("insert into bookings (acc_id, room_id, room_number, " +
                "cust_id, start_date, end_date) values(1, 1, 101, 1, '2013-01-13', '2013-02-01');");
            command.ExecuteNonQuery();
            //insert facility
            command.CommandText = String.Format("insert into facility (name, type, adress_city,adress_country,"+
                "adress_postcode,adress_street,adress_number, information, feedback, picture_url) values"+
                "('Big Ape','Restaurant','Southampton','Hampshire','SO13','Arthur Road','101', "+
                "'friendly with sea view','lovely fish soupe','hotel1.jpg')");
            command.ExecuteNonQuery();
            //insert facility
            command.CommandText = String.Format("insert into facility (name, type, adress_city,adress_country," +
                "adress_postcode,adress_street,adress_number, information, feedback, picture_url) values" +
                "('Big Drink','Bar','Southampton','Hampshire','SO13','Arthur Road','105', " +
                "'dark','good german beer','hotel1.jpg')");
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void insertCustomer(Customer c)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                   string myInsertQuery =
                        "INSERT INTO customer (title, firstname, surname, birthday, street, postcode, city, country," +
                        " cardholder_name, creditcard_number, expdate_month, expdate_year )";
                    myInsertQuery += " VALUES('" + c.Title + "','" + c.Firstname + "','" +
                        c.Surname + "','" + c.Birthday + "','" +
                        c.Street + "','" + c.Postcode + "','" + c.City + "','" + c.Country + "','" +
                        c.CardholderName + "','" + c.Cardnumber + "','" + c.Expiremonth + "','" + c.Expireyear + "')";
                        command.CommandText = myInsertQuery;
                        command.ExecuteNonQuery();
             
                

                connection.Close();


                //get the id for the log
                SQLiteConnection connection2 = new SQLiteConnection("Data Source=tourismus.db");
                connection2.Open();
                int cust_id = 0;
                  
                        
                SQLiteCommand cmd = new SQLiteCommand("SELECT cust_id from customer where firstname = '" + c.Firstname + "' and surname = '"+ c.Surname + "' and birthday = '" + c.Birthday + "'", connection2);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        cust_id = reader.GetInt32(reader.GetOrdinal("cust_id"));
                        
                    }

                }
                connection2.Close();

                // 1 = Account created +
                // 2 = Account updated +
                // 3 = Account deleted +
                // 4 = Aquired accommodation information
                // 5 = Aquired facility information
                // 6 = Booked an accommodation +
                // 7 = Deleted a booking +
                // 8 = Gave feedback about accommodation
                // 9 = Gave feedback about facility
                // 10 = Start of session
                // 11 = End of session

                //log(string custname, int custId, int action)
                logger.log(cust_id, 1);
            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            }
            
        }
public void editCustomer(Customer c, int cust_id)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                        
 
                        string myEditQuery =
                            "UPDATE customer SET title='" + c.Title + "', firstname='" + c.Firstname + "', surname='" + c.Surname + "', birthday='" + c.Birthday + "', street='" +
                            c.Street + "', postcode='" + c.Postcode + "', city='" + c.City + "', country='" + c.Country + "',"+
                            "cardholder_name='" + c.CardholderName + "', creditcard_number='" + c.Cardnumber + "', expdate_month='" + c.Expiremonth + "', expdate_year='" + c.Expireyear + "' WHERE cust_id="+cust_id;

                        command.CommandText = myEditQuery;
                        command.ExecuteNonQuery();
                
                

                connection.Close();


                // 1 = Account created +
                // 2 = Account updated +
                // 3 = Account deleted +
                // 4 = Aquired accommodation information
                // 5 = Aquired facility information
                // 6 = Booked an accommodation +
                // 7 = Deleted a booking +
                // 8 = Gave feedback about accommodation
                // 9 = Gave feedback about facility
                // 10 = Start of session
                // 11 = End of session

                //log(string custname, int custId, int action)
                logger.log( cust_id, 2);
               
            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            }
            
        }
        public void closeCustomerAccount(Customer c)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                string myInsertQuery =
                     "INSERT INTO closedaccounts (title, firstname, surname, birthday, street, postcode, city, country," +
                     " cardholder_name, creditcard_number, expdate_month, expdate_year )";
                myInsertQuery += " VALUES('" + c.Title + "','" + c.Firstname + "','" +
                    c.Surname + "','" + c.Birthday + "','" +
                    c.Street + "','" + c.Postcode + "','" + c.City + "','" + c.Country + "','" +
                    c.CardholderName + "','" + c.Cardnumber + "','" + c.Expiremonth + "','" + c.Expireyear + "')";
                command.CommandText = myInsertQuery;
                command.ExecuteNonQuery();


                connection.Close();
                SQLiteConnection connection2 = new SQLiteConnection("Data Source=tourismus.db");
                connection2.Open();
                SQLiteCommand command2 = new SQLiteCommand(connection2);
                string myInsertQuery2 =
                     "DELETE FROM customer where cust_id="+c.Custi_id;
                command2.CommandText = myInsertQuery2;
                command2.ExecuteNonQuery();
                connection2.Close();

                // 1 = Account created +
                // 2 = Account updated +
                // 3 = Account deleted +
                // 4 = Aquired accommodation information
                // 5 = Aquired facility information
                // 6 = Booked an accommodation +
                // 7 = Deleted a booking +
                // 8 = Gave feedback about accommodation
                // 9 = Gave feedback about facility
                // 10 = Start of session
                // 11 = End of session

                //log(string custname, int custId, int action)
                logger.log(c.Custi_id, 3);

            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            }
        }
        public Accomodation searchAccomodation(string acc_id)
        {
            try
            {
                string accommodation_id = acc_id;
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
                        string feedback = reader.GetString(reader.GetOrdinal("acco_feedback"));
                        ac = new Accomodation(""+acc_id,name, adress_city, adress_county, adress_postcode, adress_street, adress_number, description,picture_url, feedback);   
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
        public List<Customer> getCustomersBySurename(string sur)
        {

            List<Customer> customerList = new List<Customer>();
            try{
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand("select * from customer where surname = '"+sur+"'", connection);
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
                        int creditcardnumber = reader.GetInt32(reader.GetOrdinal("creditcard_number"));//issue
                        String expdatemonth = reader.GetString(reader.GetOrdinal("expdate_month"));
                        String expdateyear = reader.GetString(reader.GetOrdinal("expdate_year"));

                        Customer c = new Customer(title, surname, firstname, birthday, street, postcode, city, country, cardholder, "" + creditcardnumber, expdatemonth, expdateyear);
                        c.Custi_id = reader.GetInt32(reader.GetOrdinal("cust_id"));
                        customerList.Add(c);

                    }

                }
                connection.Close();
            }
            catch(Exception e){
                System.Console.WriteLine(e.ToString());
            }
            return customerList;
        }
        public List<Customer> getAllCustomers()
        {

            List<Customer> allCustomerList = new List<Customer>();
            try
            {
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
                        int creditcardnumber = reader.GetInt32(reader.GetOrdinal("creditcard_number"));//issue
                        String expdatemonth = reader.GetString(reader.GetOrdinal("expdate_month"));
                        String expdateyear = reader.GetString(reader.GetOrdinal("expdate_year"));

                        Customer c = new Customer(title, surname, firstname, birthday, street, postcode, city, country, cardholder, "" + creditcardnumber, expdatemonth, expdateyear);
                        c.Custi_id = reader.GetInt32(reader.GetOrdinal("cust_id"));
                        allCustomerList.Add(c);

                    }

                }
                connection.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            return allCustomerList;
        }
        //returning all accommodations in a list
        public List<Accomodation> getAllAccommodations()
        {

            List<Accomodation> allAccommodationList = new List<Accomodation>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();

                Accomodation ac = null;
                SQLiteCommand cmd = new SQLiteCommand("select * from accommodations", connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int acc_id = reader.GetInt32(reader.GetOrdinal("acc_id"));
                        string name = reader.GetString(reader.GetOrdinal("acc_name"));
                        string adress_city = reader.GetString(reader.GetOrdinal("acc_adress_city"));
                        string adress_county = reader.GetString(reader.GetOrdinal("acc_adress_county"));
                        string adress_postcode = reader.GetString(reader.GetOrdinal("acc_adress_postcode"));
                        string adress_street = reader.GetString(reader.GetOrdinal("acc_adress_street"));
                        string adress_number = reader.GetString(reader.GetOrdinal("acc_adress_number"));
                        string description = reader.GetString(reader.GetOrdinal("acc_description"));
                        string picture_url = reader.GetString(reader.GetOrdinal("acc_picture_url"));
                        string feedback = reader.GetString(reader.GetOrdinal("acco_feedback"));
                        ac = new Accomodation("" + acc_id, name, adress_city, adress_county, adress_postcode, adress_street, adress_number, description, picture_url,feedback);
                        allAccommodationList.Add(ac);
                    }

                }
                connection.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            return allAccommodationList;
        }

        public List<Bookings> getBookings(Customer cust)
        {
            List<Bookings> bookingList = new List<Bookings>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand("select * from bookings natural join accommodations where cust_id = " + cust.Custi_id, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        String acc_name = reader.GetString(reader.GetOrdinal("acc_name"));
                        int book_id = reader.GetInt32(reader.GetOrdinal("book_id"));
                        int acc_id = reader.GetInt32(reader.GetOrdinal("acc_id"));
                        int room_id = reader.GetInt32(reader.GetOrdinal("room_id"));
                        int room_number = reader.GetInt32(reader.GetOrdinal("room_number"));
                        String start_date = reader.GetString(reader.GetOrdinal("start_date"));
                        String end_date = reader.GetString(reader.GetOrdinal("end_date"));
                        

                        Bookings b = new Bookings(cust,acc_name, book_id, acc_id, room_id, room_number, start_date, end_date);
                        
                        bookingList.Add(b);

                    }

                }
                connection.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
  
            return bookingList;
        }
        public void deleteBooking(Bookings b)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                string myInsertQuery =
                     "DELETE FROM bookings where book_id="+b.Book_id;
                command.CommandText = myInsertQuery;
                command.ExecuteNonQuery();
                connection.Close();

                // 1 = Account created +
                // 2 = Account updated +
                // 3 = Account deleted +
                // 4 = Aquired accommodation information
                // 5 = Aquired facility information
                // 6 = Booked an accommodation +
                // 7 = Deleted a booking +
                // 8 = Gave feedback about accommodation
                // 9 = Gave feedback about facility
                // 10 = Start of session
                // 11 = End of session

                //log(string custname, int custId, int action)
                logger.log( b.C.Custi_id, 7); ////////////needs ids
                
            }
            catch(Exception){

            }
        }

        public string getHotelNameDb(string accommodation_id)
        {
            String s = "";
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand("select * from accommodations where acc_id =  " + accommodation_id, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {

                        s = reader.GetString(reader.GetOrdinal("acc_name"));
                    }

                connection.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            return s;
        }

        public List<int> getBookingRoomId(string accommodation_id)
        {
            List<int> l = new List<int>();
            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select room_id FROM bookings where acc_id =  " + accommodation_id, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        l.Add(reader.GetInt32(reader.GetOrdinal("room_id")));
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            connection.Close();
            return l;
        }

        public List<DateTime> getbookingStartDateRoom(string accommodation_id)
        {
            List<DateTime> l = new List<DateTime>();
            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select start_date from bookings where acc_id =  " + accommodation_id, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        l.Add(reader.GetDateTime(reader.GetOrdinal("start_date")));
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            connection.Close();
            return l;
        }

        public List<DateTime> getbookingEndDateRoom(string accommodation_id)
        {
            List<DateTime> l = new List<DateTime>();
            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select end_date from bookings where acc_id =  " + accommodation_id, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        l.Add(reader.GetDateTime(reader.GetOrdinal("end_date")));
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            connection.Close();
            return l;
        }

        internal Dictionary<int, int> getBookingRooms(string accommodation_id)
        {
            Dictionary<int,int> d = new Dictionary<int, int>();
            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select room_id, room_number from rooms where acc_id =  " + accommodation_id, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        d.Add(reader.GetInt32(reader.GetOrdinal("room_id")), reader.GetInt32(reader.GetOrdinal("room_number")));
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            connection.Close();
            return d;
        }

        public List<string> getRoomDetails(string room_id)
        {
            List<string> room_details = new List<string>();
            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select * from rooms where room_id =  " + room_id, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        room_details.Add("" + reader.GetInt32(reader.GetOrdinal("room_id")));
                        room_details.Add("" + reader.GetInt32(reader.GetOrdinal("room_number")));
                        room_details.Add("" + reader.GetInt32(reader.GetOrdinal("bedcount")));
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            connection.Close();
            return room_details;
        }
        public void insertBooking(int acc_id, int room_id, int room_number, int cust_id, DateTime start, DateTime end)
        {
            int sy, sm, sd, ey, em, ed;
            string startstring, endstring;

            sy = start.Year;
            startstring = ""+sy;
            sm = start.Month;
            sd = start.Day;
            ey = end.Year;
            endstring = ""+ey;
            em = end.Month;
            ed = end.Day;

            if (sm < 10)
                startstring += "-0" + sm;
            else
                startstring += "-"+sm;
            if (sd < 10)
                startstring += "-0" + sd;
            else
                startstring += "-"+sd;
            if (em < 10)
                endstring += "-0" + em;
            else
                endstring += "-"+em;
            if (ed < 10)
                endstring += "-0" + ed;
            else
                endstring += "-"+ed;

            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);
            //insert accomodations 2013-01-13
            command.CommandText = String.Format("insert into bookings ( acc_id, room_id, room_number, " +
                "cust_id, start_date, end_date) values ("+acc_id+", "+room_id+", "+room_number+", "+cust_id+", " +
                "'" + startstring +"', '" + endstring +"');");
            command.ExecuteNonQuery();
            connection.Close();

            // 1 = Account created +
            // 2 = Account updated +
            // 3 = Account deleted +
            // 4 = Aquired accommodation information
            // 5 = Aquired facility information
            // 6 = Booked an accommodation +
            // 7 = Deleted a booking +
            // 8 = Gave feedback about accommodation
            // 9 = Gave feedback about facility
            // 10 = Start of session
            // 11 = End of session

            //log(string custname, int custId, int action)
            logger.log(cust_id, 6);

        }


        //get the data about one facility out of the db and returns an Facility object
        public List<Facility> getFacility(){
            List<Facility> list = new List<Facility>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from facility",connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {
                        Facility ftemp = new Facility(System.Convert.ToString(reader.GetInt32(reader.GetOrdinal("fac_id"))),
                            reader.GetString(reader.GetOrdinal("type")), reader.GetString(reader.GetOrdinal("name")),
                            reader.GetString(reader.GetOrdinal("adress_city")), reader.GetString(reader.GetOrdinal("adress_country")),
                            reader.GetString(reader.GetOrdinal("adress_postcode")), reader.GetString(reader.GetOrdinal("adress_street")),
                            reader.GetString(reader.GetOrdinal("adress_number")),
                            reader.GetString(reader.GetOrdinal("information")),
                            reader.GetString(reader.GetOrdinal("feedback")),
                            reader.GetString(reader.GetOrdinal("picture_url")));
                        list.Add(ftemp);
                    }

                connection.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            return list;
        }
        public Facility selectFacility(string fac_id, Customer c)
        {
            Facility ftemp = null;
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select * from facility where fac_id="+fac_id, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {
                        ftemp = new Facility(System.Convert.ToString(reader.GetInt32(reader.GetOrdinal("fac_id"))),
                            reader.GetString(reader.GetOrdinal("type")), reader.GetString(reader.GetOrdinal("name")),
                            reader.GetString(reader.GetOrdinal("adress_city")), reader.GetString(reader.GetOrdinal("adress_country")),
                            reader.GetString(reader.GetOrdinal("adress_postcode")), reader.GetString(reader.GetOrdinal("adress_street")),
                            reader.GetString(reader.GetOrdinal("adress_number")),
                            reader.GetString(reader.GetOrdinal("information")),
                            reader.GetString(reader.GetOrdinal("feedback")),
                            reader.GetString(reader.GetOrdinal("picture_url")));
                    }

                connection.Close();
                // 1 = Account created +
                // 2 = Account updated +
                // 3 = Account deleted +
                // 4 = Aquired accommodation information
                // 5 = Aquired facility information + 
                // 6 = Booked an accommodation +
                // 7 = Deleted a booking +
                // 8 = Gave feedback about accommodation
                // 9 = Gave feedback about facility
                // 10 = Start of session
                // 11 = End of session

                //log(string custname, int custId, int action)
                logger.log(c.Custi_id, 5);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            return ftemp;
        }
        public void updateFacFeedback(Facility f, Customer c)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);

                string myEditQuery =
                    "UPDATE facility SET feedback='" + f.Feedback + "' WHERE fac_id=" + f.ID;

                command.CommandText = myEditQuery;
                command.ExecuteNonQuery();
                connection.Close();

                // 1 = Account created +
                // 2 = Account updated +
                // 3 = Account deleted +
                // 4 = Aquired accommodation information
                // 5 = Aquired facility information + 
                // 6 = Booked an accommodation +
                // 7 = Deleted a booking +
                // 8 = Gave feedback about accommodation
                // 9 = Gave feedback about facility + 
                // 10 = Start of session
                // 11 = End of session

                //log(string custname, int custId, int action)
                logger.log(c.Custi_id, 9);

            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            }
        }
        public void updateAccFeedback(Accomodation a, Customer c)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);

                string myEditQuery =
                    "UPDATE accommodations SET acco_feedback='" + a.Feedback + "' WHERE acc_id=" + a.ID;

                command.CommandText = myEditQuery;
                command.ExecuteNonQuery();
                connection.Close();

                // 1 = Account created +
                // 2 = Account updated +
                // 3 = Account deleted +
                // 4 = Aquired accommodation information
                // 5 = Aquired facility information + 
                // 6 = Booked an accommodation +
                // 7 = Deleted a booking +
                // 8 = Gave feedback about accommodation +
                // 9 = Gave feedback about facility + 
                // 10 = Start of session
                // 11 = End of session

                //log(string custname, int custId, int action)
                logger.log(c.Custi_id, 8);

            }
            catch (Exception et)
            {
                Console.WriteLine(et.ToString());
            }
        }
    }
}
