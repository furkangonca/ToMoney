namespace ToMoney;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage (new Pages.login());
	}
}

