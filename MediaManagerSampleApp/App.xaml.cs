using Xamarin.Forms;
using Plugin.MediaManager.Forms;

namespace MediaManagerSampleApp
{
    public partial class App : Application
    {
        public App()
        {
			var workaround = typeof(VideoView);

            InitializeComponent();

            MainPage = new NavigationPage(new VideoPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
