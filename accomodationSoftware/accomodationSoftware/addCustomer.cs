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
        public string Type { get; set; }
        public Db Db;

        public AddCustomer()
        {
            InitializeComponent();
            Db = new Db();
            //overwrites the db
            //dberstellen();

            b_closeAccount.Hide();

        }
        public AddCustomer(Customer c)
        {
            Customer = c;
            InitializeComponent();
            Db = new Db();
            l_formtitle.Text = "Edit customer";
            b_closeAccount.Show();
            cb_title.Text = c.Title;
            tb_firstname.Text = c.Firstname;
            tb_surname.Text = c.Surname;
            cb_byear.Text = c.Birthday.Split('-')[0];
            cb_bmonth.Text = c.Birthday.Split('-')[1];
            cb_bday.Text = c.Birthday.Split('-')[2];
            switch (c.Birthday.Split('-')[1])
            {
                case "01":
                    cb_bmonth.Text = "Janurary";
                    break;
                case "02":
                    cb_bmonth.Text = "Februray";
                    break;
                case "03":
                    cb_bmonth.Text = "March";
                    break;
                case "04":
                    cb_bmonth.Text = "April";
                    break;
                case "05":
                    cb_bmonth.Text = "May";
                    break;
                case "06":
                    cb_bmonth.Text = "June";
                    break;
                case "07":
                    cb_bmonth.Text = "July";
                    break;
                case "08":
                    cb_bmonth.Text = "August";
                    break;
                case "09":
                    cb_bmonth.Text = "September";
                    break;
                case "10":
                    cb_bmonth.Text = "October";
                    break;
                case "11":
                    cb_bmonth.Text = "November";
                    break;
                case "12":
                    cb_bmonth.Text = "December";
                    break;
                default:
                    cb_bmonth.Text = "0";
                    break;
            }
            tb_street.Text = c.Street;
            tb_postcode.Text = c.Postcode;
            tb_city.Text = c.City;
            cb_country.Text = c.Country;
            tb_cardholder.Text = c.CardholderName;
            tb_creditnum.Text = c.Cardnumber;
            cb_expiremonth.Text = c.Expiremonth;
            cb_expireyear.Text = c.Expireyear;
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
                
                Db.insertOrEditCustomer(Customer);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_closeAccount_Click(object sender, EventArgs e)
        {
            Db.closeCustomerAccount(Customer);
        }

        

        

    }
}
