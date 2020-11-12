using Boikon.Entities;
using Boikon.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;

namespace Boikon.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People 
        { 
            get
            {
                return _people;
            }
            set
            {
                _people = value;
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(People)));
            }
        }
        public PersonViewModel Detail { get; set; }

        public ICommand InsertCommand
        {
            get
            {
                return new RelayCommand(o => Insert(), o => true);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Insert()
        {
            Person p = new Person
            {
                FirstName = Detail?.FirstName,
                LastName = Detail?.LastName,
                Age = Detail.Age
            };
            
            People.Add(p);
        }
    }
}
