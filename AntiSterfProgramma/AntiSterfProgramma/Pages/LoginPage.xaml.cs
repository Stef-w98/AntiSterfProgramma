using AntiSterfProgramma.Model;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using AntiSterfProgramma.API;
using Font = Microsoft.Maui.Font;

namespace AntiSterfProgramma;

public partial class LoginPage : ContentPage
{
    private bool online = false;
	public LoginPage()
	{
		InitializeComponent();		
        IsOnline();

        //APIService apiService = new APIService();
        //var userResult = apiService.GetUsers();
        //LblEmail.Text = userResult.Result.Email;

    }
    
    async void LoginFlow()
    {
        await Shell.Current.GoToAsync($"//{nameof(Dashboard)}");
    }

    public async void IsOnline()
    {
        if(await APIService.GetUsers())
        {
            online = true;
            SnackbarOnline();
        }
        else
        {
            online = false;
            SnackbarOffline();
        }        
        
    }

	public void SnackbarOnline()
	{
        var options = new SnackbarOptions
        {
            BackgroundColor = Colors.LightGreen,
            TextColor = Colors.Black,
            ActionButtonTextColor = Colors.Black,
            Font = Font.SystemFontOfSize(14),
            ActionButtonFont = Font.SystemFontOfSize(14),
            

        };
        var snackbar = Snackbar.Make("Online", visualOptions: options);
        snackbar.Show();
    }

    public void SnackbarOffline()
    {
        
        var options = new SnackbarOptions
        {
            BackgroundColor = Colors.Red,
            TextColor = Colors.Black,
            ActionButtonTextColor = Colors.Black,
            Font = Font.SystemFontOfSize(14),
            ActionButtonFont = Font.SystemFontOfSize(14),


        };
        var snackbar = Snackbar.Make("Offline", visualOptions: options);
        snackbar.Show();
    }

    public void SnackbarLoginEmpty()
    {
        TimeSpan timer = new TimeSpan(0, 0, 0, 8);

        var options = new SnackbarOptions
        {
            BackgroundColor = Colors.Red,
            TextColor = Colors.Black,
            ActionButtonTextColor = Colors.Black,
            Font = Font.SystemFontOfSize(14),
            ActionButtonFont = Font.SystemFontOfSize(14),


        };
        var snackbar = Snackbar.Make("Please fill in the required fields", duration:timer, visualOptions: options);
        snackbar.Show();
    }



    private async void Button_Clicked(object sender, EventArgs e)
	{
        LoginFlow();

        if (!online)
        {
            IsOnline();
        }
        if (online)
        {            
            if(EntUserName.Text != null || EntPassword.Text != null)
            {
                User user = new User();
                user.UserName = EntUserName.Text;
                user.Password = EntPassword.Text;

                Task<HttpResponseMessage> isLogedIn = APIService.PostUserLogin(user);
                string x = await isLogedIn.Result.Content.ReadAsStringAsync();

                if (int.Parse(x) != 0)
                {
                    LoginFlow();
                    //Navigation.PushAsync(new Dashboard());
                }
            }
            else
            {
                SnackbarLoginEmpty();
                return;
            }
                        
        }	

        //LblEmail.Text = APIService.testidc.Email;
    }

	private void BtnSingUp_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new SignUp());
    }
}