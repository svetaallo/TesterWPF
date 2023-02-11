using System.Windows;
using TesterWPF.Infrastructure.Commands.Base;
using TesterWPF.Views;

namespace TesterWPF.Infrastructure.Commands
{
    internal class OpenWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var addCardWindow = new AddCard();
            addCardWindow.Show();
        }
    }
}
