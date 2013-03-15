using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace accomodationSoftware
{
    public class Bookings
    {
        public Customer C { get; set; }
        public Accomodation A { get; set; }
        public string Name { get; set; }// not sure yet if accomodation object or just name
        public int Book_id { get; set; }
        public int Acc_id { get; set; }
        public int Room_id { get; set; }
        public int Room_number { get; set; }
        public string Start_date{ get; set; }
        public string End_date { get; set; }


        public Bookings(Customer c, Accomodation a, int book_id, int acc_id, int room_id, int room_number, string start_date, string end_date)
        {
            C = c;
            A = a;
            Book_id = book_id;
            Acc_id = acc_id;
            Room_id = room_id;
            Room_number = room_number;
            Start_date = start_date;
            End_date = end_date;
        }


        public Bookings(Customer c, string name, int book_id, int acc_id, int room_id, int room_number, string start_date, string end_date)
        {
            C = c;
            Name = name;
            Book_id = book_id;
            Acc_id = acc_id;
            Room_id = room_id;
            Room_number = room_number;
            Start_date = start_date;
            End_date = end_date;
        }


    }
}
