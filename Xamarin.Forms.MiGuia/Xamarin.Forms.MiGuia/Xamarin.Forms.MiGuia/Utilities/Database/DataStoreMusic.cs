namespace Xamarin.Forms.MiGuia.Utilities.Database
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xamarin.Forms.MiGuia.MVVM.Model.SystemEntity;
    using Xamarin.Forms.MiGuia.Utilities.Interface;

    public class DataStoreMusic : IDataStore<Music>
    {
        /// <summary>
        /// Fuente de datos
        /// </summary>
        private readonly DatabaseContext _databaseContext;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="dbPath">Ruta de la base de datos</param>
        public DataStoreMusic(string dbPath)
        {
            this._databaseContext = new DatabaseContext(dbPath);
        }

        /// <summary>
        /// Método que obtiene una colección de canciones de la BD
        /// </summary>
        /// <returns>Canción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<IEnumerable<Music>> GetEntityAsync()
        {
            try
            {
                var musics = await _databaseContext.MusicTable.ToListAsync();
                return musics;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene una canción de la BD
        /// </summary>
        /// <param name="id">Identificador de la canción</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<Music> GetEntityAsync(string id)
        {
            try
            {
                var music = await _databaseContext.MusicTable.FindAsync(id);
                return music;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        /// <summary>
        /// Método que agrega una canción a la BD
        /// </summary>
        /// <param name="song">canción</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> AddEntityAsync(Music song)
        {
            try
            {
                var transaction = await _databaseContext.MusicTable.AddAsync(song);
                await _databaseContext.SaveChangesAsync();
                var isAdded = transaction.State == EntityState.Added;

                return isAdded;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Método que actualiza una canción en BD
        /// </summary>
        /// <param name="song">canción a actualizar</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> UpdateEntityAsync(Music song)
        {
            try
            {
                var transaction = _databaseContext.Update(song);
                await _databaseContext.SaveChangesAsync();
                var isModified = transaction.State == EntityState.Modified;

                return isModified;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// Método que elimina una canción en la BD
        /// </summary>
        /// <param name="id">Identificador de la canción</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> DeleteEntityAsync(string id)
        {
            try
            {
                var music = await _databaseContext.MusicTable.FindAsync(id);

                var transaction = _databaseContext.Remove(music);
                await _databaseContext.SaveChangesAsync();
                var isDeleted = transaction.State == EntityState.Deleted;

                return isDeleted;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
