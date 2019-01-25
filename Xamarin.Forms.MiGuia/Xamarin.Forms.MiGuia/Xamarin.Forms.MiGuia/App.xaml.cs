[assembly: Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
namespace Xamarin.Forms.MiGuia
{
    using Xamarin.Forms;
    using Xamarin.Forms.MiGuia.Utilities.Helpers;

    public partial class App : Application
    {
        public App(string SqliteConnection)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(Settings.SqliteConnection))
                Settings.SqliteConnection = SqliteConnection;
            MainPage = new MainPage();
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
