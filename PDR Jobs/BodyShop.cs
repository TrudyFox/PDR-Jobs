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
        public List<ContactInfo> ContactInfos = new List<ContactInfo>();        
        public List<Damage> Damages = new List<Damage>();
        public String PhotoFile;
        public String HomePage; 

        public override string ToString()
        {
            return $"{Name} {Address}";
        }
    }
}
