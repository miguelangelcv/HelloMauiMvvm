using HelloMauiMvvm.Views;

namespace HelloMauiMvvm;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomeView());

		// .NET MAUI Shell
		//MainPage = new AppShell();
	}
}
