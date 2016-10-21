using System;
using System.Collections.Generic;
using System.Xml;

namespace _03.XPathExtractArtists
{
    public class StartUp
    {
        public static void Main()
        {
            var path = "../../../UsedFiles/catalog.xml";
            var xPathQuery = "/albums/album/artist";

            var artistsInfo = GetArtistsInfo(path, xPathQuery);

            PrintArtistInfo(artistsInfo);
        }

        private static Dictionary<string, int> GetArtistsInfo(string path, string xPathQuery)
        {
            var artistsInfo = new Dictionary<string, int>();
            var doc = new XmlDocument();

            doc.Load(path);

            XmlNodeList node = doc.SelectNodes(xPathQuery);

            foreach (XmlNode artist in node)
            {
                var currentArtist = artist.InnerText;

                if (artistsInfo.ContainsKey(currentArtist))
                {
                    artistsInfo[currentArtist] += 1;
                }
                else
                {
                    artistsInfo.Add(currentArtist, 1);
                }
            }

            return artistsInfo;
        }

        private static void PrintArtistInfo(Dictionary<string, int> artistsInfo)
        {
            Console.WriteLine("XPath variant!");

            foreach (var artist in artistsInfo)
            {
                Console.WriteLine($"The artist {artist.Key} has {artist.Value} albums!");
            }
        }
    }
}
