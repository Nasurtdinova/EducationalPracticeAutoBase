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
            dgDrivers.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            PublishDriverPage publishDriver = new PublishDriverPage(null);
            publishDriver.Show();
            publishDriver.Closed += (s, eventarg) =>
            {
                dgTrips.ItemsSource = DataAccess.GetRequestDrivers().Where(a => a.IdUser == MainWindow.CurrentUser.Id);
            };
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as RequestDriver;
            PublishDriverPage publishDriver = new PublishDriverPage(req);
            publishDriver.Show();
            publishDriver.Closed += (s, eventarg) =>
            {
                dgTrips.ItemsSource = DataAccess.GetRequestDrivers().Where(a => a.IdUser == MainWindow.CurrentUser.Id);
            };
        }

        private void btnFeedback_Click(object sender, RoutedEventArgs e)
        {
            var his = (sender as Button).DataContext as HistoryClientDriver;
            SendFeedbackWindow wins = new SendFeedbackWindow(his);
            wins.Show();
            wins.Closed += (s, eventarg) =>
            {
                dgDrivers.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
            };
        }
    }
}
