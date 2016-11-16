using Newtonsoft.Json;
using System.Collections;
using System.IO;

namespace SocialNetwork.ConsoleClient
{
    public class JsonWriter
    {
        private static void WriteToFile(IEnumerable collection, string path)
        {
            foreach (var entry in collection)
            {
                var json = JsonConvert.SerializeObject(entry, Formatting.Indented);

                File.WriteAllText(path, json);
            }
        }
    }
}
