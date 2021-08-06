using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public class Address
    {
       
        public String StreetAddress;
        public String City;
        public String State;
        public int ZipCode;
        public String GoogleMapsLink;
        public GPSLocation GPSLocation;  //can probably be generated automatically via google maps      

        public override string ToString()
        {
            return $"{StreetAddress} {City} {State} {ZipCode}";
        }

        public String GetGoogleMapsLink()
        {
            //magic code

            //go to goole api
            string googleAPIqueryFormat = $"{City} {StreetAddress} ";
            Console.WriteLine($"I'm the Adress Object, and currently doing magic google lookups with this string: {googleAPIqueryFormat}");    //placeholder
            return "cool google maps link";                                                          //placeholder

        }

    }
}
