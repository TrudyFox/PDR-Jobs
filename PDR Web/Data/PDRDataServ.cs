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
        private PDR_Jobs.Data dataBase;

        public PDR_Jobs.Data data { get; set; }

        public void load()
        {
            var mySerializer = new XmlSerializer(typeof(PDRDataServ));                         //this just loads the data into the database object
            using (var myFileStream = new FileStream("test.xml", FileMode.Open))        //this just loads the data into the database object
            {
                dataBase = (PDR_Jobs.Data)mySerializer.Deserialize(myFileStream);                    //this just loads the data into the database object
            }
        }
    } 
}
