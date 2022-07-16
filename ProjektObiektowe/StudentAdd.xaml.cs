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
    /// Interaction logic for StudentAdd.xaml
    /// </summary>
    public partial class StudentAdd : Page
    {
        universityEntities dataEntities = new universityEntities();
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void akcjaDodawanie_Click(object sender, RoutedEventArgs e)
        {
            DataSet1TableAdapters.studentsTableAdapter info = new DataSet1TableAdapters.studentsTableAdapter();
            info.AddStudent(studentImie.Text, studentNazwisko.Text, studentData.Text, studentGrupa.Text);
            MessageBox.Show("Pomyślnie dodano");
        }

        private void poprzedniaStrona_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
