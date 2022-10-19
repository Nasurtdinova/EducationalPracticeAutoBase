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
    public partial class IncomingPage : Page
    {
        public IncomingPage()
        {
            InitializeComponent();
            lvRequestsClients.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MainWindow.CurrentUser.Id);
            lvMyRequests.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as HistoryClientDriver;
            if (MessageBox.Show("Вы хотите принять заявку?", "Уведомление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
                req.IdStatus = 3;
            else
                req.IdStatus = 2;
            BdConnection.Connection.SaveChanges();
        }

        private void rbMyRequest_Click(object sender, RoutedEventArgs e)
        {
            lvMyRequests.Visibility = Visibility.Visible;
            lvRequestsClients.Visibility = Visibility.Collapsed;
            tbDataClients.Visibility = Visibility.Collapsed;
            if (lvMyRequests.Items.Count == 0)
            {
                tbDataMy.Visibility = Visibility.Visible;                
                lvMyRequests.Visibility = Visibility.Collapsed;
            }
        }

        private void rbRequestClient_Click(object sender, RoutedEventArgs e)
        {
            lvMyRequests.Visibility = Visibility.Collapsed;
            lvRequestsClients.Visibility = Visibility.Visible;
            tbDataMy.Visibility = Visibility.Collapsed;
            if (lvRequestsClients.Items.Count == 0)
            {
                tbDataClients.Visibility = Visibility.Visible;                
                lvRequestsClients.Visibility = Visibility.Collapsed;
            }
        }

        private void btnRevoke_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
