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
            tech.Phone = Console.ReadLine();
            Console.WriteLine("Email");
            tech.Email = Console.ReadLine();

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
    }
}
