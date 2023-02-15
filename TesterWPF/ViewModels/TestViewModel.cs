using TesterWPF.ViewModels.Base;
using TesterWPF.Models;
using TesterWPF.Views;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using TesterWPF.Infrastructure.Commands;

namespace TesterWPF.ViewModels
{
    class TestViewModel: ViewModel
    {
        public bool IsQuestionHidden { get; set; }
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
        private int _Counter = 0;
        public int Counter
        {
            get => _Counter;
            set
            {
                _Counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }
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
        #region NextCardCommand
        public ICommand NextCardCommand { get; }
        public bool CanNextCardCommandExecute(object parameter) => true;/*сюда прописать запрет на вызов команды, пока ответ не просмотрен*/

        public void OnNextCardCommandExecuted(object parameter)
        {
            /*вызов команды изменяющей ид карты в соответствии с ответом*/
            var x = parameter as TextBlock;
            x.Visibility = System.Windows.Visibility.Hidden;
            if(Counter < SessionCards.Count)
                CurrentCard = SessionCards[Counter++];
            else
            {
                SetViewModelCommand com = new SetViewModelCommand();
                com.Execute(new MenuViewModel());
                /*экран "карточки на сегодня закончились" вместо автоматического выхода в меню*/
            }
        }

        public ICommand ShowAnswerCommand { get; }


        #endregion
        #region ShowAnswerCommand
        public bool CanShowAnswerCommandExecute(object parameter) => true;/*сюда прописать запрет на вызов команды, пока ответ не просмотрен*/

        public void OnShowAnswerCommandExecuted(object parameter)
        {
            var x = parameter as TextBlock;
            x.Visibility = System.Windows.Visibility.Visible;
        }
        #endregion
        #endregion
        public TestViewModel()
        {
            var session = new Session();
            SessionCards = session.CardsToRepeat;
            IsQuestionHidden = true;
            CurrentCard = SessionCards[0];
            NextCardCommand = new RelayCommand(OnNextCardCommandExecuted, CanNextCardCommandExecute);
            ShowAnswerCommand = new RelayCommand(OnShowAnswerCommandExecuted, CanShowAnswerCommandExecute);
        }
    }
}
