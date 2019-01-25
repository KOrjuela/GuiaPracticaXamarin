namespace Xamarin.Forms.MiGuia.Utilities.Helpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    public class Settings
    {
        /// <summary>
        /// Inicializamos la implementacion del Setting 
        /// </summary>
        private static ISettings _appSettings => CrossSettings.Current;

        /// <summary>
        /// Obtiene o establece la cadena utilizada para conectar a una base de datos de SQLite.
        /// </summary>
        public static string SqliteConnection
        {
            get => _appSettings.GetValueOrDefault(nameof(SqliteConnection), string.Empty);
            set => _appSettings.AddOrUpdateValue(nameof(SqliteConnection), value);
        }


        /// <summary>
        /// Limpa datos Persistentes 
        /// </summary>
        public static void ClearAllData()
        {
            _appSettings.Clear();
        }
    }
}
