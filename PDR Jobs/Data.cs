using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    /// <summary>
    /// Responsible for storing and loading data
    /// </summary>
    
    public class Data
    {
        public List<BodyShop> bodyShops = new List<BodyShop>();
        public List<Tech> techs = new List<Tech>();
        public List<Address> address = new List<Address>();
        public List<ContactInfo> contacts = new List<ContactInfo>();
        public List<StormEvent> stormEvents = new List<StormEvent>();

    }
}
