using NewsApp.MVVM.Models;
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
        ArticleList1.ItemsSource = Favourites.favouritesList;

    }

    void ArticleList1_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        var selectedItem = (e.CurrentSelection.FirstOrDefault()) as Article;
        Navigation.PushAsync(new DetailsPage(selectedItem));
    }

    async void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        var item = sender as SwipeItem;
        if (item is null) return;

        var article = item.BindingContext as Article;
        if (article is null) return;

        Favourites.removeFavourite(article);
        await DisplayAlert("Favourite Removed", "Article removed from Favourites", "OK");
    }
}
