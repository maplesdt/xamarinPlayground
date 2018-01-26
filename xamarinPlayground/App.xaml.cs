using Xamarin.Forms;

namespace xamarinPlayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new xamarinPlaygroundPage();
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
