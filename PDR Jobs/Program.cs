

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace PDR_Jobs
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dataBase = new Data();

            var mySerializer = new XmlSerializer(typeof(Data));                         //this just loads the data into the database object
            using (var myFileStream = new FileStream("test.xml", FileMode.Open))        //this just loads the data into the database object
            {
                dataBase = (Data)mySerializer.Deserialize(myFileStream);                    //this just loads the data into the database object
            }


            ///html test here
            var stateIndexLink = @"https://auto-body-shops.regionaldirectory.us/";


            HtmlWeb web = new HtmlWeb();

            var stateIndexDoc = web.Load(stateIndexLink);



            var stateLinkNodes = stateIndexDoc.DocumentNode.SelectNodes("//td/div[@class='o']/a");

            List<string> statePageLinks = new List<string>();


            for (int i = 0; i < stateLinkNodes.Count; i++)
            {
                HtmlNode stateLinkNode = stateLinkNodes[i];
                Console.WriteLine(stateLinkNode.InnerHtml);

                var statePageLink = stateLinkNode.Attributes["href"].Value;

                statePageLinks.Add(statePageLink);
            }

            //    var StateNodes = stateIndexDoc.DocumentNode.SelectNodes("/html/body/table[@id='top']/tr[4]/td[@class='b']/li/table[@class='b']/tbody/tr[4]/td[1]");
            foreach (string statePageLink in statePageLinks)
            {
                var stateDoc = web.Load(statePageLink);
                var bsNodes = stateDoc.DocumentNode.SelectNodes("//table[@class='b']/tr[position() mod 2 = 0]/td[1]"); // selects each table element containing the bodyshop info
                //HtmlNode h2Node = bsNode.ChildNodes["//tr[2]/td[1][1]"];

                foreach (var bsNode in bsNodes)
                {
                    var bs = new BodyShop();
                    var bsLinkNode = bsNode.SelectSingleNode(".//a[1]");
                    var bsName = bsLinkNode.InnerHtml;
                    var bsLink = bsLinkNode.Attributes["href"].Value;
                    var bsAdressLinkNode = bsNode.SelectSingleNode(".//a[2]");
                    

                    var cI = GetContactInfo(bsNode);
                    

                    bs.Name = bsName;
                    bs.HomePage = bsLink;
                    bs.ContactInfos.Add(cI);
                  
                    if (bsAdressLinkNode != null)
                    {
                        var bsAdressLink = bsAdressLinkNode.Attributes["href"].Value;
                        Address bsAdress = GetAdressFromLink(bsAdressLink);
                        bs.Address = bsAdress;

                    }

                    dataBase.bodyShops.Add(bs);

                }
            }


            //var bsLink = stateDoc.DocumentNode.SelectNodes("//tr[2]/td[1]/a[1]");
            //var bsPhoneAddressLk = stateDoc.DocumentNode.SelectNodes("//tr[2]/td[1]/a[2]");

            //create a new bodyshop object
            //assign all those stings to the bodyshops fields

            //Add
            //this bodyshop to the database




            ///end html test code





            Console.WriteLine("PDR JOBS");

            Console.WriteLine("If you are a bodyshop enter 1");
            Console.WriteLine("If you are a tech enter 2");
            Console.WriteLine("To list all techs enter 3");
            Console.WriteLine("To search for a bodyshop by state enter 4");
            Console.WriteLine("Tos search for a bodyshop by name enter 5");
            Console.WriteLine("To search for a tech by name enter 6");
            Console.WriteLine("To post new jobs enter 7");


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
                            {
                                UI.PrintTechInfo(tech);
                            }
                        }
                        break;

                    case 7:
                        Console.WriteLine("enter bodyshop name");
                        string SBS = Console.ReadLine();
                        foreach (BodyShop bodyshop in dataBase.bodyShops)
                        
                        {
                            if (bodyshop.Name.ToUpper().Contains(SBS.ToUpper()))
                            {
                                UI.PrintBodyShopInfo(bodyshop);
                                var foundBodyShop = bodyshop;
                                foundBodyShop.Damages.Add(UI.InputDamageInfo());
                            }
                        }
                        break;

                    default:
                        break;
                }

                //Console.WriteLine("Now we're at a pint where we want to update this tech's adress");

                //aTech.Address = UI.InputAddressData();

                //Console.WriteLine("This is the thech indo after inputting a new adress");

                //UI.PrintTechInfo(aTech);

                //Tech T = UI.InputTechData();

                //dataBase.techs.Add(T);
                //UI.PrintTechInfo(T);

                ////print all techs names:

                //foreach (Tech t in dataBase.techs)
                //{
                //    if (t.FirstName == "joe")
                //    {
                //        Console.WriteLine("We found joe!, here are his details:");
                //        UI.PrintTechInfo(t);

                //        t.ContactInfos.Add(UI.InputContactInfoData());
                //    }
                //}

                //if (T.Address.State == "Texas")
                //{
                //    Console.WriteLine("Sorry no service for you");
                //}

                //dataBase.techs.Add(T);


            }


            //some business logic:


            XmlSerializer serializer = new XmlSerializer(typeof(Data));     //this just saves whaever is in database to test.xml
            TextWriter writer = new StreamWriter("test.xml");               //this just saves whaever is in database to test.xml
            serializer.Serialize(writer, dataBase);                         //this just saves whaever is in database to test.xml

            //if selection = 3
            //ui method that asks user for the state
            //businesss logic that searches
            //ui method to display the information

        }

        private static ContactInfo GetContactInfo(HtmlNode bsNode)
        {
            ContactInfo cI = new ContactInfo();

            var bsPhoneAllText = bsNode.InnerHtml;
            var bsAllTextSplit = bsPhoneAllText.Split("<br>");
            var bsPhone = bsAllTextSplit[2].Trim();

            cI.PhoneNumer = bsPhone;

            return cI;
     
        }

        private static Address GetAdressFromLink(string bsAdressLink)
        {
            HtmlWeb web = new HtmlWeb();

            var bsAdressPage = web.Load(bsAdressLink);
            var bsAdressTextNode = bsAdressPage.DocumentNode.SelectSingleNode("/html/body/table[@id='zbt']/tr[5]/td/div[@class='b'][2]");


            var bsAdressText = bsAdressTextNode.InnerText;
            var innerText = bsAdressTextNode.InnerText;
            var AddressSplitA = innerText.Split("is");
            var AddressSplitB = AddressSplitA[1].Split("&");

            var zipCode = AddressSplitB[1].Replace("nbsp; ", "").Replace(".","");

            var address = new Address();

            address.ZipCode = int.Parse(zipCode);
            //TODO: assign the correct values to the adress object
            return address;

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
