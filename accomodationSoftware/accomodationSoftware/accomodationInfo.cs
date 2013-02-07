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
        public int accommodation_id { get; set; }
        public int user_id { get; set; }
        public Db db { get; set; }
        public Accomodation ac;
        public accomodationInfo()
        {
            InitializeComponent();

            accommodation_id = 1;
            user_id = 1;

            db = new Db();
            //db.createDB();
            //method that returns the accommodation_id
            try
            {
                ac = db.searchAccomodation(accommodation_id, user_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            showAccommodationData(ac);


        }

        public void showAccommodationData(Accomodation acc)
        {
            ac = acc;

            //Daten in form einfügen
            l_hotelname.Text = ac.Name;
            rtb_address.Text = ac.Name + "\n" + ac.Adress_street + " " + ac.Adress_number + "\n" + ac.Adress_city + "\n" + ac.Adress_postcode + "\n" + ac.Adress_county;
            rtb_description.Text = ac.Description;
            pb_hotel.Load("pictures\\" + ac.Picture_url);



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
