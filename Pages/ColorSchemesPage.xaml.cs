using infinityTableWebApp.Services;
using ServiceProvider = infinityTableWebApp.Services.ServiceProvider;


namespace infinityTableWebApp.Pages
{

	public partial class ColorSchemesPage : ContentPage
	{
		private readonly InfinityTableService _infinityTableService;
		public ColorSchemesPage()
		{
			InitializeComponent();
			_infinityTableService = ServiceProvider.GetService<InfinityTableService>();
		}
	}
}