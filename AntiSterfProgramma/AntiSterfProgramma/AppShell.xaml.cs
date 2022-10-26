using System.Windows.Input;

namespace AntiSterfProgramma;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));

	}

	private async void SignOut_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

}
