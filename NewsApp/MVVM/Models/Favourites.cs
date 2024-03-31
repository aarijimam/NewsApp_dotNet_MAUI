using System;
using System.Collections.ObjectModel;
namespace NewsApp.MVVM.Models
{
	public static class Favourites
	{
        public static ObservableCollection<Article> favouritesList { get; set; } = new ObservableCollection<Article>();

		public static void addFavourite(Article article)
		{
			favouritesList.Add(article);
		}

		public static void removeFavourite(Article article)
		{
			favouritesList.Remove(article);
		}
		
	}
}

