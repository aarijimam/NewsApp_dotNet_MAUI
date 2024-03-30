using System;
using Newtonsoft.Json;

namespace NewsApp.MVVM.Models
{
    public class Source
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

