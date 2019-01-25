using Xamarin.Forms.MiGuia.Utilities.Database;

namespace Xamarin.Forms.MiGuia.MVVM.ViewModel.MainResources
{
    public class MainViewModel
    {
        #region Singleton
        /// <summary>
        /// Representa una unica instancia de la Main ViewModel
        /// </summary>
        private static MainViewModel _intance;

        /// <summary>
        /// Obtiene una instancia unica de la Main ViewModel
        /// </summary>
        /// <aplicar>MainViewModel.Instance.MiFuncion()</aplicar>
        public static MainViewModel Instance
        {
            get
            {
                if (_intance == null) {
                    _intance = new MainViewModel();
                    new ConnectionString();
                }

                return _intance;
            }
        }
        #endregion

        #region Properties

        #endregion

        /// <summary>
        /// Contructor
        /// </summary>
        protected MainViewModel()
        {
            new ConnectionString();
        }

        #region ViewModels

        #endregion

    

       
    }
}
