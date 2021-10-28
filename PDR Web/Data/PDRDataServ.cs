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

        public void Load()
        {
            var mySerializer = new XmlSerializer(typeof(PDR_Jobs.Data));                         //this just loads the data into the database object
            using (var myFileStream = new FileStream("DataStorage.xml", FileMode.Open))        //this just loads the data into the database object
            {
                data = (PDR_Jobs.Data)mySerializer.Deserialize(myFileStream);                    //this just loads the data into the database object
            }
        }
    } 
}
