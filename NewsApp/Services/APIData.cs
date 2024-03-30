using System;
using NewsApp.MVVM.Models;
using Newtonsoft.Json;

namespace NewsApp.Services
{
	public static class APIData
	{
		public static async Task<Root> getNews(string newsTopic)
		{
			var httpClient = new HttpClient();
			var jsonData = await httpClient.GetStringAsync("https://newsapi.org/v2/top-headlines?country=us&apiKey=7f8e7406839542c58100a71392a34567&category="+newsTopic);

            var result = JsonConvert.DeserializeObject<Root>(jsonData);
			return result;
		}
	}
}

