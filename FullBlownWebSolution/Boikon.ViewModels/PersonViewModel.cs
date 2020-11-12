using System.ComponentModel;

namespace Boikon.ViewModels
{
    public class PersonViewModel:INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}