using System;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace XMLToJSON
{
    public class StartUp
    {
        public static void Main()
        {
            string xmlPath = "../../../usedfiles/catalog.xml";
            var xml = File.ReadAllText(xmlPath);
            var doc = XDocument.Parse(xml);
            var json = JsonConvert.SerializeXNode(doc, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}
