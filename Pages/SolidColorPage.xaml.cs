using infinityTableWebApp.Globals;
using infinityTableWebApp.Services;
using ServiceProvider = infinityTableWebApp.Services.ServiceProvider;

namespace infinityTableWebApp.Pages
{

	public partial class SolidColorPage : ContentPage
	{
		private readonly InfinityTableService _infinityTableService;
		public SolidColorPage()
		{
			InitializeComponent();
			_infinityTableService = ServiceProvider.GetService<InfinityTableService>();
		}

        private void OnButtonClicked(object sender, EventArgs e)
        {
			var color = string.Empty;
			Button button = sender as Button ?? null;

			if (button != null)
			{
				color = button.Text;
				_infinityTableService.SetSolidColor(ColorGenerator.ConvertToHSVPixelColor(color));				
			} 
        }
    }
}