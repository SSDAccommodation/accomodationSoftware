using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Web;
//using MySql.Data.MySqlClient;

using System.Data.SQLite;

namespace accomodationSoftware
{
    public partial class AddCustomer : Form
    {
        
        public string Bmonth { get; set; }
        public Customer Customer { get; set; }
        public Db Db;

        public AddCustomer()
        {
            InitializeComponent();
            Db = new Db();

            //overwrites the db
            //dberstellen();
        }
        
        private void b_saveCustomer_Click(object sender, EventArgs e)
        {//switch case wegen monat
            if (cb_title.Text != "" && tb_firstname.Text != "" && tb_surname.Text != "" && cb_byear.Text != "" && cb_bmonth.Text != "" && cb_bday.Text != "" && tb_street.Text != "" && tb_postcode.Text != "" && tb_city.Text != "" && cb_country.Text != "" && tb_cardholder.Text != ""  && tb_creditnum.Text != "" && cb_expiremonth.Text != "" && cb_expireyear.Text != "")
            {
                switch (cb_bmonth.Text) { 
                    case "Janurary":
                        Bmonth = "01";
                        break;
                    case "Februray":
                        Bmonth = "02";
                        break;
                    case "March":
                        Bmonth = "03";
                        break;
                    case "April":
                        Bmonth = "04";
                        break;
                    case "May":
                        Bmonth = "05";
                        break;
                    case "June":
                        Bmonth = "06";
                        break;
                    case "July":
                        Bmonth = "07";
                        break;
                    case "August":
                        Bmonth = "08";
                        break;
                    case "September":
                        Bmonth = "09";
                        break;
                    case "October":
                        Bmonth = "10";
                        break;
                    case "November":
                        Bmonth = "11";
                        break;
                    case "December":
                        Bmonth = "12";
                        break;
                    default: 
                        Bmonth = "0";
                        break;   
                }
                //create customer
                Customer = new Customer(cb_title.Text, tb_surname.Text, tb_firstname.Text, cb_byear.Text + "-" + Bmonth +
                    "-" + cb_bday.Text, tb_street.Text, tb_postcode.Text, tb_city.Text, cb_country.Text, tb_cardholder.Text, tb_creditnum.Text, cb_expiremonth.Text, cb_expireyear.Text);//title,surname,firstname,birthday,street,postcode,city,country,cardholder,cardnumber,expire);
                // call method in db
                Db.insertNewCustomer(Customer);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void accShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            accomodationInfo accForm = new accomodationInfo();
            accForm.Show();
        }

        /*    
        private void dberstellen()
        {
            SQLiteConnection.CreateFile("tourismus.db");

            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = String.Format("create table customer (cust_id integer not null primary key autoincrement,  title varchar(10) NOT NULL, firstname varchar(30) NOT NULL, surname varchar(30) NOT NULL, birthday date NOT NULL, street varchar(40) NOT NULL, postcode varchar(10) NOT NULL, city varchar(50) DEFAULT NULL, country varchar(50) DEFAULT NULL, cardholder_name varchar(50) DEFAULT NULL, creditcard_number int(11) DEFAULT NULL, expdate_month varchar(20) NOT NULL, expdate_year varchar(4) NOT NULL)", "Adressen");
            command.ExecuteNonQuery();


            connection.Close();   
        }*/


    }
}
