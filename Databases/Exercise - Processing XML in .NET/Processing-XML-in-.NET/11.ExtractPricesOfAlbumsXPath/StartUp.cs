using System;
using System.Xml.Linq;
using System.Xml.XPath;

namespace _11.ExtractPricesOfAlbumsXPath
{
    public class StartUp
    {
        public static void Main()
        {
            string input = "../../../UsedFiles/catalog.xml";

            OldAlbumsXPath(5, input);
        }

        private static void OldAlbumsXPath(int years, string path)
        {
            Console.WriteLine("Old Albums XPath");
            var doc = XDocument.Load(path);

            string xPathAlbums = "catalog/albums";

            var albums = doc.XPathSelectElements(xPathAlbums);
            
            foreach (var album in albums)
            {
                var name = album.Element("name");

                if (name != null)
                {
                    var year = album.Element("year");
                    if (year != null)
                    {
                        if (int.Parse(year.Value) < DateTime.Now.AddYears(years * -1).Year)
                        {
                            var price = album.Element("price");
                            if (price != null)
                            {
                                Console.WriteLine($"Album: {name.Value}, Price: {price.Value}");
                            }
                        }
                    }
                }
            }
        }
    }
}
