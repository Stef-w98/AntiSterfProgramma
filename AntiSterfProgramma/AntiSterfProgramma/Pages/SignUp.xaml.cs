using AntiSterfProgramma.API;
using AntiSterfProgramma.Model;

namespace AntiSterfProgramma;

public partial class SignUp : ContentPage
{
    
	public SignUp()
	{
		InitializeComponent();
       
	}

	private async void BtnRegister_Clicked(object sender, EventArgs e)
	{

        User user = new User();
        user.UserName = EntUserName.Text;
        user.Name = EntFirstName.Text;
        user.LastName = EntLastName.Text;
        user.Email = EntEmail.Text;
        user.Password = EntPassword.Text;

        Task<HttpResponseMessage> isRegistered = APIService.PostRegisterUser(user);
        string x = await isRegistered.Result.Content.ReadAsStringAsync();

        if (int.Parse(x) != 0)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }

    private void BtnLogin_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
}