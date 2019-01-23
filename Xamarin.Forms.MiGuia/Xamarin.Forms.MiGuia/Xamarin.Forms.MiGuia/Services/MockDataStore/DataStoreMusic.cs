namespace Xamarin.Forms.MiGuia.Services.MockDataStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Xamarin.Forms.MiGuia.MVVM.Model.SystemEntity;
    using Xamarin.Forms.MiGuia.Utilities.Interface;

    public class DataStoreMusic : IDataStore<Music>
    {
        /// <summary>
        /// Colección de elementos que representan una lista musical
        /// </summary>
        /// <readonly>Se usa para declarar constante una variable miembro, pero permite que el valor se calcule en tiempo de ejecución</readonly> 
        readonly List<Music> MockStoreMusic;

        /// <summary>
        /// Constructo
        /// </summary>
        public DataStoreMusic()
        {
            this.MockStoreMusic = new List<Music>();

            this.MockStoreMusic = new List<Music>
            {
                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Calma",
                    Description ="Pedro Capó & Farruko (Remix)",
                    Artist ="Pedro Capó",
                    Listeners = 210
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Havana",
                    Description ="Camila Cabello & Daddy Yankee (Remix)",
                    Artist ="Camila Cabello",
                    Listeners = 180
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Justicia",
                    Description ="Silvestre Dangond & Natti Natasha (Remix)",
                    Artist ="Silvestre Dangond",
                    Listeners = 195
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Le pido a Dios",
                    Description ="Album Wolfine",
                    Artist ="Andrés Felipe Zapata",
                    Listeners = 153
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Si yo fuera un chico",
                    Description ="Album Beyonce",
                    Artist ="Beyoncé",
                    Listeners = 240
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Culpables",
                    Description ="Album Culpables",
                    Artist ="Manuel Turizo",
                    Listeners = 208
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Quisiera Alejarme",
                    Description ="Feat. Wisin, Ozuna & CNCO (Remix)",
                    Artist ="Wisin",
                    Listeners = 218
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Todo el amor",
                    Description ="Feat. Wisin & Maluma (Remix)",
                    Artist ="Wisin",
                    Listeners = 186
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Te voy a amar",
                    Description ="Feat. Andres Cepeda & Cali y el Dandee (Remix)",
                    Artist ="Andres Cepeda",
                    Listeners = 153
                },
                
                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Calma",
                    Description ="Pedro Capó & Farruko (Remix)",
                    Artist ="Pedro Capó",
                    Listeners = 210
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Havana",
                    Description ="Camila Cabello & Daddy Yankee (Remix)",
                    Artist ="Camila Cabello",
                    Listeners = 180
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Justicia",
                    Description ="Silvestre Dangond & Natti Natasha (Remix)",
                    Artist ="Silvestre Dangond",
                    Listeners = 195
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Le pido a Dios",
                    Description ="Album Wolfine",
                    Artist ="Andrés Felipe Zapata",
                    Listeners = 153
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Si yo fuera un chico",
                    Description ="Album Beyonce",
                    Artist ="Beyoncé",
                    Listeners = 240
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Culpables",
                    Description ="Album Culpables",
                    Artist ="Manuel Turizo",
                    Listeners = 208
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Quisiera Alejarme",
                    Description ="Feat. Wisin, Ozuna & CNCO (Remix)",
                    Artist ="Wisin",
                    Listeners = 218
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Todo el amor",
                    Description ="Feat. Wisin & Maluma (Remix)",
                    Artist ="Wisin",
                    Listeners = 186
                },

                       new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Calma",
                    Description ="Pedro Capó & Farruko (Remix)",
                    Artist ="Pedro Capó",
                    Listeners = 210
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Havana",
                    Description ="Camila Cabello & Daddy Yankee (Remix)",
                    Artist ="Camila Cabello",
                    Listeners = 180
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Justicia",
                    Description ="Silvestre Dangond & Natti Natasha (Remix)",
                    Artist ="Silvestre Dangond",
                    Listeners = 195
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Le pido a Dios",
                    Description ="Album Wolfine",
                    Artist ="Andrés Felipe Zapata",
                    Listeners = 153
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Si yo fuera un chico",
                    Description ="Album Beyonce",
                    Artist ="Beyoncé",
                    Listeners = 240
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Culpables",
                    Description ="Album Culpables",
                    Artist ="Manuel Turizo",
                    Listeners = 208
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Quisiera Alejarme",
                    Description ="Feat. Wisin, Ozuna & CNCO (Remix)",
                    Artist ="Wisin",
                    Listeners = 218
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Todo el amor",
                    Description ="Feat. Wisin & Maluma (Remix)",
                    Artist ="Wisin",
                    Listeners = 186
                },

                new Music
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Te voy a amar",
                    Description ="Feat. Andres Cepeda & Cali y el Dandee (Remix)",
                    Artist ="Andres Cepeda",
                    Listeners = 153
                }
            };
        }

        /// <summary>
        /// Método que agrega una canción a la colección de musica
        /// </summary>
        /// <param name="item">canción</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> AddItemAsync(Music item)
        {
            this.MockStoreMusic.Add(item);
            return await Task.FromResult(true); 
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
            var _itemMusic = this.MockStoreMusic
                                   .Where((Music arg) => arg.Id == id)
                                   .FirstOrDefault();

            this.MockStoreMusic.Remove(_itemMusic);

            return await Task.FromResult(true);
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
            return await Task.FromResult(this.MockStoreMusic
                                                 .FirstOrDefault(s => s.Id == id));
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
            return await Task.FromResult(this.MockStoreMusic);
        }

        /// <summary>
        /// Método que actualiza una colección de canciones
        /// </summary>
        /// <param name="item">canción a actualizar</param>
        /// <returns>Exito de la transacción</returns>
        /// <remarks>
        /// Autor: Carlos Orjuela 
        /// </remarks>
        public async Task<bool> UpdateItemAsync(Music newItem)
        {
            var _itemMusic = this.MockStoreMusic
                                   .Where((Music arg) => arg.Id == newItem.Id)
                                   .FirstOrDefault();

            this.MockStoreMusic.Remove(_itemMusic);
            this.MockStoreMusic.Add(newItem);

            return await Task.FromResult(true);
        }
    }
}
