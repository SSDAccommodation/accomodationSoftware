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
        //showCustomer start
        public Db Db;
        public List<Customer> CustomerList { get; set; }
        public List<Customer> AllcustomerList { get; set; }
        public Customer CurrentCustomer { get; set; }
        //show accommodations
        public List<Accomodation> AllAccommodationsList { get; set; }
        //bookingDetails start
        public DateTime StartD { get; set; }
        public DateTime EndD { get; set; }
        public List<DateTime> startDateRoom { get; set; }
        public List<DateTime> endDateRoom { get; set; }
        public List<int> roomId { get; set; }
        public Dictionary<int, int> rooms { get; set; }
        public Accomodation CurrentAccomodation { get; set; }
        public string AddOrEdit { get; set; }
        //bookingDetails end
        public Menu()
        {
            InitializeComponent();
            accommodation_id = 1;
            user_id = 1;
            //showCustomer start
            Db = new Db();
            CustomerList = new List<Customer>();
            AllcustomerList = Db.getAllCustomers();// all customers are now in this list for searching
            AllAccommodationsList = Db.getAllAccommodations();// all accommodations are now in this list for searching
            //showCustomer end
            //bookingdetails start
            startDateRoom = new List<DateTime>();
            endDateRoom = new List<DateTime>();
            roomId = new List<int>();
            rooms = new Dictionary<int, int>();
            dgv_bookings.ColumnCount = 2;
            dgv_bookings.Columns[0].Name = "Room ID";
            dgv_bookings.Columns[1].Name = "Room Number";
            dgv_bookings.Columns[0].Width = dgv_bookings.Width / 2 - 22;
            dgv_bookings.Columns[1].Width = dgv_bookings.Width / 2 - 21;
            l_hotelName_bd.Text = Db.getHotelNameDb(accommodation_id+"");
            dTP_startDate.Value = DateTime.Today;
            dTP_endDate.Value = DateTime.Today;
            StartD = dTP_startDate.Value;
            //bookingdetails end
            populateComobox();
            showCust(Db.getAllCustomers());
            p_showbookings.Hide();
            AddOrEdit = "";
        }
        
        public void showCust(List<Customer> a)
        {
            CustomerList = a;
            string[] temp = new string[12];
            try
            {
                dg_customer.RowCount = 1; //to clear the data grid
                dg_customer.ColumnCount = 12;
                dg_customer.Columns[0].Name = "Title";
                dg_customer.Columns[1].Name = "Firstname";
                dg_customer.Columns[2].Name = "Surname";
                dg_customer.Columns[3].Name = "Birthday";
                dg_customer.Columns[4].Name = "Street";
                dg_customer.Columns[5].Name = "Postcode";
                dg_customer.Columns[6].Name = "City";
                dg_customer.Columns[7].Name = "Country";
                dg_customer.Columns[8].Name = "Cardholder Name";
                dg_customer.Columns[9].Name = "Cardnumber";
                dg_customer.Columns[10].Name = "Expiremonth";
                dg_customer.Columns[11].Name = "Expireyear";

                foreach (Customer c in a)
                {
                    temp[0] = (c.Title);
                    temp[1] = (c.Firstname);
                    temp[2] = (c.Surname);
                    temp[3] = (c.Birthday);
                    temp[4] = (c.Street);
                    temp[5] = (c.Postcode);
                    temp[6] = (c.City);
                    temp[7] = (c.Country);
                    temp[8] = (c.CardholderName);
                    temp[9] = (c.Cardnumber);
                    temp[10] = (c.Expiremonth);
                    temp[11] = (c.Expireyear);
                    dg_customer.Rows.Add(temp);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }//showCustomer end
        
        private void Add_customer_button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddCustomer accForm = new AddCustomer();
            accForm.Show();
        }

        private void accInfoButton_Click(object sender, EventArgs e)
        {
            p_showbookings.Hide();
            p_accomodationinfo.Hide();
            p_accomodations.Show();
            p_bookingdetails.Hide();
            p_showcustomer.Hide();
            showAccommodations(Db.getAllAccommodations());
            
            //this.Hide();
            //accomodationInfo accForm = new accomodationInfo();
            //accForm.Show();
        }
        
        private void bookingButton_Click(object sender, EventArgs e)
        {
            if (accommodation_id != 0 && user_id != 0)
            {
                //this.Hide();
                //bookingDetails bookForm = new bookingDetails(accommodation_id, user_id);
                //bookForm.Show();
            }
        }
    
        private void showCustomerButton_Click(object sender, EventArgs e)
        {
            //hide the panels that are not needed and show the right one(here its p_showcustomer)
            //this.Hide();
            p_accomodationinfo.Hide();
            p_accomodations.Hide();
            p_bookingdetails.Hide();
            p_showcustomer.Show();
            showCust(Db.getAllCustomers());

            //ShowCustomer showCust = new ShowCustomer();
            //showCust.Show();
        }
        
        public List<Customer> customerSearch()
        {
            String searchquery = tb_surname.Text;

            List<Customer> foundlist = new List<Customer>();

            foreach (Customer item in Db.getAllCustomers())
            {
                if (item.Surname.ToLower().Contains(searchquery.ToLower()))
                    foundlist.Add(item);
            }
            return foundlist;
        }
        //showCustomer start
        private void b_search_Click(object sender, EventArgs e)
        {
            showCust(customerSearch());
        }
        
        private void b_search_ENTER(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showCust(customerSearch());
            }
        }
        
        private void b_addcustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.ShowDialog();
            showCust(Db.getAllCustomers());
        }

        private void b_selectcustomer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (dg_customer.CurrentRow.Cells[2].Value.Equals(CustomerList[i].Surname))
                {
                    CurrentCustomer = CustomerList[i];
                }

            }
            p_showcustomer.Hide();
            //after selecting a customer show accomodations
            p_accomodationinfo.Hide();
            p_accomodations.Show();
            p_bookingdetails.Hide();
            p_showcustomer.Hide();
            showAccommodations(Db.getAllAccommodations());
            p_accomodations.Show();
        }//showCustomer end
        //SearchAccomodation start
        public void populateComobox()
        {
            List<string> Citylist = new List<string>();//for searching
            List<string> temp1 = new List<string>();
            List<string> Countylist = new List<string>();// for searching
            List<string> temp2 = new List<string>();
            foreach (Accomodation ac in Db.getAllAccommodations())
            {
                
                Citylist.Add(ac.Adress_city);
                Countylist.Add(ac.Adress_county);
            }

            cb_accosearchcity.Items.Clear();
            cb_accosearchcountry.Items.Clear();
            temp1 = RemoveDoubleListItems<string>(Citylist);
            temp2 = RemoveDoubleListItems<string>(Countylist);
            cb_accosearchcity.Items.AddRange(temp1.ToArray());
            cb_accosearchcountry.Items.AddRange(temp2.ToArray());

        }
        
        public void showAccommodations(List<Accomodation> a)
        {
            List<Accomodation> AccommodationList = a;
            
            string[] temp = new string[6];
            try
            {
                dgv_searchaccomodation.RowCount = 1; //to clear the data grid
                dgv_searchaccomodation.ColumnCount = 6;
                dgv_searchaccomodation.Columns[0].Name = "Name";
                dgv_searchaccomodation.Columns[1].Name = "City";
                dgv_searchaccomodation.Columns[2].Name = "County";
                dgv_searchaccomodation.Columns[3].Name = "Postcode";
                dgv_searchaccomodation.Columns[4].Name = "Street";
                dgv_searchaccomodation.Columns[5].Name = "Number";


                foreach (Accomodation ac in a)
                {
                    temp[0] = (ac.Name);
                    temp[1] = (ac.Adress_city);
                    temp[2] = (ac.Adress_county);
                    temp[3] = (ac.Adress_postcode);
                    temp[4] = (ac.Adress_street);
                    temp[5] = (ac.Adress_number);
                    dgv_searchaccomodation.Rows.Add(temp);
                    
                }
                
            }
            
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
        //showbookings is called in b_showbookings_Click and b_bookselected_Click
        public void showBookings(List<Bookings> b)
        {
            List<Bookings> BookingsList = b;

            string[] temp = new string[4];
            try
            {
                dgv_showbookings.RowCount = 1; //to clear the data grid
                dgv_showbookings.ColumnCount = 4;
                dgv_showbookings.Columns[0].Name = "Booked by";
                dgv_showbookings.Columns[1].Name = "Hotel";
                dgv_showbookings.Columns[2].Name = "From";
                dgv_showbookings.Columns[3].Name = "Until";
                


                foreach (Bookings bk in b)
                {
                    temp[0] = (bk.C.Firstname + " " + bk.C.Surname);
                    temp[1] = (bk.Name);
                    temp[2] = (bk.Start_date);
                    temp[3] = (bk.End_date);
                    
                    dgv_showbookings.Rows.Add(temp);

                }

            }

            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }
        
        public List<string> RemoveDoubleListItems<T>(List<string> list)
        {
            var newList = new List<string>();
            var keys = new Dictionary<string, object>();

            foreach (string listItem in list)
            {
                if (!keys.ContainsKey(listItem))
                {
                    newList.Add(listItem);
                    keys.Add(listItem, null);
                }
            }
            return newList;
        }
        // searches through all the accommodations
        public List<Accomodation> accommodationSearch()
        {
            String searchquery = tb_accosearchname.Text;

            List<Accomodation> foundlist = new List<Accomodation>();

            foreach (Accomodation item in Db.getAllAccommodations())
            {
                if (item.Name.ToLower().Contains(searchquery.ToLower()) && item.Adress_city.Contains(cb_accosearchcity.Text) && item.Adress_county.Contains(cb_accosearchcountry.Text))
                    foundlist.Add(item);
            }
            return foundlist;
            
        }

        private void b_accosearch_Click(object sender, EventArgs e)
        {
            showAccommodations(accommodationSearch());
        }
        
        private void b_accosearch_ENTER(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showAccommodations(accommodationSearch());
            }
        }

        private void b_selectaccomodation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AllAccommodationsList.Count; i++)
            {
                if (dgv_searchaccomodation.CurrentRow.Cells[0].Value.Equals(AllAccommodationsList[i].Name) &&
                    dgv_searchaccomodation.CurrentRow.Cells[1].Value.Equals(AllAccommodationsList[i].Adress_city) &&
                    dgv_searchaccomodation.CurrentRow.Cells[3].Value.Equals(AllAccommodationsList[i].Adress_postcode))
                {
                    CurrentAccomodation = AllAccommodationsList[i];
                }
            }
            //open bookings
            p_accomodations.Hide();
            p_bookingdetails.Show();
        }
        //SearchAccomodation end
        //bookingdetails start
        private void dTP_startDate_ValueChanged(object sender, EventArgs e)
        {
            StartD = dTP_startDate.Value;
            if (EndD < StartD)
                dTP_endDate.Value = StartD; 
        }

        private void dTP_endDate_ValueChanged(object sender, EventArgs e)
        {
            EndD = dTP_endDate.Value;
            dbDateCheck();
        }
        
        private void dbDateCheck()
        {
            //Check Db for selected Date
            roomId = Db.getBookingRoomId(accommodation_id+"");
            startDateRoom = Db.getbookingStartDateRoom(accommodation_id+"");
            endDateRoom = Db.getbookingEndDateRoom(accommodation_id+"");
            rooms = Db.getBookingRooms(accommodation_id+"");
            //SQLiteConnection connection2 = new SQLiteConnection("Data Source=tourismus.db");

            try
            {
                DateTime roomDate = DateTime.Now;

                for (int i = 0; i < startDateRoom.Count; i++)
                {
                    for (DateTime rdate = startDateRoom[i]; rdate <= endDateRoom[i]; rdate = rdate.AddDays(1))
                    {
                        roomDate = rdate;
                        for (DateTime date = StartD; date <= EndD; date = date.AddDays(1))
                        {
                            if (date == roomDate)
                            {
                                rooms.Remove(roomId[i]);
                            }
                        }
                    }
                }
                populateBookingDgv();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        
        private void populateBookingDgv()
        {
            dgv_bookings.RowCount = 1;
            dgv_bookings.Rows.Clear();
            try
            {
                List<int> temp = new List<int>();
                temp.AddRange(rooms.Keys);
                List<int> temp2 = new List<int>();
                temp2.AddRange(rooms.Values);


                for (int i = 0; i < temp.Count; i++)
                {
                    dgv_bookings.Rows.Add(new string[] { "" + temp[i], "" + temp2[i] });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void b_bookselected_Click(object sender, EventArgs e)
        {
            Details det = new Details(CurrentCustomer, CurrentAccomodation, StartD, EndD, dgv_bookings.CurrentRow.Cells[0].Value.ToString());
            det.ShowDialog();
            
            p_showbookings.Show();
            p_accomodationinfo.Hide();
            p_accomodations.Hide();
            p_bookingdetails.Hide();
            p_showcustomer.Hide();


            showBookings(Db.getBookings(CurrentCustomer));
        }

        private void b_showbookings_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (dg_customer.CurrentRow.Cells[2].Value.Equals(CustomerList[i].Surname))
                {
                    CurrentCustomer = CustomerList[i];
                }

            }
            p_showbookings.Show();
            p_accomodationinfo.Hide();
            p_accomodations.Hide();
            p_bookingdetails.Hide();
            p_showcustomer.Hide();
            showBookings(Db.getBookings(CurrentCustomer));
        }//bookingdetails end

        private void ll_accosearchback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_accomodations.Hide();
            p_showcustomer.Show();
        }

        private void ll_showaccoinfoback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_accomodations.Show();
            p_accomodationinfo.Hide();
        }

        private void ll_showbookingsback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_showbookings.Hide();
            p_showcustomer.Show();
        }

        private void ll_bookingdetailback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_accomodations.Show();
            p_bookingdetails.Hide();
        }

        private void b_editcustomer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (dg_customer.CurrentRow.Cells[2].Value.Equals(CustomerList[i].Surname))
                {
                    CurrentCustomer = CustomerList[i];
                }

            }
            if (CurrentCustomer != null)
            {
                AddCustomer ac = new AddCustomer(CurrentCustomer);
                ac.ShowDialog();
                showCust(Db.getAllCustomers());
            }
            else
                MessageBox.Show("Please select a customer first.");
        }

        private void b_showaccommodationdetails_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AllAccommodationsList.Count; i++)
            {
                if (dgv_searchaccomodation.CurrentRow.Cells[0].Value.Equals(AllAccommodationsList[i].Name) &&
                    dgv_searchaccomodation.CurrentRow.Cells[1].Value.Equals(AllAccommodationsList[i].Adress_city) &&
                    dgv_searchaccomodation.CurrentRow.Cells[3].Value.Equals(AllAccommodationsList[i].Adress_postcode))
                {
                    CurrentAccomodation = AllAccommodationsList[i];
                }
            }
            Form acc = new accomodationInfo(CurrentCustomer, CurrentAccomodation);
            acc.Show();
        }

    }
}
