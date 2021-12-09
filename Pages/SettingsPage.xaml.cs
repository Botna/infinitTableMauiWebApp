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
	}
}