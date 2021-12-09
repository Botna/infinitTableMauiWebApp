using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Extensions.DependencyInjection;
using infinityTableWebApp.Services;
using Refit;
using infinityTableWebApp.Pages;
using System.Net.Http;

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

			//yes this defeats the purpose.
			var client = HttpClientFactory.Create();

			client.BaseAddress = new Uri("http://192.168.0.23:5000");
			client.Timeout = TimeSpan.FromSeconds(2);

			builder.Services.AddSingleton(RestService.For<IInfinityTableApi>(client));
		}
	}
}