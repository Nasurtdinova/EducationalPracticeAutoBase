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
        public List<RequestDriver> UpdatedRequestDriver { get; set; }
        public SearchDriverPage()
        {
            InitializeComponent();
            var arrival = DataAccess.GetCities();
            arrival.Insert(0, new City { Name = "Все" });
            cbArrival.ItemsSource = arrival;
            cbArrival.SelectedIndex = 0;

            var depart = DataAccess.GetCities();
            depart.Insert(0, new City { Name = "Все" });
            cbDeparture.ItemsSource = depart;
            cbDeparture.SelectedIndex = 0;

            tbData.DisplayDateStart = DateTime.Now;
            lvDrivers.ItemsSource = DataAccess.GetRequestDrivers().Where(a=>a.Data >= DateTime.Now);
        }

        public void UpdateList()
        {
            UpdatedRequestDriver = DataAccess.GetRequestDrivers().Where(a => a.Data >= DateTime.Now).ToList();
            if (cbArrival.SelectedIndex > 0)
                UpdatedRequestDriver = UpdatedRequestDriver.Where(a => a.PlaceArrival.City == cbArrival.SelectedItem as City).ToList();
            if (cbDeparture.SelectedIndex > 0)
                UpdatedRequestDriver = UpdatedRequestDriver.Where(a => a.PlaceDeparture.City == cbDeparture.SelectedItem as City).ToList();
            if (tbData.SelectedDate != null)
                UpdatedRequestDriver = UpdatedRequestDriver.Where(a => a.Data.Value.Date == tbData.SelectedDate.Value.Date).ToList();
            if (tbCount.Text != String.Empty)
                UpdatedRequestDriver = UpdatedRequestDriver.Where(a => a.FreeVenue >= Convert.ToInt32(tbCount.Text)).ToList();

            lvDrivers.ItemsSource = UpdatedRequestDriver;
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

        private void tbData_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void tbCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateList();
        }

        private void cbArrival_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void cbDeparture_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void lvDrivers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ListView).SelectedItem as RequestDriver;
            NavigationService.Navigate(new ProfileDriverPage(a.User));
        }
    }
}
