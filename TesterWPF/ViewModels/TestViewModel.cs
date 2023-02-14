using TesterWPF.ViewModels.Base;
using TesterWPF.Models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace TesterWPF.ViewModels
{
    class TestViewModel: ViewModel
    {
        public string CurrentQuestion { get; set; }
        public string CurrentAnswer { get; set; }
        public List<Card> SessionCards { get; }
        public TestViewModel()
        {
            //var session = new Session();
        }
    }
}
