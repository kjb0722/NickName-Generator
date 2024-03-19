using NickName_Generator.Core;

namespace NickName_Generator.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                this._currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        { 
            this.HomeVM = new HomeViewModel();
            this.DiscoveryVM = new DiscoveryViewModel();

            this.CurrentView = this.HomeVM;

            this.HomeViewCommand = new RelayCommand(o =>
            {
                this.CurrentView = HomeVM;
            });

            this.DiscoveryViewCommand = new RelayCommand(o =>
            {
                this.CurrentView = DiscoveryVM;
            });
        }
    }
}
