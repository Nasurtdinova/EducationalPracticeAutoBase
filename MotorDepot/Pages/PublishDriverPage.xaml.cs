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
    /// <summary>
    /// Логика взаимодействия для PublishDriverPage.xaml
    /// </summary>
    public partial class PublishDriverPage : Page
    {
        public RequestDriver CurrentRequest = new RequestDriver();
        public PublishDriverPage(RequestDriver req)
        {
            InitializeComponent();

            comboCityArrival.ItemsSource = DataAccess.GetCities();
            comboCityDeparture.ItemsSource = DataAccess.GetCities();
            CurrentRequest.IdUser = MainWindow.CurrentUser.Id;
            if (req != null)
                CurrentRequest = req;
            this.DataContext = CurrentRequest;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.SaveRequestDriver(CurrentRequest);
            MessageBox.Show("Ваша поездка сохранена!", "Уведомление");
            NavigationService.Navigate(new ComingTripsPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void comboCityDeparture_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var city = (sender as ComboBox).SelectedItem as City;
            comboStreetDeparture.ItemsSource = DataAccess.GetPlacesDeparture().Where(a => a.City == city);
        }

        private void comboCityArrival_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var city = (sender as ComboBox).SelectedItem as City;
            comboStreetArrival.ItemsSource = DataAccess.GetPlacesArrival().Where(a => a.City == city);
        }
    }
}
