using System;
using System.Collections.Generic;
using System.Linq;
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
using WPF_Demo.Models;

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Person p = new Person { Age = 42, FavoriteColor = "Yellow", FirstName = "Piet", LastName = "de Vries" };
            MainViewModel model = new MainViewModel { Persoon = p };
            InitializeComponent();
            DataContext = model;
        }
    }
}
