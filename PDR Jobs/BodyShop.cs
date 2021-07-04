using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    class BodyShop
    {
        public String Name;
        public Address Address;
        public String PhoneNumber;             //maybe sperate ContactInfo class?
        public String EmailAddress;            //maybe sperate ContactInfo class?
        public List<Damage> Damages;
        public double SplitPercentage;
        public String PhotoFile;

    }
}
