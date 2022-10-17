using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorDepot
{
    public static class DataAccess
    {
        public static List<User> GetUsers()
        {
            return new List<User>(BdConnection.Connection.User);
        }

        public static List<RequestDriver> GetRequestDrivers()
        {
            return new List<RequestDriver>(BdConnection.Connection.RequestDriver);
        }

        public static List<FeedbackDriver> GetFeedbacks()
        {
            return new List<FeedbackDriver>(BdConnection.Connection.FeedbackDriver);
        }
        public static List<Car> GetCars()
        {
            return new List<Car>(BdConnection.Connection.Car);
        }
        public static List<Stamp> GetStamps()
        {
            return new List<Stamp>(BdConnection.Connection.Stamp);
        }

        public static List<HistoryClientDriver> GetHistoriesClientDriver()
        {
            return new List<HistoryClientDriver>(BdConnection.Connection.HistoryClientDriver);
        }

        public static List<City> GetCities()
        {
            return new List<City>(BdConnection.Connection.City);
        }

        public static List<PlaceArrival> GetPlacesArrival()
        {
            return new List<PlaceArrival>(BdConnection.Connection.PlaceArrival);
        }

        public static List<PlaceDeparture> GetPlacesDeparture()
        {
            return new List<PlaceDeparture>(BdConnection.Connection.PlaceDeparture);
        }

        public static List<Gender> GetGenders()
        {
            return new List<Gender>(BdConnection.Connection.Gender);
        }

        public static void SaveUser(User user)
        {
            if (user.Id != 0)
            {
                var us = GetUsers().Where(a => a.Id == user.Id).FirstOrDefault();
                us.Login = user.Login;
                us.Password = user.Password;
                us.FullName = user.FullName;
                us.Gender = user.Gender;
                us.DayOfBirth = user.DayOfBirth;
            }
            else
            {
                BdConnection.Connection.User.Add(user);                
            }
            BdConnection.Connection.SaveChanges();
        }

        public static void SaveHistoryClientDriver(HistoryClientDriver historyClientDriver)
        {
            if (historyClientDriver.Id != 0)
            {
                var us = GetHistoriesClientDriver().Where(a => a.Id == historyClientDriver.Id).FirstOrDefault();
                us.IdStatus = historyClientDriver.IdStatus;              
            }
            else
            {
                BdConnection.Connection.HistoryClientDriver.Add(historyClientDriver);               
            }
            BdConnection.Connection.SaveChanges();
        }

        public static void SaveRequestDriver(RequestDriver requestDriver)
        {
            if (requestDriver.Id != 0)
            {
                var us = GetRequestDrivers().Where(a => a.Id == requestDriver.Id).FirstOrDefault();
                us.Price = requestDriver.Price;
                us.CountPeople = requestDriver.CountPeople;
                us.Data = requestDriver.Data;
                us.Description = requestDriver.Description;
                us.PlaceDeparture = requestDriver.PlaceDeparture;
                us.PlaceArrival = requestDriver.PlaceArrival;
               
            }
            else
            {
                BdConnection.Connection.RequestDriver.Add(requestDriver);
            }
            BdConnection.Connection.SaveChanges();
        }
    }
}
