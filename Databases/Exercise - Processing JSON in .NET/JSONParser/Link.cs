using Newtonsoft.Json;

namespace JSONParser
{
    public class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
