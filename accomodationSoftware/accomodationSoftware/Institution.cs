using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    public abstract class Institution
    {
        public string Name { get; set; }

        public string Adress_city { get; set; }
        public string Adress_county { get; set; }
        public string Adress_postcode { get; set; }
        public string Adress_street { get; set; }
        public string Adress_number { get; set; }

        public string Description { get; set; }
        public string Feedback { get; set; }

        public void giveFeedback() { }

        public Institution(string city, string name, string addcount, string postcode, string street, string number, string description, string feedback)
        {
            Name = name;
            Adress_city = city;
            Adress_county = addcount;
            Adress_postcode = postcode;
            Adress_street = street;
            Adress_number = number;
            Description = description;
            Feedback = feedback;
        }

        public Institution()
        {

        }

    }
}
