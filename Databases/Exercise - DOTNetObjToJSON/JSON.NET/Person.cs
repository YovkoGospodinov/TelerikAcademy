using Newtonsoft.Json;

namespace JSON.NET
{
    public class Person
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("employer")]
        public Employer Employer { get; set; }
    }
}
