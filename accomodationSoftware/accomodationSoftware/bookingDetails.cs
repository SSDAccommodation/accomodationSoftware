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
        public DateTime startD, endD;

        public List<DateTime> startDateRoom { get; set; }
        public List<DateTime> endDateRoom { get; set; }
        public List<int> roomId { get; set; }
        public Dictionary<int,int> rooms {get; set;}
        public int accommodation_id {get; set;}
        public int user_id { get; set; }

        public bookingDetails(int acc_id, int u_id)
        {
            InitializeComponent();
            startDateRoom = new List<DateTime>();
            endDateRoom = new List<DateTime>();
            roomId = new List<int>();
            rooms = new Dictionary<int, int>();
            accommodation_id = acc_id;
            user_id = u_id;

            dgv_bookings.ColumnCount = 2;
            dgv_bookings.Columns[0].Name = "Room ID";
            dgv_bookings.Columns[1].Name = "Room Number";
            dgv_bookings.Columns[0].Width = dgv_bookings.Width / 2 - 22;
            dgv_bookings.Columns[1].Width = dgv_bookings.Width / 2 - 21;

            try
            {
                // mario: i would like to put all db stuff into the db class
                SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
                connection.Open();


                SQLiteCommand cmd = new SQLiteCommand("select * from accommodations where acc_id =  " + accommodation_id, connection);
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read())
                    {

                        l_hotelName_bd.Text = reader.GetString(reader.GetOrdinal("acc_name"));
                    }

                connection.Close();
            }catch(Exception e){
                System.Console.WriteLine(e.ToString());
            }

        }

        private void bookingDetails_Load(object sender, EventArgs e)
        {
            dTP_startDate.Value = DateTime.Today;
            dTP_endDate.Value = DateTime.Today;
            startD = dTP_startDate.Value;
        }

        private void dTP_startDate_ValueChanged(object sender, EventArgs e)
        {
            startD = dTP_startDate.Value;
            if (endD < startD)
                dTP_endDate.Value = startD; 
            dbDateCheck();
        }

        private void dTP_endDate_ValueChanged(object sender, EventArgs e)
        {
            endD = dTP_endDate.Value;
            dbDateCheck();
        }
        private void dbDateCheck()
        {
            //Check Db for selected Date
            //SELECT startdate, enddate, beadnumber, romm_id FROM tourismus.rooms Where hotelID = XXX
            //       10-01-2013,12-01-2013, 2      , 101
            //       15-01-2013,20.01-2013, 3      , 102      rooms not yet booked (103,104,105)

            SQLiteConnection connection = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();


            SQLiteCommand cmd = new SQLiteCommand("select room_id, start_date, end_date from bookings where acc_id =  " + accommodation_id, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        roomId.Add(reader.GetInt32(reader.GetOrdinal("room_id")));
                        startDateRoom.Add(reader.GetDateTime(reader.GetOrdinal("start_date")));
                        endDateRoom.Add(reader.GetDateTime(reader.GetOrdinal("end_date")));                
                    }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            connection.Close();


            //SQLiteConnection connection2 = new SQLiteConnection("Data Source=tourismus.db");
            connection.Open();


            cmd = new SQLiteCommand("select room_id, room_number from rooms where acc_id =  " + accommodation_id, connection);
            reader = cmd.ExecuteReader();
            try
            {
                rooms.Clear();
                if (reader.HasRows)
                    while (reader.Read()) 
                    {
                        System.Console.WriteLine(reader.GetInt32(reader.GetOrdinal("room_id")) + "-" + reader.GetInt32(reader.GetOrdinal("room_number")));
                        rooms.Add(reader.GetInt32(reader.GetOrdinal("room_id")), reader.GetInt32(reader.GetOrdinal("room_number")));
                    } 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            try
            {
                connection.Close();

                DateTime roomDate = DateTime.Now;
                
                for (int i = 0; i < startDateRoom.Count; i++)
                {
                    for (DateTime rdate = startDateRoom[i]; rdate <= endDateRoom[i]; rdate = rdate.AddDays(1))
                    {
                        roomDate = rdate;
                        for (DateTime date = startD; date <= endD; date = date.AddDays(1))
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
                    System.Console.WriteLine("" + temp[i]+ " - " + temp2[i]);
                    dgv_bookings.Rows.Add(new string[]{""+temp[i],""+temp2[i]});
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
