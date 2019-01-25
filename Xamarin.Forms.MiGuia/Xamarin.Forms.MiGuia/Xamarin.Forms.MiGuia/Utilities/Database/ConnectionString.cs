using Xamarin.Forms.MiGuia.Utilities.Helpers;

namespace Xamarin.Forms.MiGuia.Utilities.Database
{
    public class ConnectionString
    {
        /// <summary>
        /// Nombre dado a la conexión configurada a una base de datos 
        /// </summary>
        public static DataStoreMusic DataSourceMusic;

        /// <summary>
        /// Contructor
        /// </summary>
        public ConnectionString()
        {
            DataSourceMusic = new DataStoreMusic(Settings.SqliteConnection);
        }
    }
}
