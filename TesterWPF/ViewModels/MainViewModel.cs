using TesterWPF.ViewModels.Base;

namespace TesterWPF.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        private ViewModel _selectedViewModel;
        public ViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public MainViewModel()
        {
            SelectedViewModel = new MenuViewModel();
        }
    }
}
