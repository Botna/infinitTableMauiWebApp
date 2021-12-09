using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Extensions.DependencyInjection;
using infinityTableWebApp.Services;
using Refit;
using infinityTableWebApp.Pages;

namespace infinityTableWebApp
{
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
				});

			RegisterServices(builder);

			return builder.Build();
		}

		public static void RegisterServices(MauiAppBuilder builder)
        {
			//services
			builder.Services.AddSingleton<InfinityTableService>();
			builder.Services.AddSingleton(RestService.For<IInfinityTableApi>("http://192.168.0.23:5000"));

			//pages
			builder.Services.AddTransient<HomePage>();
			builder.Services.AddTransient<MainPage>();
		}
	}
}