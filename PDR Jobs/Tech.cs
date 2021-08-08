using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public class Tech
    {
        public String FirstName;
        public String LastName;
        public Address Address = new Address();
        public List<ContactInfo> ContactInfos = new List<ContactInfo>();
        public ProfilePage ProfilePage = new ProfilePage();

        public String FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
