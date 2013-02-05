using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    class Customer
    {
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthday { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CardholderName { get; set; }
        public string Cardnumber { get; set; }
        public string Expiredate { get; set; } //not shure about the type


        public Customer()
        {

        }

        public Customer(string title, string surname, string firstname, DateTime birthday, string street,
            string postcode, string city, string country, string cardholder, string cardnumber, string expire)
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
            Expiredate = expire;
        }
    }
}
