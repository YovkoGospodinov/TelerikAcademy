using System;
using System.Collections.Generic;
using System.Xml;

namespace _05.XmlReaderExtractsSongTitles
{
    public class StartUp
    {
        public static void Main()
        {
            string path = "../../../UsedFiles/catalog.xml";

            XmlReader reader = XmlReader.Create(path);

            Console.WriteLine("Songs titles:");

            using (reader)
            {
                while (reader.Read())
                {
                    if ((reader.Name == "title") && (reader.NodeType == XmlNodeType.Element))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
