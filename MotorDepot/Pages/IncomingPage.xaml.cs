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
    public partial class IncomingPage : Page
    {
        public IncomingPage()
        {
            InitializeComponent();
            lvRequestsClients.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MainWindow.CurrentUser.Id && a.IdStatus == 1 || a.IdStatus == 4) ;
            lvMyRequests.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as HistoryClientDriver;
            //if (req.CountPeople > req.RequestDriver.FreeVenue)
            //{
            //    MaterialMessageBox.ShowError($"У вас только {req.RequestDriver.FreeVenue} место") ;
            //}
            //else
            //{
                CustomMaterialMessageBox msg = new CustomMaterialMessageBox
                {
                    TxtMessage = { Text = "Вы хотите принять заявку?" },
                    TxtTitle = { Text = "Уведомление" },
                    BtnOk = { Content = "Да" },
                    BtnCancel = { Content = "Нет" }
                };
                msg.Show();
                if (msg.Result == MessageBoxResult.OK)
                    req.IdStatus = 3;
                else
                    req.IdStatus = 2;
                BdConnection.Connection.SaveChanges();
                lvRequestsClients.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MainWindow.CurrentUser.Id && a.IdStatus == 1);
            //}
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
            var a = (sender as Button).DataContext as HistoryClientDriver;
            a.IdStatus = 4;
            BdConnection.Connection.SaveChanges();
            MaterialMessageBox.Show("Вы отменили поездку!");
            lvMyRequests.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(b => b.IdClient == MainWindow.CurrentUser.Id);
        }
    }
}
