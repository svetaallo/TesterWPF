using TesterWPF.ViewModels.Base;
using TesterWPF.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace TesterWPF.ViewModels
{
    class TestViewModel: ViewModel
    {
        public string CurrentQuestion { get => CurrentCard.Question; } 
        public string CurrentAnswer { get => CurrentCard.CorrectAnswer; }
        private int counter = 0;
        private Card _CurrentCard;
        public Card CurrentCard
        {
            get => _CurrentCard;
            set
            {
                _CurrentCard = value;
                OnPropertyChanged(nameof(CurrentCard));
            }
        }
        public List<Card> SessionCards { get; }
        public TestViewModel()
        {
            var session = new Session();
            SessionCards = session.CardsToRepeat;
            CurrentCard = NextCard();
        }
        public Card NextCard()
        {
            return SessionCards[counter++];
        }
    }
}
