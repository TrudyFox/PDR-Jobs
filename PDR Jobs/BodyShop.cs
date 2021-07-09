using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public class BodyShop
    {
        public String Name;
        public Address Address;
        public List<Contacts> ContactInfo;        //maybe sperate ContactInfo class?
        public List<Damage> Damages;
        public double SplitPercentage;
        public String PhotoFile;

    }
}
