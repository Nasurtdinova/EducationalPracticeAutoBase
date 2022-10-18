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
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var list = DataAccess.GetRequestDrivers().Where(a=>a.PlaceArrival.City.Name == (cbArrival.SelectedItem as City).Name && a.PlaceDeparture.City.Name == (cbDeparture.SelectedItem as City).Name && a.Data == tbData.SelectedDate);
            if (list != null)
                NavigationService.Navigate(new DriversPage());
            else
                MessageBox.Show("Запросов нет!");
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
    }
}
