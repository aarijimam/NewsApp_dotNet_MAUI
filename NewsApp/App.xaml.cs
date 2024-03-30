namespace NewsApp;
using NewsApp.MVVM.Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomePage());
	}
}

