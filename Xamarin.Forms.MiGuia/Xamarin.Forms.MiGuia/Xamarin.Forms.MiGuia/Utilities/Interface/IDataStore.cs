namespace Xamarin.Forms.MiGuia.Utilities.Interface
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDataStore<T>
    {
        /// <summary>
        /// Agrega entidad en el origen de datos
        /// </summary>
        /// <param name="item">Entidad a agregar</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        Task<bool> AddEntityAsync(T item);

        /// <summary>
        /// Actualiza entidad en el origen de datos
        /// </summary>
        /// <param name="item">Entidad a actualizar</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        Task<bool> UpdateEntityAsync(T item);

        /// <summary>
        /// Elimina entidad en el origen de datos
        /// </summary>
        /// <param name="id">Identificador de la entidad</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        Task<bool> DeleteEntityAsync(string id);

        /// <summary>
        /// Obtiene entidad del origen de datos
        /// </summary>
        /// <param name="id">Identificador de la entidad</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        Task<T> GetEntityAsync(string id);

        /// <summary>
        /// Obtiene lista de entidades del origen de datos
        /// </summary>
        /// <returns>Retorna lista de entidades</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        Task<IEnumerable<T>> GetEntityAsync();
    }
}
