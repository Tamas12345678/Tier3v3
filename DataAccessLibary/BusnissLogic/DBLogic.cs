using DataAccessLibary.DataAccess;
using DataAccessLibary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibary.BusnissLogic
{
    public static class DBLogic
    {
        public static int CreateUser(int userId, string firstName, string lastName, string emailAddress, int age)
        {
            DataModell data = new DataModell
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Age = age
            };

            string sql = @"INSERT INTO [dbo].[User](UserId,FirstName, LastName, EmailAddress,Age) VALUES (@UserId, @FirstName, @LastName, @EmailAddress, @Age);";

            return DBHelper.SaveData(sql, data);
        }

        public static List<DataModell> LoadUsers()
        {
            string sql = @"SELECT UserId, FirstName, LastName, EmailAddress, Age FROM [dbo].[User];";

            return (List<DataModell>)DBHelper.LoadData<DataModell>(sql);
        }
    }
}
