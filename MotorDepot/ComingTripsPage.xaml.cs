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
    public partial class ComingTripsPage : Page
    {
        public ComingTripsPage()
        {
            InitializeComponent();
            dgTrips.ItemsSource = DataAccess.GetRequestDrivers().Where(a => a.IdUser == MainWindow.CurrentUser.Id);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PublishDriverPage(null));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as RequestDriver;
            NavigationService.Navigate(new PublishDriverPage(a));
        }
    }
}
