namespace Xamarin.Forms.MiGuia.Utilities.Database
{
    using Microsoft.EntityFrameworkCore;
    using Xamarin.Forms.MiGuia.MVVM.Model.SystemEntity;

    public class DatabaseContext: DbContext
    {
        /// <summary>
        /// Entidad Music
        /// </summary>
        public DbSet<Music> MusicTable { get; set; }

        /// <summary>
        /// Ruta de la base de datos
        /// </summary>
        private readonly string _databasePath;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="databasePath"></param>
        public DatabaseContext(string databasePath)
        {
            this._databasePath = databasePath;
            this.Database.EnsureCreated();
        }

        /// <summary>
        /// configurar la base de datos (y otras opciones) que se utilizarán para este contexto
        /// </summary>
        /// <param name="optionsBuilder">Proporciona una API simple para configurar DatabaseContext</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(string.Format("Filename={0}", _databasePath));
        }
    }
}
