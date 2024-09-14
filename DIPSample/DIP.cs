using System;

namespace DIP_Compliant
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataStorage storage = new Database();  // Can easily swap with any other storage
            UserService userService = new UserService(storage);
            userService.SaveUser("Mani");
        }
    }

    // Abstract interface that both high-level and low-level modules depend on
    public interface IDataStorage
    {
        void Save(string data);
    }

    // Low-level module that implements the IDataStorage interface
    public class Database : IDataStorage
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to the database.");
        }
    }
    public class FileStorage : IDataStorage
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to a file.");
        }
    }


    // High-level module depends on IDataStorage abstraction, not on a specific implementation
    public class UserService
    {
        private readonly IDataStorage _storage;

        public UserService(IDataStorage storage)
        {
            _storage = storage;  // Depend on abstraction, not on concrete Database class
        }

        public void SaveUser(string username)
        {
            _storage.Save(username);  // Use the abstraction
        }
    }
}
