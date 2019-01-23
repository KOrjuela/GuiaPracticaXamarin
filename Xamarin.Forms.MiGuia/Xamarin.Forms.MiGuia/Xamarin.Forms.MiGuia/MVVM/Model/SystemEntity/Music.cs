namespace Xamarin.Forms.MiGuia.MVVM.Model.SystemEntity
{
    using Xamarin.Forms.MiGuia.MVVM.Model.MainEntity;

    /// <summary>
    /// Representa una canción.
    /// </summary>
    public class Music : Item
    {
        /// <summary>
        /// Obtiene o establece el nombre del cantante
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Obtiene o establece el numero de oyentes
        /// </summary>
        public int Listeners { get; set; }

        /// <summary>
        /// Obtiene o establece si la canción esta activa
        /// </summary>
        public bool Active { get; set; }
    }
}
