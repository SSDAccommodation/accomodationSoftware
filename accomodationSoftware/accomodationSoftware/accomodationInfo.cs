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
        public Database db { get; set; }
        public Accomodation CurrentAccomondation { get; set; }
        public Customer CurrentCustomer { get; set; }
        public Facility CurrentFacility { get; set; }


        public accomodationInfo(Customer c, Accomodation a)
        {
            InitializeComponent();
            CurrentCustomer = c;
            CurrentAccomondation = a;
            CurrentFacility = null;
            db = new Database();
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
            CurrentAccomondation = null;
            InitializeComponent();
            db = new Database();
            CurrentFacility = f;
            showFacilityData();
        }

        public void showAccommodationData()
        {
            b_bookingDetails.Show();
            //Daten in form einfügen
            l_hotelname.Text = CurrentAccomondation.Name;

            rtb_address.Text = CurrentAccomondation.Name + "\n" + CurrentAccomondation.Adress_street + " " 
                + CurrentAccomondation.Adress_number + "\n" + CurrentAccomondation.Adress_city + "\n" 
                + CurrentAccomondation.Adress_postcode + "\n" + CurrentAccomondation.Adress_county;
            rtb_description.Text = CurrentAccomondation.Description+"\nFeedback:"+CurrentAccomondation.Feedback;
            pb_hotel.Load("pictures\\" + CurrentAccomondation.Picture_url);

        }
        //Shows the data about the selected Facility
        public void showFacilityData()
        {
            b_bookingDetails.Hide();
            l_hotelname.Text = CurrentFacility.Name;
            rtb_address.Text = CurrentFacility.Name + "\n" + CurrentFacility.Adress_street + " "
                + CurrentFacility.Adress_number + "\n" + CurrentFacility.Adress_city + "\n"
                + CurrentFacility.Adress_postcode + "\n" + CurrentFacility.Adress_county;
            rtb_description.Text = CurrentFacility.Description + "\n\nFeedback: " + CurrentFacility.Feedback;
            pb_hotel.Load("pictures\\" + CurrentFacility.PicPath);
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

        private void b_insertfeedback_Click(object sender, EventArgs e)
        {
            if (CurrentAccomondation == null)
            {
                Form feedback = new addFeedback(CurrentFacility, CurrentCustomer);
                feedback.ShowDialog();
                CurrentFacility = db.selectFacility(CurrentFacility.ID, CurrentCustomer);
                showFacilityData();
            }
            else
            {
                Form feedback = new addFeedback(CurrentAccomondation, CurrentCustomer);
                feedback.ShowDialog();
                CurrentAccomondation = db.searchAccomodation(CurrentAccomondation.ID);
                showAccommodationData();
            }
        }

    }
}
