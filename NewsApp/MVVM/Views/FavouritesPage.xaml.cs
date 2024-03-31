using NewsApp.MVVM.Models;
using NewsApp.Services;
namespace NewsApp.MVVM.Views;

public partial class FavouritesPage : ContentPage
{
    
    public FavouritesPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //ArticleList1.ItemsSource = Favourites.favouritesList;
        Task.Run(async () => ArticleList1.ItemsSource = await LocalDbService.getFavourites());

    }

    void ArticleList1_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        var selectedArticleDB = (e.CurrentSelection.FirstOrDefault()) as ArticleDB;
        var selectedItem = new Article
        {
            Author = selectedArticleDB.Author,
            Title = selectedArticleDB.Title,
            Description = selectedArticleDB.Description,
            Image = selectedArticleDB.Image,
            Url = selectedArticleDB.Url,
            PublishedAt = selectedArticleDB.PublishedAt,
            Content = selectedArticleDB.Content,
        };
        Navigation.PushAsync(new DetailsPage(selectedItem));
    }

    async void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        var item = sender as SwipeItem;
        if (item is null) return;

        var article = item.BindingContext as ArticleDB;
        if (article is null) return;

        //Favourites.removeFavourite(article);
        await LocalDbService.deleteFavourite(article);
        ArticleList1.ItemsSource = await LocalDbService.getFavourites();
        await DisplayAlert("Favourite Removed", "Article removed from Favourites", "OK");
    }
}
