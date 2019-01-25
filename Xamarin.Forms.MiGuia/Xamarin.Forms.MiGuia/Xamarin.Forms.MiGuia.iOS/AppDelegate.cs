using Foundation;
using System.IO;
using UIKit;

namespace Xamarin.Forms.MiGuia.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            var sqliteConnection = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library", "MiGuiaDB.db");
            LoadApplication(new App(sqliteConnection));

            return base.FinishedLaunching(app, options);
        }
    }
}
