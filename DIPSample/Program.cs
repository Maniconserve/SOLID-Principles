using DIP_Compliant;
using System;

namespace DIP_Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            userService.SaveUser("Mani");
        }
    }

    public class Database
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to the database.");
        }
    }
    public class UserService
    {
        private Database database;

        public UserService()
        {
            database = new Database();  // Tight coupling to Database class
        }

        public void SaveUser(string username)
        {
            database.Save(username);  // Directly dependent on Database class
        }
    }
}
