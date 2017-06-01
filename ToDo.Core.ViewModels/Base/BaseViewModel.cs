using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToDo.Core.ViewModels.Services.Interfaces;

namespace ToDo.Core.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {

        }

        private readonly INavigationService _navigationService;
        protected INavigationService NavigationService
        {
            get { return _navigationService; }
        }

        private readonly ICacheService _cacheService;

        protected ICacheService CacheService
        {
            get { return _cacheService; }
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; Raise(); }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void Raise([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
