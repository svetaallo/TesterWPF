using TesterWPF.ViewModels.Base;
using TesterWPF.Models;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using TesterWPF.Infrastructure.Commands;

namespace TesterWPF.ViewModels
{
    class TestViewModel: ViewModel
    {
        private string _CurrentQuestion;
        public string CurrentQuestion 
        { 
            get => _CurrentQuestion;
            set
            {
                _CurrentQuestion = value;
                OnPropertyChanged(nameof(CurrentQuestion));
            }
        }
        private string _CurrentAnswer;
        public string CurrentAnswer
        {
            get => _CurrentAnswer;
            set
            {
                _CurrentAnswer = value;
                OnPropertyChanged(nameof(CurrentAnswer));
            }
        }
        private int counter = 0;
        private Card _CurrentCard;
        public Card CurrentCard
        {
            get => _CurrentCard;
            set
            {
                _CurrentCard = value;
                CurrentAnswer = _CurrentCard.CorrectAnswer;
                CurrentQuestion = _CurrentCard.Question;
               // OnPropertyChanged(nameof(CurrentCard));
            }
        }
        public List<Card> SessionCards { get; }
        #region Commands
        public ICommand NextCardCommand { get; }
        #region AddNewCardCommand
        public bool CanNextCardCommandExecute(object parameter) => true;/*сюда прописать запрет на вызов команды, пока ответ не просмотрен*/

        public void OnNextCardCommandExecuted(object parameter)
        {
            /*вызов команды изменяющей ид карты в соответствии с ответом*/
            if(counter < SessionCards.Count)
                CurrentCard = SessionCards[counter++];
            else
            {
                SetViewModelCommand com = new SetViewModelCommand();
                com.Execute(new MenuViewModel());
                /*экран "карточки на сегодня закончились" вместо автоматического выхода в меню*/
            }
        }
        #endregion
        #endregion
        public TestViewModel()
        {
            var session = new Session();
            SessionCards = session.CardsToRepeat;
            CurrentCard = SessionCards[0];
            NextCardCommand = new RelayCommand(OnNextCardCommandExecuted, CanNextCardCommandExecute);
        }
    }
}
