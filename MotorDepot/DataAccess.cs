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

        public static List<HistoryClientDriver> GetHistoriesClientDriver()
        {
            return new List<HistoryClientDriver>(BdConnection.Connection.HistoryClientDriver);
        }

        public static List<City> GetCities()
        {
            return new List<City>(BdConnection.Connection.City);
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
    }
}
