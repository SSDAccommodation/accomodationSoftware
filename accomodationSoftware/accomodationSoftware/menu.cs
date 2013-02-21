using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accomodationSoftware
{
    public partial class Menu : Form
    {

        public int accommodation_id { get; set; }
        public int user_id { get; set; }

        public Menu()
        {
            InitializeComponent();
            accommodation_id = 0;
            user_id = 0;

           
        }

        private void Add_customer_button_Click(object sender, EventArgs e)
        {
            new_customer accForm = new new_customer();
            accForm.Show();
        }

        private void accInfoButton_Click(object sender, EventArgs e)
        {
            accomodationInfo accForm = new accomodationInfo();
            accForm.Show();
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            if (accommodation_id != 0 && user_id != 0)
            {
                bookingDetails bookForm = new bookingDetails(accommodation_id, user_id);
                bookForm.Show();
            }
        }

        private void showCustomerButton_Click(object sender, EventArgs e)
        {
            ShowCustomer showCust = new ShowCustomer();
            showCust.Show();
        }


    }
}
