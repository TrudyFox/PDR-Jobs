using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public class Address
    {
        public String HouseNumber;
        public String StreetName;
        public String City;
        public String State;
        public int ZipCode;
        public String GoogleMapsLink;
        public GPSLocation GPSLocation;  //can probably be generated automatically via google maps

    }
}
