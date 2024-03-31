using System;
using Newtonsoft.Json;

namespace NewsApp.MVVM.Models
{
    public class Root
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("articles")]
        public List<Article> Articles { get; set; }
    }
}

