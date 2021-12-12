using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PDR_Web.Data
{
    public class PDRDataServ
    {
         public PDR_Jobs.Data data { get; set; }

        public PDRDataServ()
        {
            var mySerializer = new XmlSerializer(typeof(PDR_Jobs.Data));                         //this just loads the data into the database object
            using (var myFileStream = new FileStream("DataStorage.xml", FileMode.Open))        //this just loads the data into the database object
            {
                data = (PDR_Jobs.Data)mySerializer.Deserialize(myFileStream);                    //this just loads the data into the database object
            }
        }

        
        public void PDRDataSave()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PDR_Jobs.Data));     //this just saves whaever is in database to test.xml
            TextWriter writer = new StreamWriter("test.xml");               //this just saves whaever is in database to test.xml
            serializer.Serialize(writer, data);
            
        }
    }

}
