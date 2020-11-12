using Boikon.Entities;
using Boikon.Factories.Rest;
using Boikon.ViewModels;
using Boikon.ViewModels.Factories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Boikon.WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModelFactory factory;

        public MainWindow()
        {
            factory = new RestMainViewModelFactory();
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = await factory.CreateModelAsync();  

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel model = DataContext as MainViewModel;
            Person p = new Person
            {
                FirstName = model.Detail?.FirstName,
                LastName = model.Detail?.LastName,
                Age = model.Detail.Age
            };
            if (await factory.InsertAsync(p))
            {
                model.People.Add(p);
            }
        }
    }
}
