using NewsApp.MVVM.ViewModels;
using NewsApp.MVVM.Models;
using NewsApp.Services;

using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;



namespace NewsApp.MVVM.Views;


public partial class HomePage : ContentPage
{
    string selectedCategory { get; set; } = "general";
    string searchQuery { get; set; } = "";

	public HomePage()
	{
        On<iOS>().SetUseSafeArea(true);
        InitializeComponent();
        CategorySelectionView.BindingContext = new CategoryViewModel();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		CallAPI(selectedCategory,searchQuery);
		
	}

    private async void CallAPI(string v, string search_query)
    {
        ArticleList1.ItemsSource = await new NewsViewModel().LoadNews(v,searchQuery);
    }

    void CategorySelectionView_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
		var selectedItem = (e.CurrentSelection.FirstOrDefault()) as Category;
        selectedCategory = selectedItem.key;
        CallAPI(selectedItem.key,searchQuery);
    }

    void ArticleList1_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        var selectedItem = (e.CurrentSelection.FirstOrDefault()) as Article;
        Navigation.PushAsync(new DetailsPage(selectedItem));
    }

    private async void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        var item = sender as SwipeItem;
        if (item is null) return;

        var article = item.BindingContext as Article;
        if (article is null) return;

        //Favourites.addFavourite(article);
        await LocalDbService.createFavourite(article);
        await DisplayAlert("Favourite Added", "Article added to Favourites", "OK");
    }

    void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new FavouritesPage());
    }

    void SearchBar_SearchButtonPressed(System.Object sender, System.EventArgs e)
    {
        searchQuery = ((Microsoft.Maui.Controls.SearchBar)sender).Text;
        CallAPI(selectedCategory, searchQuery);
    }

    void SearchBar_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        if(((Microsoft.Maui.Controls.SearchBar)sender).Text == "")
        {
            searchQuery = "";
            CallAPI(selectedCategory, searchQuery);
        }

    }
}
