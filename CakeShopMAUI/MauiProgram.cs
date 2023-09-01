using CakeShopMAUI.Pages;
using CakeShopMAUI.Services;
using CakeShopMAUI.ViewModels;
using CommunityToolkit.Maui;

namespace CakeShopMAUI;

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
			}).UseMauiCommunityToolkit();

		AddPCakeServices(builder.Services);
		return builder.Build();
	}
	private static IServiceCollection AddPCakeServices(IServiceCollection services)
	{
		services.AddSingleton<CakeService>();
		services.AddSingletonWithShellRoute<HomePage,HomeViewModel>(nameof(HomePage));
		return services;
	}
}
