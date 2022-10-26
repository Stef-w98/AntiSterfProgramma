using AntiSterfProgramma.API;

namespace AntiSterfProgramma;

public partial class Dashboard : ContentPage
{
	
	public Dashboard()
	{
		InitializeComponent();
		APIService.GetWeight();
    }

}