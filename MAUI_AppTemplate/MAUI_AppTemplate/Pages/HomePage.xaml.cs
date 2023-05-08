using MAUI_AppTemplate.ViewModels;

namespace MAUI_AppTemplate.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel homeViewModel)
	{
		InitializeComponent();
		BindingContext = homeViewModel;
	}
}