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

            //test code:


            //Console.WriteLine("This is the tech info after entereing it:");
            //UI.PrintTechInfo(aTech);

            //Console.WriteLine("Now we're at a pint where we want to update this tech's adress");

            //aTech.Address = UI.InputAddressData();

            //Console.WriteLine("This is the thech indo after inputting a new adress");

            //UI.PrintTechInfo(aTech);

            //Tech T = UI.InputTechData();

            //dataBase.techs.Add(T);
            //   UI.PrintTechInfo(T);

            //print all techs names:
            Console.WriteLine($"We have {dataBase.techs.Count} Techs in the database");

            foreach (Tech t in dataBase.techs)
            {
                if (t.FirstName == "joe")
                {
                    Console.WriteLine("We found joe!, here are his details:");
                    UI.PrintTechInfo(t);

                    t.ContactInfos.Add(UI.InputContactInfoData());
                }
            }

            foreach (Tech t in dataBase.techs)
            {
                Console.WriteLine($"{t.FirstName} { t.LastName}");
            }

            //if(T.Address.State == "Texas")
            //{
            //    Console.WriteLine("Sorry no service for you");
            //}

            // dataBase.techs.Add(T);


            Console.WriteLine("PDR JOBS");

            Console.WriteLine("If you are a bodyshop enter 1");
            Console.WriteLine("If you are a tech enter 2");
            Console.WriteLine("To list all techs enter 3");
            Console.WriteLine("To search for a bodyshop by state enter 4");

            {
                int userinput = int.Parse(Console.ReadLine());


                switch (1)
                {
                    case 1:
                        BodyShop aBodyShop = new BodyShop();
                        aBodyShop = UI.InputBodyShopData();
                        break;

                    case 2:
                        Tech aTech = new Tech();
                        aTech = UI.InputTechData();
                        break;

                    case 3:





                }



            }


            //options 1 to enter bodyshop
            //2 to enter tech details
            //3 to search for bodyshop by state


            //if selection = 1:
            //call ui method to get user input for bodyshopdata


            //some business logic:


            XmlSerializer serializer = new XmlSerializer(typeof(Data));     //this just saves whaever is in database to test.xml
            TextWriter writer = new StreamWriter("test.xml");               //this just saves whaever is in database to test.xml
            serializer.Serialize(writer, dataBase);                         //this just saves whaever is in database to test.xml



            //if selection = 3
            //ui method that asks user for the state
            //businesss logic that searches
            //ui method to display the information

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






    }
}
