﻿using System;
using Newtonsoft.Json;

namespace JSONParser
{
    public class Video
    {
        public string Title { get; set; }

        public Link Link { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }

        public DateTime Published { get; set; }
    }
}
