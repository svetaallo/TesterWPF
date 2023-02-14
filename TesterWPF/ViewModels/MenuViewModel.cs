using TesterWPF.ViewModels.Base;
using TesterWPF.Infrastructure.Commands;
using System.Windows.Input;

namespace TesterWPF.ViewModels
{
    internal class MenuViewModel : ViewModel
    {

        private int amountLearned = 100;
        public int AmounrLeaened { get { return amountLearned; } }

        #region Commands
        //public ICommand SetViewModelCommand { get; }

        #region OpenSetViewModelCommand
        //public bool CanSetViewModelCommandExecute(object p) => true;

        //public void OnSetViewModelCommandExecuted(object p)
        //{
        //    var x = App.Current.Resources["mainViewModel"] as MainViewModel;
        //    var newViewModel = p as ViewModel;
        //    x.SelectedViewModel = newViewModel;
        //}
        #endregion

        #endregion
        public MenuViewModel()
        {
            #region Команды
            //SetViewModelCommand = new RelayCommand(OnSetViewModelCommandExecuted, CanSetViewModelCommandExecute);
            #endregion

        }
    }
}
