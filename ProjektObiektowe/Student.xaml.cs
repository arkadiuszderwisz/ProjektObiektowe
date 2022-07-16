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

namespace ProjektObiektowe
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Page
    {
        public Student()
        {
            InitializeComponent();
        }

        private void poprzedniaStrona_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
        private void studentAdd_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("StudentAdd.xaml", UriKind.Relative));
        }
        private void studentSearch_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("StudentSearch.xaml", UriKind.Relative));
        }
        private void studentEgzamin_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("StudentEgzamin.xaml", UriKind.Relative));
        }
    }
}
