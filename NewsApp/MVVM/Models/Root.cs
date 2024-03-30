using System;
using Newtonsoft.Json;

namespace NewsApp.MVVM.Models
{
    public class Root
    {
        [JsonProperty("totalArticles")]
        public int TotalArticles { get; set; }

        [JsonProperty("articles")]
        public List<Article> Articles { get; set; }
    }
}

