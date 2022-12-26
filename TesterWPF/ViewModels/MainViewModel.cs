using TesterWPF.Models;
using Prism.Commands;
using TesterWPF.ViewModels.Base;

namespace TesterWPF.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        private int amountLearned = 100;
        public int AmounrLeaened { get { return amountLearned; } }

        private string _Title;
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        private DelegateCommand _addView;
        public DelegateCommand AddViewCmd =>
            _addView ?? (_addView = new DelegateCommand(AddView));

        void AddView()
        {
        }
    }
}
