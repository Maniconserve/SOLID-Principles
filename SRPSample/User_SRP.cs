using System;

namespace SRP_Sample
{
    class User_SRP
    {
        private string name;
        private string password;
        private string email;

        public void AddUser()
        {
            // Validate User Name
            Console.WriteLine("Enter User Name:");
            do
            {
                name = Console.ReadLine();
            } while (!UserValidator.ValidateUserName(name));

            // Validate Password
            Console.WriteLine("Enter Password (min 6 characters, must contain at least one uppercase letter, one lowercase letter, and one number):");
            do
            {
                password = Console.ReadLine();
            } while (!UserValidator.ValidatePassword(password));

            // Validate Email
            Console.WriteLine("Enter Email:");
            do
            {
                email = Console.ReadLine();
            } while (!UserValidator.ValidateEmail(email));

            // If all validations pass
            Console.WriteLine($"User {name} added successfully with email {email}.");
        }
    }
}
