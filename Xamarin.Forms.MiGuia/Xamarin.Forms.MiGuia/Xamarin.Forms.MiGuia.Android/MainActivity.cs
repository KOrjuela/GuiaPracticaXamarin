using Android.App;
using Android.Content.PM;
using Android.OS;
using System.IO;

namespace Xamarin.Forms.MiGuia.Droid
{
    [Activity(Label = "MiGuia", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var sqliteConnection = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MiGuiaDB.db");
            LoadApplication(new App(sqliteConnection));
        }
    }
}