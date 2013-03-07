using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accomodationSoftware
{
    public partial class bookingDetails : Form
    {
        public DateTime StartD { get; set; }
        public DateTime EndD { get; set; }
        public List<DateTime> startDateRoom { get; set; }
        public List<DateTime> endDateRoom { get; set; }
        public List<int> roomId { get; set; }
        public Dictionary<int,int> rooms {get; set;}
        public string accommodation_id {get; set;}
        public int user_id { get; set; }
        public Customer CurrentCustomer { get; set; }
        public Accomodation CurrentAccomodation { get; set; }
        public Db Database { get; set; }

        public bookingDetails(Accomodation a, Customer c)
        {
            InitializeComponent();
            startDateRoom = new List<DateTime>();
            endDateRoom = new List<DateTime>();
            roomId = new List<int>();
            rooms = new Dictionary<int, int>();
            accommodation_id = a.ID;
            user_id = c.custi_id;
            Database = new Db();
            dgv_bookings.ColumnCount = 2;
            dgv_bookings.Columns[0].Name = "Room ID";
            dgv_bookings.Columns[1].Name = "Room Number";
            dgv_bookings.Columns[0].Width = dgv_bookings.Width / 2 - 22;
            dgv_bookings.Columns[1].Width = dgv_bookings.Width / 2 - 21;
            l_hotelName_bd.Text = Database.getHotelNameDb(accommodation_id);
            

        }

        private void bookingDetails_Load(object sender, EventArgs e)
        {
            dTP_startDate.Value = DateTime.Today;
            dTP_endDate.Value = DateTime.Today;
            StartD = dTP_startDate.Value;
        }

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
            //SELECT startdate, enddate, beadnumber, romm_id FROM tourismus.rooms Where hotelID = XXX
            //       10-01-2013,12-01-2013, 2      , 101
            //       15-01-2013,20.01-2013, 3      , 102      rooms not yet booked (103,104,105)
            roomId = Database.getBookingRoomId(accommodation_id);
            startDateRoom = Database.getbookingStartDateRoom(accommodation_id);
            endDateRoom = Database.getbookingEndDateRoom(accommodation_id);
            rooms = Database.getBookingRooms(accommodation_id);
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
                populateLV();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void populateLV()
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
                    dgv_bookings.Rows.Add(new string[]{""+temp[i],""+temp2[i]});
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void b_bookselected_Click(object sender, EventArgs e)
        {
            this.Hide();
            Details det = new Details(CurrentCustomer,CurrentAccomodation,StartD,EndD,dgv_bookings.CurrentRow.Cells[0].Value.ToString());
            det.Show();
        }
    }
}
