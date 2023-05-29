namespace ToMoney;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Hide");
        InitializeComponent();

		MainPage = new NavigationPage (new Pages.login());
	}
}

