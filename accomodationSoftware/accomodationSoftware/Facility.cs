using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    public class Facility : Institution
    {
        public string Type { get; set; }
        public string PicPath { get; set; }

        public Facility(string id, string type, string name, string city,string country, 
            string postcode, string street, string number, string info, string feedback, string pic)
            :base(id,city,name,country,postcode,street,number,info,feedback)
        {
            Type = type;
            PicPath = pic;
        }
    }
}
