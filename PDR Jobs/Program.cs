using System;
using System.IO;
using System.Xml.Serialization;

namespace PDR_Jobs
{
   public class Program
    {
        static void Main(string[] args)
        {
            Data dataBase = new Data();

            var mySerializer = new XmlSerializer(typeof(Data));                         //this just loads the data into the database object
            using (var myFileStream = new FileStream("test.xml", FileMode.Open))        //this just loads the data into the database object
            {                                                                          
                dataBase = (Data)mySerializer.Deserialize(myFileStream);                    //this just loads the data into the database object
            }


            //welcomt to the pdr
            //options 1 to enter bodyshop
            //2 to enter tech details
            //3 to search for bodyshop by state

            //if selection = 1:
            //call ui method to get user input for bodyshopdata


            //some business logic:
            Console.WriteLine("please enter a name of a bodyshop to see if it exists in our database");
            string userInput = Console.ReadLine();

            if(DoesShopWithNameExist(dataBase,userInput))
            {
                Console.WriteLine("This shop is in the database");
            }
            else
            {
                Console.WriteLine("This shop is not in the database");
            }

            var test = new BodyShop();

            UI.PrintBodyShopInfo(test);

            XmlSerializer serializer = new XmlSerializer(typeof(Data));     //this just saves whaever is in database to test.xml
            TextWriter writer = new StreamWriter("test.xml");               //this just saves whaever is in database to test.xml
            serializer.Serialize(writer, dataBase);                         //this just saves whaever is in database to test.xml



           //if selection = 3
              //ui method that asks user for the state
              //businesss logic that searches
              //ui method to display the information

        }

        static void FindStormEventsNearMe()
        {
            //TODO: implement
        }

        static bool DoesShopWithNameExist(Data db, string theNameToLookFor)
        {
            bool doesExist = false;
            foreach (BodyShop shop in db.bodyShops)
            {
                if (shop.Name == theNameToLookFor)
                    doesExist = true;
            }

            return doesExist;
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
            Console.WriteLine("Split percentage");
            BodyShop.SplitPercentage = 0; //parsr from string :P 

            return BodyShop;

        }




    }
}   
