using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace accomodationSoftware
{
    public partial class Details : Form
    {
        public Db Database { get; set; }
        public Customer CurrentCustomer { get; set; }
        public Accomodation CurrentAccomodation { get; set; }
        public DateTime StartD { get; set; }
        public DateTime EndD { get; set; }
        public string RoomID { get; set; }
        public List<string> Room_details { get; set; }

        public Details(Customer c, Accomodation a, DateTime start, DateTime end, string roomID)
        {
            InitializeComponent();
            CurrentCustomer = c;
            CurrentAccomodation = a;
            StartD = start;
            EndD = end;
            RoomID = roomID;
            Database = new Db();
            populateDetails();      

        }
        private void populateDetails()
        {
            Room_details = Database.getRoomDetails(RoomID);
            //fill ListView
            lv_details.Items.Add(CurrentCustomer.Surname + ", " + CurrentCustomer.Firstname);
            lv_details.Items.Add("Accommodation: " + CurrentAccomodation.Name);
            lv_details.Items.Add("Room Number: " + Room_details[1] + ", Beds: "+ Room_details[2]);
            lv_details.Items.Add("From: " + StartD);
            lv_details.Items.Add("To: " + EndD);
            
        }

        private void b_book_Click(object sender, EventArgs e)
        {
            try{
                Database.insertBooking(Convert.ToInt32(CurrentAccomodation.ID),Convert.ToInt32(Room_details[0]),
                    Convert.ToInt32(Room_details[1]),Convert.ToInt32(CurrentCustomer.custi_id),StartD,EndD);
                this.Close();
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
