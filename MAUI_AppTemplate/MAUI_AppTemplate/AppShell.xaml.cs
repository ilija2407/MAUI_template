using MAUI_AppTemplate.Pages;

namespace MAUI_AppTemplate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("homePageRoute", typeof(HomePage));
    }
}
