using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    public class Customer
    {
        public int custi_id { get; set; } // for further need
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Birthday { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CardholderName { get; set; }
        public string Cardnumber { get; set; }
        public string Expiremonth { get; set; } 
        public string Expireyear { get; set; }

        public Customer()
        {

        }

        public Customer(string title, string surname, string firstname, string birthday, string street,
            string postcode, string city, string country, string cardholder, string cardnumber, string expiremonth, string expireyear)
        {
            Title = title;
            Surname = surname;
            Firstname = firstname;
            Birthday = birthday;
            Street = street;
            Postcode = postcode;
            City = city;
            Country = country;
            CardholderName = cardholder;
            Cardnumber = cardnumber;
            Expiremonth = expiremonth;
            Expireyear = expireyear;
        }
    }
}
