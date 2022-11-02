using BespokeFusion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public partial class PublishDriverPage : Window
    {
        public RequestDriver CurrentRequest = new RequestDriver();
        public PublishDriverPage(RequestDriver req)
        {
            InitializeComponent();

            comboCityArrival.ItemsSource = DataAccess.GetCities();
            comboCityDeparture.ItemsSource = DataAccess.GetCities();
            CurrentRequest.IdUser = MotorDepotWindow.CurrentUser.Id;
            Title = CurrentRequest.Id == 0 ? "Опубликовать поездку" : "Редактировать поездку";
            dpData.DisplayDateStart = DateTime.Now;
            if (req != null)
            {
                CurrentRequest = req;
                tbCountPeople.IsEnabled = false;
            }
            this.DataContext = CurrentRequest;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {           
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(CurrentRequest);

            if (!Validator.TryValidateObject(CurrentRequest, context, results, true))
            {
                foreach (var error in results)
                    MaterialMessageBox.ShowError(error.ErrorMessage);
            }
            else
            {
                if (Convert.ToInt32(tbCountPeople.Text) > 4)
                    MaterialMessageBox.ShowError("Вы не можете брать больше 4 человек!");
                else if (DataAccess.GetRequestDrivers().Where(a=>a.Data == dpData.SelectedDate).Count() != 0)
                    MaterialMessageBox.ShowError("В это время у вас уже запланирована другая поездка!");
                else
                {
                    DataAccess.SaveRequestDriver(CurrentRequest);
                    MaterialMessageBox.Show("Ваша поездка сохранена!", "Уведомление");
                    Close();
                }
            }
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
