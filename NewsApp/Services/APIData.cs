using NewsApp.MVVM.Models;
//using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json;

namespace NewsApp.Services
{
	public static class APIData{
	
		static HttpClient _client = new HttpClient();
		static JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
		{
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = true
		};
		public static Root Items { get; private set; }
		
		
			
		
		// public static async Task<Root> getNews(string newsTopic, string searchQuery)
		// {
  //
  //           var httpClient = new HttpClient();
  //           //httpClient.BaseAddress = new Uri("https://newsapi.org/v2/top-headlines");
  //
  //           if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet) return null;
  //           var address = $"https://newsapi.org/v2/top-headlines?country=us&apiKey=7f8e7406839542c58100a71392a34567&category={newsTopic}&q={searchQuery}";
  //               Console.WriteLine(address);
  //               var jsonData = await httpClient.GetFromJsonAsync<Root>($"https://newsapi.org/v2/top-headlines?country=us&apiKey=7f8e7406839542c58100a71392a34567");
  //               // var result = JsonConvert.DeserializeObject<Root>(jsonData);
  //               return jsonData;
  //
  //
		// }
		
		public static async Task<Root> getNews(string newsTopic, string searchQuery)
		{

			Uri uri = new Uri(string.Format($"https://gnews.io/api/v4/top-headlines?category={newsTopic}&lang=en&apikey=899f86129dcfbc7cf0809566cf8d3378&q={searchQuery}", string.Empty));
			try
			{
				HttpResponseMessage response = await _client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					string content = await response.Content.ReadAsStringAsync();
					var results = JsonSerializer.Deserialize<Root>(content, _serializerOptions);
					return results;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(@"\tERROR {0}", ex.Message);
			}

			return Items;
		}
    }
}

