using System;
using Newtonsoft.Json;

namespace NewsApp.MVVM.Models
{
    public class Source
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

