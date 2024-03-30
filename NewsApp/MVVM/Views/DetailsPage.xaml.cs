using System.Windows.Input;
using NewsApp.MVVM.Models;

namespace NewsApp.MVVM.Views;


public partial class DetailsPage : ContentPage
{
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    string articleUrl;
    public DetailsPage(Article article)
	{

		InitializeComponent();
		ImageNews.Source = article.Image;
		Titlelbl.Text = article.Title;
		description.Text = article.Content;
		TapGesture.CommandParameter = article.Url;
        articleUrl = article.Url;
		BindingContext = this;
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Uri uri = new Uri(articleUrl);
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }

    
}
