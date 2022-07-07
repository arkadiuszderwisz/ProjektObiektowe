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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void kategoriaStudent_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Student.xaml", UriKind.Relative));
        }

        private void kategoriaWykladowca_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Wykladowca.xaml", UriKind.Relative));
        }
    }
}
