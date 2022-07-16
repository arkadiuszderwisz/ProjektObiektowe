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
    /// Interaction logic for WykladowcaSearch.xaml
    /// </summary>
    public partial class WykladowcaSearch : Page
    {

        universityEntities dataEntities = new universityEntities();
        public WykladowcaSearch()
        {
            InitializeComponent();
        }

        private void akcjaSzukanie_Click(object sender, RoutedEventArgs e)
        {
            string zmienna = wykladowcaNazwisko.Text;
            var query =
            from employees in dataEntities.employees
            where employees.surname == zmienna
            select new { employees.employee_id, employees.first_name, employees.surname, employees.PESEL };
            dataGrid1.ItemsSource = query.ToList();
        }
        private void poprzedniaStrona_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
