using System;
using System.Collections.Generic;
using System.Xml;

namespace _04.DeleteOverPricedAlbum
{
    public class StartUp
    {
        public static void Main()
        {
            string path = "../../../UsedFiles/catalog.xml";
            string newPath = "../../../UsedFiles/modified-catalog.xml";
            decimal maxPrice = 20.00m;

            Console.WriteLine("Original catalog!");
            Console.WriteLine(new string('-', 20));
            var originalArtistInfo = GetArtistInfo(path);
            PrintArtistsInfo(originalArtistInfo);

            DeleteOverPricedAlbum(path, newPath, maxPrice);

            Console.WriteLine("Modified catalog contains albums with price less than 20!");
            Console.WriteLine(new string('-', 30));
            var modifiedArtistInfo = GetArtistInfo(newPath);
            PrintArtistsInfo(modifiedArtistInfo);
        }

        private static void PrintArtistsInfo(Dictionary<string, int> artistsInfo)
        {
            foreach (var artist in artistsInfo)
            {
                Console.WriteLine($"The artist {artist.Key} has {artist.Value} albums!");
            }
        }

        private static void DeleteOverPricedAlbum(string path, string newPath, decimal maxPrice)
        {
            var artistsInfo = new Dictionary<string, int>();
            XmlDocument doc = new XmlDocument();

            doc.Load(path);

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode child in rootNode.ChildNodes)
            {
                decimal price = decimal.Parse(child["price"].InnerText);

                if (price > maxPrice)
                {
                    rootNode.RemoveChild(child);
                }
            }

            doc.Save(newPath);
        }

        private static Dictionary<string, int> GetArtistInfo(string path)
        {
            var doc = new XmlDocument();
            doc.Load(path);

            XmlNode rootNode = doc.DocumentElement;

            var artistInfo = new Dictionary<string, int>();

            foreach (XmlNode child in rootNode.ChildNodes)
            {
                var album = child;

                var currentArtist = album["artist"].InnerText;

                if (artistInfo.ContainsKey(currentArtist))
                {
                    artistInfo[currentArtist] += 1;
                }
                else
                {
                    artistInfo.Add(currentArtist, 1);
                }
            }

            return artistInfo;
        }
    }
}
