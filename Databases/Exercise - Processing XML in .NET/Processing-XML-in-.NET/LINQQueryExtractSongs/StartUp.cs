using System;
using System.Linq;
using System.Xml.Linq;

namespace _06.LINQQueryExtractSongs
{
    public class StartUp
    {
        public static void Main()
        {
            string path = "../../../UsedFiles/catalog.xml";
            ExtractSongsNameLinq(path);
        }

        private static void ExtractSongsNameLinq(string path)
        {
            var xml = XDocument.Load(path);

            var albums = xml.Element("albums")
                .Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            Console.WriteLine("Songs titles:");

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
