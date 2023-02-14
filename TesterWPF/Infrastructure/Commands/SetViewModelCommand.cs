using System.Windows;
using System.Windows.Input;
using TesterWPF.Infrastructure.Commands.Base;
using TesterWPF.ViewModels.Base;
using TesterWPF.ViewModels;
//сделать бы это без копипаста
namespace TesterWPF.Infrastructure.Commands
{
    internal class SetViewModelCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var x = App.Current.Resources["mainViewModel"] as MainViewModel;
            //var newViewModel = parameter as ViewModel;
            x.SelectedViewModel = new AddCardViewModel();
        }
    }
}
