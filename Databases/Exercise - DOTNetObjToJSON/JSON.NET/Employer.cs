using Newtonsoft.Json;

namespace JSON.NET
{
    public class Employer
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
