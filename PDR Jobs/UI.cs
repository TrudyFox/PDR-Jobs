using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public static class UI
    {
        public static void PrintTechInfo(Tech tech)
        {
            Console.WriteLine($"tech: {tech.FirstName} {tech.LastName} - {tech.ProfilePage.Description}");
        }


        public static void PrintBodyShopInfo(BodyShop bodyShop)
        {
            //you implement that ! :)
        }

        public static Tech InputTechData()
        {
            var tech = new Tech();
            Console.WriteLine("First name:");
            tech.FirstName = Console.ReadLine();
            Console.WriteLine("Last name");
            tech.LastName = Console.ReadLine();
            Console.WriteLine("Address"); // can we do a mobile address or this needs to be easily changeable 
            tech.Address = InputAddressData();
            Console.WriteLine("Phone number");
          //  tech.Phone = Console.ReadLine();
            Console.WriteLine("Email");
        //    tech.Email = Console.ReadLine();

            //  Profile page?

            return tech;
        }

        public static Address InputAddressData()
        {

            var Address = new Address();
            Console.WriteLine("City:");
            Address.City = Console.ReadLine();
            Console.WriteLine("Street:");
            Address.StreetName = Console.ReadLine();

            return Address;
        }

        public static BodyShop InputBodyShopData()
        {
            var BodyShop = new BodyShop();
            Console.WriteLine("Body shop name");
            BodyShop.Name = Console.ReadLine();
            Console.WriteLine("Phone Number");
            //BodyShop.PhoneNumber = Console.ReadLine();
            //Console.WriteLine("Email Address");
            //BodyShop.EmailAddress = Console.ReadLine();
            BodyShop.Address = UI.InputAddressData();
            ContactInfo ct = InputContactInfoData();            // one way to do it
            BodyShop.ContactInfos.Add(ct);                      // one way to do it

            BodyShop.ContactInfos.Add(InputContactInfoData());  //the other way to do it, both does the same in the end
            Console.WriteLine("Split percentage");
            BodyShop.SplitPercentage = 0; //parsr from string :P 

            return BodyShop;

        }

        static ContactInfo InputContactInfoData()
        {
            var ContactInfo = new ContactInfo();
            Console.WriteLine("phone number");
            ContactInfo.PhoneNumer = Console.ReadLine();
            Console.WriteLine("Email Address");
            ContactInfo.Email = Console.ReadLine();

            return ContactInfo;

        }
    }
}
