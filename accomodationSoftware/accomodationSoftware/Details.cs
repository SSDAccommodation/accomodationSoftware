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

        public Details(Customer c, Accomodation a, DateTime start, DateTime end, string roomID)
        {
            InitializeComponent();
            CurrentCustomer = c;
            CurrentAccomodation = a;
            StartD = start;
            EndD = end;
            RoomID = roomID;
            populateDetails();
        }
        private void populateDetails()
        {
            //fill ListView
        }

        private void b_book_Click(object sender, EventArgs e)
        {
            //db-method
        }
    }
}
