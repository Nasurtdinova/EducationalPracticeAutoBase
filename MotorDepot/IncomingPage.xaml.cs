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
            UpdateList();
        }

        public void UpdateList()
        {
            lvRequestsClients.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MainWindow.CurrentUser.Id);
            lvMyRequests.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
            if (lvRequestsClients.Items.Count == 0)
            {
                tbDataClients.Visibility = Visibility.Visible;
                lvRequestsClients.Visibility = Visibility.Collapsed;
            }
            
            if (lvMyRequests.Items.Count == 0)
            {
                tbDataMy.Visibility = Visibility.Visible;
                lvMyRequests.Visibility = Visibility.Collapsed;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as HistoryClientDriver;
            if (MessageBox.Show("Вы хотите принять заявку?","Уведомление",MessageBoxButton.YesNoCancel,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {

            }
        }

        private void rbMyRequest_Click(object sender, RoutedEventArgs e)
        {
            lvMyRequests.Visibility = Visibility.Visible;
            lvRequestsClients.Visibility = Visibility.Collapsed;
            UpdateList();
        }

        private void rbRequestClient_Click(object sender, RoutedEventArgs e)
        {
            lvMyRequests.Visibility = Visibility.Collapsed;
            lvRequestsClients.Visibility = Visibility.Visible;
            UpdateList();
        }

        private void btnRevoke_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
