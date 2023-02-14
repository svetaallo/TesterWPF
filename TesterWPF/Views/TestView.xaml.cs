using System.Windows;
using TesterWPF.ViewModels;

namespace TesterWPF.Views
{
    // <summary>
    // Interaction logic for TestWindow.xaml
    // </summary>
    public partial class TestView
    {
        public TestView()
        {
            InitializeComponent();
            DataContext = new TestViewModel();
        }
    }
}
