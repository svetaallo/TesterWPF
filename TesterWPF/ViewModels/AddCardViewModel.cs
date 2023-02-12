using TesterWPF.ViewModels.Base;
using TesterWPF.Infrastructure.Commands;
using TesterWPF.Models;
using System.Windows.Input;
using System.Windows;

namespace TesterWPF.ViewModels
{
    class AddCardViewModel : ViewModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        #region Commands
        public ICommand AddNewCardCommand { get; }
        #region AddNewCardCommand
        public bool CanAddNewCardCommandExecute(object parametr) => true;

        public void OnAddNewCardCommandExecuted(object parametr)
        {
            var addedCard= new Card(Question, Answer);
            //сюда сохранение в БД
            addedCard.SaveToBase();
            Window window = parametr as Window;
            window?.Close();
        }
        #endregion
        #endregion
        public AddCardViewModel()
        {
            #region Commands
            AddNewCardCommand = new RelayCommand(OnAddNewCardCommandExecuted, CanAddNewCardCommandExecute);
            #endregion
        }
    }
}
