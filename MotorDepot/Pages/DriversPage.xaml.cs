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

namespace MotorDepot
{
    public partial class DriversPage : Page
    {
        public DriversPage(List<RequestDriver> list)
        {
            InitializeComponent();
            lvDrivers.ItemsSource = list;
        }

        private void btnReserve_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as RequestDriver;
            ReverseVenueWindow rev = new ReverseVenueWindow(req);
            rev.Show();
            rev.Closed += (s, eventarg) =>
            {
                lvDrivers.ItemsSource = DataAccess.GetRequestDrivers().Where(a => a.Data >= DateTime.Now);
            };
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
