using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public class ContactInfo
    {
        public string phoneNumber;
        public string email;

        public string PhoneNumber
        {
            get
            { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        public string Email
        {

            get
            { return email; }
            set
            {
                email = value;
            }
        }

            // add tostring

        }
}
