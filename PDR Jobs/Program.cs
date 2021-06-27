using System;

namespace PDR_Jobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new BodyShop();
            var randomDude = new Tech();
            randomDude.FirstName = "Joe";
            randomDude.LastName = "doe";

            Console.WriteLine($"tech: {randomDude.FirstName} {randomDude.LastName} - {randomDude.profilePage.Description}");
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
    }
}
