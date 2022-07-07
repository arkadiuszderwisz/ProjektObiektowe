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
using System.Data.Entity.Core.Objects;
namespace ProjektObiektowe
{
    /// <summary>
    /// Interaction logic for StudentSearch.xaml
    /// </summary>
    public partial class StudentSearch : Page
    {
        universityEntities dataEntities = new universityEntities();
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void akcjaSzukanie_Click(object sender, RoutedEventArgs e)
        {
            string zmienna = studentNazwisko.Text;
            var query =
            from students in dataEntities.students
            where students.surname == zmienna
            select new { students.student_id, students.first_name, students.surname, students.date_of_birth, students.group_no };
            dataGrid1.ItemsSource = query.ToList();
        }
    }
}
