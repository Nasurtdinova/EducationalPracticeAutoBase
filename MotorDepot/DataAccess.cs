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
                BdConnection.Connection.SaveChanges();
            }
        }
    }
}
