using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    class Facility : Institution
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string PicPath { get; set; }
        public string Address { get; set; }
        public string Information { get; set; }
        public string Feedback { get; set; }

        public Facility(string id, string type, string name, string address, string info, string feedback, string pic)
        {
            ID = id;
            Type = type;
            Address = address;
            Information = info;
            Feedback = feedback;
            PicPath = pic;
        }
    }
}
