using MAUI_AppTemplate.Pages;
using MAUI_AppTemplate.ViewModels;

namespace MAUI_AppTemplate;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<HomeViewModel>();
		return builder.Build();
	}
}
