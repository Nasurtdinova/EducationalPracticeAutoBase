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
    public partial class ComingTripsPage : Page
    {
        public ComingTripsPage()
        {
            InitializeComponent();
            dgTrips.ItemsSource = DataAccess.GetRequestDrivers().Where(a => a.IdUser == MainWindow.CurrentUser.Id);
            dgDrivers.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
            if (dgTrips.Items.Count == 0)
            {
                tbDataTrips.Visibility = Visibility.Visible;
                dgTrips.Visibility = Visibility.Collapsed;
            }
            if (dgDrivers.Items.Count == 0)
            {
                tbDataDriver.Visibility = Visibility.Visible;
                dgDrivers.Visibility = Visibility.Collapsed;
            }
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
            if (DataAccess.GetFeedbacks().Where(a => a.IdUser == MainWindow.CurrentUser.Id && a.IdDriver == his.RequestDriver.IdUser) == null)
            {
                SendFeedbackWindow wins = new SendFeedbackWindow(his);
                wins.Show();
                wins.Closed += (s, eventarg) =>
                {
                    dgDrivers.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
                };
            }
            else
            {
                CustomMaterialMessageBox msg = new CustomMaterialMessageBox
                {
                    TxtMessage = { Text = "Вы уже написали отзыв хотите написать еще?" },
                    TxtTitle = { Text = "Уведомление" },
                    BtnOk = { Content = "Да" },
                    BtnCancel = { Content = "Нет" }
                };
                msg.Show();
                if (msg.Result == MessageBoxResult.OK)
                {
                    SendFeedbackWindow wins = new SendFeedbackWindow(his);
                    wins.Show();
                    wins.Closed += (s, eventarg) =>
                    {
                        dgDrivers.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MainWindow.CurrentUser.Id);
                    };
                }
            }
        }

        private void btnRemoveClient_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as HistoryClientDriver;
            a.IdStatus = 2;
            BdConnection.Connection.SaveChanges();
            dgTrips.ItemsSource = DataAccess.GetRequestDrivers().Where(b => b.IdUser == MainWindow.CurrentUser.Id);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var a = (sender as Button).DataContext as RequestDriver;
            a.IsDeleted = true;
            BdConnection.Connection.SaveChanges();
        }
    }
}
