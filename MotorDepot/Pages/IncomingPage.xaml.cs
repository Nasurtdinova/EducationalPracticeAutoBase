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
            lvNewRequestsClients.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MotorDepotWindow.CurrentUser.Id && a.IdStatus == 1 && a.RequestDriver.Data >= DateTime.Now).OrderBy(a => a.Data);
            lvOldRequestsClients.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MotorDepotWindow.CurrentUser.Id && a.IdStatus != 1).OrderBy(a=>a.Data);
            lvMyRequests.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.IdClient == MotorDepotWindow.CurrentUser.Id);
            UpdateTab();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext as HistoryClientDriver;
            if (req.CountPeople > req.RequestDriver.FreeVenue)
            {
                MaterialMessageBox.ShowError($"У вас мест нет!");
            }
            else
            {
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
                lvNewRequestsClients.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(a => a.RequestDriver.IdUser == MotorDepotWindow.CurrentUser.Id && a.IdStatus == 1).OrderBy(a => a.Data);
                UpdateTab();
            }
        }

        private void rbMyRequest_Click(object sender, RoutedEventArgs e)
        {
            UpdateTab();
        }

        private void rbRequestClient_Click(object sender, RoutedEventArgs e)
        {
            UpdateTab();
        }

        public void UpdateTab()
        {
            if (rbMyRequest.IsChecked == true)
            {
                lvMyRequests.Visibility = Visibility.Visible;
                tabNew.Visibility = Visibility.Collapsed;
                if (lvMyRequests.Items.Count == 0)
                {
                    tbDataMy.Visibility = Visibility.Visible;
                    lvMyRequests.Visibility = Visibility.Collapsed;
                }
                else
                {
                    tbDataMy.Visibility = Visibility.Collapsed;
                }
            }
            if (rbRequestClient.IsChecked == true)
            {
                tabNew.Visibility = Visibility.Visible;
                lvMyRequests.Visibility = Visibility.Collapsed;
                tbDataMy.Visibility = Visibility.Collapsed;
                if (lvNewRequestsClients.Items.Count == 0)
                {
                    tbNewDataClients.Visibility = Visibility.Visible;
                    lvNewRequestsClients.Visibility = Visibility.Collapsed;
                }
                if (lvOldRequestsClients.Items.Count == 0)
                {
                    tbOldDataClients.Visibility = Visibility.Visible;
                    lvOldRequestsClients.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void btnRevoke_Click(object sender, RoutedEventArgs e)
        {
            CustomMaterialMessageBox msg = new CustomMaterialMessageBox
            {
                TxtMessage = { Text = "Вы точно хотите отменить поездку?" },
                TxtTitle = { Text = "Уведомление" },
                BtnOk = { Content = "Да" },
                BtnCancel = { Content = "Нет" }
            };
            msg.Show();
            if (msg.Result == MessageBoxResult.OK)
            {
                var a = (sender as Button).DataContext as HistoryClientDriver;
                a.IdStatus = 4;
                BdConnection.Connection.SaveChanges();
                MaterialMessageBox.Show("Вы отменили поездку!");
                lvMyRequests.ItemsSource = DataAccess.GetHistoriesClientDriver().Where(b => b.IdClient == MotorDepotWindow.CurrentUser.Id);
            }
        }
    }
}
