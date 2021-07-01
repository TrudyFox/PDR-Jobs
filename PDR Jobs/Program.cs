using System;

namespace PDR_Jobs
{
    class Program
    {
        static void Main(string[] args)
        { 
        }
        static Tech InputTechData()
        {
            var tech = new Tech();
            Console.WriteLine("First name:");
            tech.FirstName = Console.ReadLine();
            Console.WriteLine("Last name");
            tech.LastName = Console.ReadLine();
            Console.WriteLine("Address"); // can we do a mobile address or this needs to be easily changeable 
            tech.Address = Console.ReadLine();
            Console.WriteLine("Phone number");
            tech.Phone = Console.ReadLine();
            Console.WriteLine("Email");
            tech.email = Console.ReadLine();
             
            //  Profile page?

            return tech;
        }

        static BodyShop InputBodyShopData()
        {
            var BodyShop = new BodyShop();
            Console.WriteLine("Body shop name");
            BodyShop.Name = Console.ReadLine();
            Console.WriteLine("Address");
            BodyShop.Address = Console.ReadLine();
            Console.WriteLine("Phone Number");
            BodyShop.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Email Address");
            BodyShop.EmailAdress = Console.ReadLine();

            return BodyShop;

        }

        static void PrintTech(Tech tech)
        {
            Console.WriteLine($"tech: {tech.FirstName} {tech.LastName} - {tech.profilePage.Description}");
        }
    }
}
