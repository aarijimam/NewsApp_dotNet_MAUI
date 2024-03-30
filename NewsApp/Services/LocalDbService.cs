using System;
using NewsApp.MVVM.Models;
using SQLite;

namespace NewsApp.Services
{
	public static class LocalDbService
	{
		private const string DB_NAME = "favourites_db.db3";
		private static  SQLiteAsyncConnection dB;

		static async Task Init()
		{
			if (dB != null) return;
			 dB = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
			await dB.CreateTableAsync<ArticleDB>();
		}

		public static async Task<IEnumerable<ArticleDB>> getFavourites(){
			await Init();
			return await dB.Table<ArticleDB>().ToListAsync();
		}

		public static async Task createFavourite(Article article)
		{
			await Init();

			var articleToAdd = new ArticleDB
			{
			Author = article.Author,
			Title = article.Title,
			Description = article.Description,
			Image = article.Image,
			Url = article.Url,
			PublishedAt = article.PublishedAt,
			Content = article.Content,
			};
            var id = await dB.InsertAsync(articleToAdd);
		}

		public static async Task deleteFavourite(ArticleDB article)
		{
            await Init();
            await dB.DeleteAsync(article);
		}
	}
}

