using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accomodationSoftware
{
    abstract class Institution
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Information { get; set; }
        public string Feedback { get; set; }

        public void giveFeedback() { }
    }
}
