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

namespace accomodationSoftware
{
    public partial class accomodationInfo : Form
    {
        public Db db { get; set; }
        public Accomodation CurrentAccomondation { get; set; }
        public Customer CurrentCustomer { get; set; }
        public Facility CurrentFacility { get; set; }


        public accomodationInfo(Customer c, Accomodation a)
        {
            InitializeComponent();
            CurrentCustomer = c;
            CurrentAccomondation = a;

            db = new Db();
            try
            {
                CurrentAccomondation = db.searchAccomodation(CurrentAccomondation.ID);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            showAccommodationData();
        }
        public accomodationInfo(Facility f)
        {
            InitializeComponent();
            db = new Db();
            CurrentFacility = f;
            
        }

        public void showAccommodationData()
        {

            //Daten in form einfügen
            l_hotelname.Text = CurrentAccomondation.Name;

            rtb_address.Text = CurrentAccomondation.Name + "\n" + CurrentAccomondation.Adress_street + " " 
                + CurrentAccomondation.Adress_number + "\n" + CurrentAccomondation.Adress_city + "\n" 
                + CurrentAccomondation.Adress_postcode + "\n" + CurrentAccomondation.Adress_county;
            rtb_description.Text = CurrentAccomondation.Description;
            pb_hotel.Load("pictures\\" + CurrentAccomondation.Picture_url);

        }



        private void b_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_bookingDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingDetails bookForm = new bookingDetails(db.searchAccomodation(CurrentAccomondation.ID), CurrentCustomer);
            bookForm.Show();
        }

    }
}
