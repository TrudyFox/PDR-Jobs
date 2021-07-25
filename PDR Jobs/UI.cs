using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDR_Jobs
{
    public static class UI
    {
        public static void PrintTechInfo(Tech t)
        {
            Console.WriteLine($"\ntech: \n\tFirst Name: {t.FirstName} \tLast Name: {t.LastName}  ");
            PrintAddress (t.Address);
            foreach (ContactInfo C in t.ContactInfos)
            {
                PrintContactInfo(C);
            }

        }

        public static void PrintBodyShopInfo(BodyShop bs)
        {
            Console.WriteLine($"bodyshop: Name: {bs.Name}");
            PrintAddress (bs.Address);
           //TODO: PrintContactInfo(bs.ContactInfos);
        }

        public static void PrintContactInfo(ContactInfo ct)
        {
            Console.WriteLine($"\nContact: Phone:{ct.PhoneNumer} \n\tEmail:{ct.Email}");
        }

        public static void PrintAddress(Address ad)
        {
            Console.WriteLine($"\tStreet Address: {ad.StreetAddress} \n\tCity: {ad.City} \n\tState: {ad.State} \tZip: {ad.ZipCode}");

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
            ContactInfo ct = InputContactInfoData();
            tech.ContactInfos.Add(ct);

            //  Profile page?

            return tech;
        }

        public static Address InputAddressData()
        {

            var Address = new Address();
            Console.WriteLine("Street Name");
            Address.StreetAddress = Console.ReadLine();
            Console.WriteLine("City");
            Address.City = Console.ReadLine();
            Console.WriteLine("State");
            Address.State = Console.ReadLine();
            Console.WriteLine("Zip Code");
            Address.ZipCode = Convert.ToInt32(Console.ReadLine());

            return Address;
        }

        public static BodyShop InputBodyShopData()
        {
            var BodyShop = new BodyShop();
            Console.WriteLine("Body shop name");
            BodyShop.Name = Console.ReadLine();
            BodyShop.Address = UI.InputAddressData();
            //ContactInfo ct = InputContactInfoData();            // one way to do it
            //BodyShop.ContactInfos.Add(ct);                      // one way to do it

            BodyShop.ContactInfos.Add(InputContactInfoData());  //the other way to do it, both does the same in the end
            Console.WriteLine("Split percentage");
            BodyShop.SplitPercentage = 0; //parsr from string :P 


            return BodyShop;

        }

        public static ContactInfo InputContactInfoData()
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
