﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    class Address
    {
        public String State;
        public String HouseNumber;
        public String StreetName;
        public String GoogleMapsLink;
        public GPSLocation GPSLocation;  //can probably be generated automatically via google maps

    }
}