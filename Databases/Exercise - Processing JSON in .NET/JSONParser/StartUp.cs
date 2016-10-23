using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONParser
{
    public class StartUp
    {
        public static void Main()
        {
            string downloadPath = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string xmlPath = "../../../used-files/rss-feed.xml";
            string jsonPath = "../../../used-files/rss-feed.json";
            string txtPath = "../../../used-files/videos-title.txt";
            string htmlPath = "../../../used-files/videos.html";

            DownloadRss(downloadPath, xmlPath);

            ParseXmlToJSON(xmlPath, jsonPath);

            var videos = SelectVideoTitles(jsonPath, txtPath);
            // In case that the console does not diplay you cyrilic symbols check the txt file.
            var htmlAsString = GenerateHtml(videos);

            File.WriteAllText(htmlPath, htmlAsString, Encoding.UTF8);
        }

        public static void DownloadRss(string downloadPath, string xmlPath)
        {
            var webClient = new WebClient();

            webClient.DownloadFile(downloadPath, xmlPath);
        }

        private static void ParseXmlToJSON(string xmlPath, string jsonPath)
        {
            var xml = File.ReadAllText(xmlPath);
            var doc = XDocument.Parse(xml);

            var json = JsonConvert.SerializeXNode(doc, Formatting.Indented);

            File.WriteAllText(jsonPath, json);
        }

        // The method extract videos to POCOs
        public static IEnumerable<Video> SelectVideoTitles(string jsonPath, string txtPath)
        {
            var json = File.ReadAllText(jsonPath);

            var jsonObj = JObject.Parse(json);

            var videos = jsonObj["feed"]["entry"].Select(e => JsonConvert.DeserializeObject<Video>(e.ToString()));

            var vids = new List<string>();

            foreach (var video in videos)
            {
                Console.WriteLine(video.Title);
                vids.Add(video.Title);
            }

            File.WriteAllLines(txtPath, vids);

            return videos;
        }
                
        private static string GenerateHtml(IEnumerable<Video> videos)
        {
            var str = new StringBuilder();

            str.Append("<!DOCTYPE html>");
            str.Append("<html><head><title>Telerik Latest Videos</title></head><body>");

            foreach (var video in videos)
            {
                str.AppendFormat(
                    "<div style=\"background:#d6e685; color:black; width:450px; padding:10px; margin:10px;\"><h3><a style=\"text-decoration:none; color:black;\" href=\"{0}\">{1}</a></h3><iframe width=\"420\" height=\"315\" src=\"http://www.youtube.com/embed/{2}?autoplay=0\"></iframe><h3>{3}</h3></div>",
                    video.Link.Href,
                    video.Title,
                    video.Id,
                    video.Published.ToShortDateString());
            }

            str.Append("</body></html>");
            return str.ToString();
        }
    }
}
