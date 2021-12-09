using Application = Microsoft.Maui.Controls.Application;

namespace infinityTableWebApp
{
    public partial class App : Application
	{
        public App()
        {
            InitializeComponent();
            if (Device.Idiom == TargetIdiom.Phone)
                Shell.Current.CurrentItem = PhoneTabs;

            
        }
    }
}
