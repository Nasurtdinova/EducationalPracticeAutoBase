using BespokeFusion;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class MyProfilePage : Page
    {
        public MyProfilePage()
        {
            InitializeComponent();
            comboStump.ItemsSource = DataAccess.GetStamps();
            lvFeedBacks.ItemsSource = DataAccess.GetFeedbacks().Where(a => a.IdDriver == MotorDepotWindow.CurrentUser.Id);
            if (lvFeedBacks.Items.Count == 0)
                tbNoData.Visibility = Visibility.Visible;
            DataContext = MotorDepotWindow.CurrentUser;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MotorDepotWindow.CurrentUser.FullName = tbFullName.Text;
            MotorDepotWindow.CurrentUser.Login = tbLogin.Text;
            MotorDepotWindow.CurrentUser.DayOfBirth = tbBirthday.SelectedDate;
            MotorDepotWindow.CurrentUser.Car = comboModel.SelectedItem as Car;
            BdConnection.Connection.SaveChanges();
            MaterialMessageBox.Show("Информация сохранена!");
            NavigationService.Navigate(new MyProfilePage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnEditImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == true)
            {
                string path = file.FileName;
                MotorDepotWindow.CurrentUser.Image = File.ReadAllBytes(path);
                img.Source = new BitmapImage(new Uri(path));
            }
        }

        private void comboStump_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stamp = (sender as ComboBox).SelectedItem as Stamp;
            comboModel.ItemsSource = DataAccess.GetCars().Where(a => a.IdStamp == stamp.Id);
        }
    }
}
