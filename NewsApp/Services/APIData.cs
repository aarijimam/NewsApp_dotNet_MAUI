using NewsApp.MVVM.Models;
using Newtonsoft.Json;

namespace NewsApp.Services
{
    public static class APIData
	{
		public static async Task<Root> getNews(string newsTopic, string searchQuery)
		{

            var httpClient = new HttpClient();

            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet) return null;

            if (newsTopic == "all")
			{
                var jsonData = await httpClient.GetStringAsync("https://newsapi.org/v2/top-headlines?country=us&apiKey=7f8e7406839542c58100a71392a34567" + "&q=" + searchQuery);
                var result = JsonConvert.DeserializeObject<Root>(jsonData);
                return result;
            }
			else {
				var jsonData = await httpClient.GetStringAsync("https://newsapi.org/v2/top-headlines?country=us&apiKey=7f8e7406839542c58100a71392a34567&category=" + newsTopic + "&q=" + searchQuery);
                var result = JsonConvert.DeserializeObject<Root>(jsonData);
                return result;
            }

            
		}
    }
}

