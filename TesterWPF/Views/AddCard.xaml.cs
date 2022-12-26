using System.Windows;
using TesterWPF.ViewModels;

namespace TesterWPF.Views
{
    /// <summary>
    /// Interaction logic for AddCard.xaml
    /// </summary>
    public partial class AddCard : Window, IView
    {
        public AddCard()
        {
            InitializeComponent();
            DataContext = new AddCardViewModel();
        }
        public bool? Open()
        {
            return this.ShowDialog();
        }
    }
    public interface IView
    {
        bool? Open();
    }
}
