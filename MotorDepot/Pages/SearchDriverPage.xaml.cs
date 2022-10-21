using BespokeFusion;
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

namespace MotorDepot
{
    public partial class SearchDriverPage : Page
    {
        public SearchDriverPage()
        {
            InitializeComponent();
            cbArrival.ItemsSource = DataAccess.GetCities();
            cbDeparture.ItemsSource = DataAccess.GetCities();
            tbData.DisplayDateStart = DateTime.Now;
            lvDrivers.ItemsSource = DataAccess.GetRequestDrivers().Where(a=>a.Data >= DateTime.Now);
        }



        public void OnComboDepartureTextChanged(object sender, RoutedEventArgs e)
        {
            var city = DataAccess.GetCities();
            cbDeparture.ItemsSource = city.Where(a => a.Name.ToLower().Contains(cbDeparture.Text.ToLower()));
        }

        public void OnComboArrivalTextChanged(object sender, RoutedEventArgs e)
        {
            var city = DataAccess.GetCities();
            cbArrival.ItemsSource = city.Where(a => a.Name.ToLower().Contains(cbArrival.Text.ToLower()));
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
