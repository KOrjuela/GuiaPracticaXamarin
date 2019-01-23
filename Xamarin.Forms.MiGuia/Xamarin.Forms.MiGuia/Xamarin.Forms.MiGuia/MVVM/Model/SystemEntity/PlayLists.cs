using System.Collections.Generic;
using Xamarin.Forms.MiGuia.MVVM.Model.MainEntity;

namespace Xamarin.Forms.MiGuia.MVVM.Model.SystemEntity
{
    /// <summary>
    /// Representa una lista de reproducción de musica.
    /// </summary>
    public class PlayLists: Item
    {
        public List<Music> Music { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del cantante
        /// </summary>
        public string NameCreatorList { get; set; }

        /// <summary>
        /// Obtiene o establece si el elemento esta activo en el sistema
        /// </summary>
        public bool Activo { get; set; }
    }
}
