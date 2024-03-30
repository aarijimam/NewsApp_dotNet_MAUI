using NewsApp.MVVM.ViewModels;
using NewsApp.MVVM.Models;

namespace NewsApp.MVVM.Views;


public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        CategorySelectionView.BindingContext = new CategoryViewModel();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		CallAPI("general");
		
	}

    private async void CallAPI(string v)
    {
        ArticleList1.ItemsSource = await new NewsViewModel().LoadNews(v);
    }

    void CategorySelectionView_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
		var selectedItem = (e.CurrentSelection.FirstOrDefault()) as Category;
		CallAPI(selectedItem.key);
    }
}
