using NewsApp.MVVM.ViewModels;

namespace NewsApp.MVVM.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        CategorySelectionView.BindingContext = new CategoryViewModel();
	}
}
