﻿using System;
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
    /// Interaction logic for WykladowcaAdd.xaml
    /// </summary>
    public partial class WykladowcaAdd : Page
    {
        public WykladowcaAdd()
        {
            InitializeComponent();
        }

        private void akcjaDodawanie_Click(object sender, RoutedEventArgs e)
        {
            DataSet1TableAdapters.employeesTableAdapter info = new DataSet1TableAdapters.employeesTableAdapter();
            info.AddWykladowca(wykladowcaImie.Text, wykladowcaNazwisko.Text, wykladowcaData.Text, wykladowcaPESEL.Text);
            MessageBox.Show("Pomyślnie dodano");
        }

        private void poprzedniaStrona_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
