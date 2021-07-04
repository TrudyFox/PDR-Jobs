using System;
using System.IO;
using System.Xml.Serialization;

namespace PDR_Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Data dataBase = new Data();

            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            TextWriter writer = new StreamWriter("test.xml");
            serializer.Serialize(writer, dataBase);



            //welcomt to the pdr
            //options 1 to enter bodyshop
            //2 to enter tech details
            //3 to search for bodyshop by state

            //if selection = 1:
            //call ui method to get user input for bodyshopdata


            BodyShop newBodyShop = InputBodyShopData();

            dataBase.bodyShops.Add(newBodyShop);

           //if selection = 3
              //ui method that asks user for the state
              //businesss logic that searches
              //ui method to display the information

        }

        static Tech InputTechData()
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

        static BodyShop InputBodyShopData()
        {
            var BodyShop = new BodyShop();
            Console.WriteLine("Body shop name");
            BodyShop.Name = Console.ReadLine();
            Console.WriteLine("Phone Number");
            BodyShop.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Email Address");
            BodyShop.EmailAddress = Console.ReadLine();

            return BodyShop;

        }

        static Address InputAddressData()
        {
      
            var Address = new Address();
            Console.WriteLine("City:");
            Address.City = Console.ReadLine();
            Console.WriteLine("Street:");
            Address.StreetName = Console.ReadLine();
            
            return Address;
        }

        static void PrintTech(Tech tech)
        {
            Console.WriteLine($"tech: {tech.FirstName} {tech.LastName} - {tech.ProfilePage.Description}");
        }
    }
}   
