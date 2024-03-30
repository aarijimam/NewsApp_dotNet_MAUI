using NewsApp.MVVM.ViewModels;
using NewsApp.MVVM.Models;

namespace NewsApp.MVVM.Views;


public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        CategorySelectionView.BindingContext = new CategoryViewModel();
		ArticleList1.BindingContext = new CategoryViewModel();
	}

	//protected override async void OnAppearing()
	//{
	//	base.OnAppearing();
	//	//List<Article> itemsource = 
	//	ArticleList1.ItemsSource = await new NewsViewModel().LoadNews();
	//}
}
