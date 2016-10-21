using System;
using System.Collections.Generic;
using System.Xml;

namespace _02.ExtractArtists
{
    public class StartUp
    {
        public static void Main()
        {
            var path = "../../../UsedFiles/catalog.xml";
            
            var artistsInfo = GetArtistInfo(path);

            PrintArtistsInfo(artistsInfo);
        }

        private static void PrintArtistsInfo(Dictionary<string, int> artistsInfo)
        {
            foreach (var artist in artistsInfo)
            {
                Console.WriteLine($"The artist {artist.Key} has {artist.Value} album in the current catalog!");
            }
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