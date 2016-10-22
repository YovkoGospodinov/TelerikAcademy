using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace _16.ValidateXML
{
    public class StartUp
    {
        private static void Main()
        {
            var xmlSchema = new XmlSchemaSet();
            xmlSchema.Add(string.Empty, "../../../UsedFiles/catalog.xsd");

            XDocument doc = XDocument.Load("../../../UsedFiles/catalog.xml");
            XDocument doc1 = XDocument.Load("../../../UsedFiles/invalid-catalog.xml");

            PrintValidationResult(doc, xmlSchema);
            Console.WriteLine(new string('-', 20));
            PrintValidationResult(doc1, xmlSchema);
        }

        private static void PrintValidationResult(XDocument doc, XmlSchemaSet xmlSchema)
        {
            bool errors = false;
            doc.Validate(xmlSchema, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            }, true);
            Console.WriteLine("doc {0}\n", errors ? "did not validate" : "validated");
        }
    }
}
