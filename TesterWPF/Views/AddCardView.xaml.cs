using System.Windows;
using TesterWPF.ViewModels;

namespace TesterWPF.Views
{
    /// <summary>
    /// Interaction logic for AddCard.xaml
    /// </summary>
    public partial class AddCardView
    {
        public AddCardView()
        {
            InitializeComponent();
            DataContext = new AddCardViewModel();
        }
    }
}
