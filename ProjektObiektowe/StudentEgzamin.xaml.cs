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
    /// Interaction logic for StudentEgzamin.xaml
    /// </summary>
    public partial class StudentEgzamin : Page
    {
        universityEntities dataEntities = new universityEntities();
        public StudentEgzamin()
        {
            InitializeComponent();
        }

        private void akcjaSzukanie_Click(object sender, RoutedEventArgs e)
        {
            string zmienna = studentID.Text;
            int nadalzmienna = int.Parse(zmienna);
            var query =
            from students_modules in dataEntities.students_modules
            where students_modules.student_id == nadalzmienna
            select new { students_modules.planned_exam_date };

            dataGrid1.ItemsSource = query.ToList();
        }
    }
}
