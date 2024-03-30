using System;
using NewsApp.MVVM.Models;
using Newtonsoft.Json;

namespace NewsApp.Services
{
	public static class APIData
	{
		public static async Task<Root> getNews()
		{
			var httpClient = new HttpClient();
			var jsonData = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?category=general&apikey=899f86129dcfbc7cf0809566cf8d3378&lang=en");
			var result = JsonConvert.DeserializeObject<Root>(jsonData);
			return result;
		}
	}
}

