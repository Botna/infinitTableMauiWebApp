using infinityTableWebApp.Services;
using ServiceProvider = infinityTableWebApp.Services.ServiceProvider;

namespace infinityTableWebApp.Pages
{
    public partial class SettingsPage : ContentPage
	{
        private readonly InfinityTableService _infinityTableService;
        public SettingsPage()
		{
            InitializeComponent();
            _infinityTableService = ServiceProvider.GetService<InfinityTableService>();
        }
		private async void OnButtonClicked(object sender, EventArgs e)
		{
            var result = await _infinityTableService.PingAPI();
            if(result)
            {
                DisplayAlert("HealthCheck", "The Api is available", "Ok");
            }
            else
            {
                DisplayAlert("HealthCheck", "The Api is not available", "Bummer");
            }
		}
	}
}