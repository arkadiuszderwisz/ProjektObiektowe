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
    /// Interaction logic for Wykladowca.xaml
    /// </summary>
    public partial class Wykladowca : Page
    {
        public Wykladowca()
        {
            InitializeComponent();
        }

        private void poprzedniaStrona_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Home.xaml", UriKind.Relative));
        }

        private void wykladowcaAdd(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WykladowcaAdd.xaml", UriKind.Relative));
        }

        private void wykladowcaSearch(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("WykladowcaSearch.xaml", UriKind.Relative));
        }
    }
}
