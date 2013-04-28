using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    public class Accomodation : Institution
    {
        

        
        public int Stars { get; set; }
        public string Picture { get; set; }
        //bookings still missing which type?
        public string Picture_url { get; set; }

        public Accomodation(string id, string name, string adress_city, string adress_county, string adress_postcode, string adress_street, string adress_number, string description, string picture_url,string feedback)
            :base(id, adress_city, name, adress_county, adress_postcode, adress_street, adress_number, description,feedback)
        {
            // TODO: Complete member initialization
            this.Picture_url = picture_url;
        }
        public void booking()
        {

        }
        public void giveFeedback()
        {

        }
    }
}
