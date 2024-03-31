using System;
using System.Collections.ObjectModel;
using NewsApp.MVVM.Models;
using NewsApp.Services;

namespace NewsApp.MVVM.ViewModels
{
	public class NewsViewModel
	{

		public List<Article> ArticleList { get; set; } = new List<Article>();


        public async Task<List<Article>> LoadNews(string newsCategory, string searchQuery)
        {
			var RootNews = await APIData.getNews(newsCategory,searchQuery);
			foreach(var item in RootNews.Articles)
			{
				ArticleList.Add(item);
			}
			return ArticleList;
        }
    }
}

