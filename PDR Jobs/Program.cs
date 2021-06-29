using System;

namespace PDR_Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        static Tech InputTechData()
        {
            var tech = new Tech();
            Console.WriteLine("First name:");
            tech.FirstName = Console.ReadLine();

            return tech;
        }

        static BodyShop InputBodyShopData()
        {
            //same as tech basically
            return null;
        }

        static void PrintTech(Tech tech)
        {
            Console.WriteLine($"tech: {tech.FirstName} {tech.LastName} - {tech.profilePage.Description}");
        }
    }
}
