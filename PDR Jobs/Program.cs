

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


            Console.WriteLine("PDR JOBS");

            Console.WriteLine("If you are a bodyshop enter 1");
            Console.WriteLine("If you are a tech enter 2");
            Console.WriteLine("To list all techs enter 3");
            Console.WriteLine("To search for a bodyshop by state enter 4");
            Console.WriteLine("Tos search for a bodyshop by name enter 5");
            Console.WriteLine("To search for a tech by name enter 6");
            Console.WriteLine("To post new jobs enter 7");

            //case 7: add new damage to bodyshop
            //selecting one specific bodyshop (by searching by name, or by displaying them all and selecting by number)
            // foundbodyshop variable
            // foundbodyshop.damages.add(UI.InputDamage())


            {
                int userinput = int.Parse(Console.ReadLine());


                switch (userinput)
                {
                    case 1:
                        BodyShop aBodyShop = new BodyShop();
                        aBodyShop = UI.InputBodyShopData();
                        dataBase.bodyShops.Add(aBodyShop);
                        break;

                    case 2:
                        Tech aTech = new Tech();
                        aTech = UI.InputTechData();
                        dataBase.techs.Add(aTech);
                        break;

                    case 3:
                        Console.WriteLine($"We have {dataBase.techs.Count} Techs in the database");
                        foreach (Tech t in dataBase.techs)
                        {
                            Console.WriteLine($"{t.FirstName} { t.LastName}");
                        }
                        break;
                        
                    case 4:
                        string stateInput = Console.ReadLine();
                        foreach (BodyShop bs in dataBase.bodyShops)
                        {
                            if (bs.Address.State.ToUpper().Contains(stateInput.ToUpper()))
                                Console.WriteLine($"{bs.Name}");               
                       }
                        break;

                    case 5:
                        string SearchBS = Console.ReadLine();
                        foreach (BodyShop bodyshop in dataBase.bodyShops)

                        {
                            if (bodyshop.Name.ToUpper().Contains(SearchBS.ToUpper()))
                                UI.PrintBodyShopInfo(bodyshop);
                        }
                        break;

                    case 6:
                        string SearchTech = Console.ReadLine();
                        foreach (Tech tech in dataBase.techs)
                        {
                            if (tech.FullName.ToUpper().Contains(SearchTech.ToUpper()))
                                UI.PrintTechInfo(tech);
                        }
                        break;

                    case 7:

                        string SBS = Console.ReadLine();
                        foreach (BodyShop bodyshop in dataBase.bodyShops)

                        {
                            if (bodyshop.Name.ToUpper().Contains(SBS.ToUpper()))
                                UI.PrintBodyShopInfo(bodyshop);
                            var foundBodyShop = bodyshop;
                            foundBodyShop.Damages.Add(UI.InputDamageInfo());    
                        }
                        break;
                }


                //test code:


                //Console.WriteLine("This is the tech info after entereing it:");
                //UI.PrintTechInfo(aTech);

                //Console.WriteLine("Now we're at a pint where we want to update this tech's adress");

                //aTech.Address = UI.InputAddressData();

                //Console.WriteLine("This is the thech indo after inputting a new adress");

                //UI.PrintTechInfo(aTech);

                Tech T = UI.InputTechData();

                dataBase.techs.Add(T);
                UI.PrintTechInfo(T);

                //print all techs names:

                foreach (Tech t in dataBase.techs)
                {
                    if (t.FirstName == "joe")
                    {
                        Console.WriteLine("We found joe!, here are his details:");
                        UI.PrintTechInfo(t);

                        t.ContactInfos.Add(UI.InputContactInfoData());
                    }
                }

                if (T.Address.State == "Texas")
                {
                    Console.WriteLine("Sorry no service for you");
                }

                dataBase.techs.Add(T);


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
