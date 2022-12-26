using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TesterWPF.ViewModels.Base
{
    /*https://www.youtube.com/watch?v=6xkbRE4KvE0 объясняет эту херобору на 29 минуте*/
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string PropertyName = null) 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        protected virtual bool Set <T>(ref T field, T value, [CallerMemberName] string PropertyName= null)
        {
            if(Equals(field, value)) return true;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
