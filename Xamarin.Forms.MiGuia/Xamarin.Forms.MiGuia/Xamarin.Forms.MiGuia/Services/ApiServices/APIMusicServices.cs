namespace Xamarin.Forms.MiGuia.Services.ApiServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xamarin.Forms.MiGuia.MVVM.Model.SystemEntity;
    using Xamarin.Forms.MiGuia.Services.MockDataStore;
    using Xamarin.Forms.MiGuia.Utilities.Interface;

    public class APIMusicServices : IDataStore<Music>
    {
        /// <summary>
        /// Instancia de la referencia al DataStoreMusic
        /// </summary>
        public IDataStore<Music> ApiServicesMusic;

        /// <summary>
        /// Constructor
        /// </summary>
        public APIMusicServices()
        {
            this.ApiServicesMusic = new DataStoreMusic();
        }

        /// <summary>
        /// Método que agrega una canción a la colección de musica
        /// </summary>
        /// <param name="cancion">canción</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> AddItemAsync(Music cancion)
        {
            return await this.ApiServicesMusic.AddItemAsync(cancion);
        }

        /// <summary>
        /// Método que elimina una canción de la colección de musica
        /// </summary>
        /// <param name="id">Identificador de la canción</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> DeleteItemAsync(string id)
        {
            return await this.ApiServicesMusic.DeleteItemAsync(id);
        }

        /// <summary>
        /// Método que obtiene una canción de la colección de musica
        /// </summary>
        /// <param name="id">Identificador de la canción</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<Music> GetItemAsync(string id)
        {
            return await this.ApiServicesMusic.GetItemAsync(id);
        }

        /// <summary>
        /// Método que obtiene una colección de canciones
        /// </summary>
        /// <returns>Lista de canciones</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<IEnumerable<Music>> GetItemsAsync()
        {
            return await this.ApiServicesMusic.GetItemsAsync();
        }

        /// <summary>
        /// Método que actualiza una colección de canciones
        /// </summary>
        /// <param name="newCancion">canción a actualizar</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> UpdateItemAsync(Music newCancion)
        {
            return await this.ApiServicesMusic.UpdateItemAsync(newCancion);
        }

    }
}
