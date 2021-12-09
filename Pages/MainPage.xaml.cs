using System;
using System.Net.Http;
using System.Threading.Tasks;
using infinityTableWebApp.Services;
using ServiceProvider = infinityTableWebApp.Services.ServiceProvider;

namespace infinityTableWebApp.Pages
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly InfinityTableService _infinityTableService;
        public MainPage()
        {
            InitializeComponent();
            _infinityTableService = ServiceProvider.GetService<InfinityTableService>();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var color = string.Empty;
            count++;
            if (count % 4 == 0)
            {
                color = "blue";
            }
            if (count % 4 == 1)
            {
                color = "red";
            }
            if (count % 4 == 2)
            {
                color = "green";
            }
            if (count % 4 == 3)
            {
                color = "blank";
            }
            _infinityTableService.SetSolidColor(color);

            //         HttpClient client = new HttpClient();
            //         client.BaseAddress = new Uri("http://192.168.0.23:5000");
            //         var request = $"table/solidColor?color={color}";
            //         Task.Run(async () => {
            //	var result = await client.GetAsync(request);
            //	CounterLabel.Text = $"I finished and got a result. It was: {result.StatusCode}";
            //	}
            //);
            CounterLabel.Text = $"Current count: {count}.  Color should be: {color}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
