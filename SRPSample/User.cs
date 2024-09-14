using System;
using System.Linq;

namespace SRP_Sample
{
    class User
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
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("User name cannot be empty. Please enter a valid name.");
                }
            } while (string.IsNullOrWhiteSpace(name));

            // Validate Password
            Console.WriteLine("Enter Password (min 6 characters, must contain at least one uppercase letter, one lowercase letter, and one number):");
            do
            {
                password = Console.ReadLine();

                if (password.Length < 6)
                {
                    Console.WriteLine("Password must be at least 6 characters long.");
                }

                bool hasUpper = false, hasLower = false, hasDigit = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsLower(c)) hasLower = true;
                    if (char.IsDigit(c)) hasDigit = true;
                }

                if (!hasUpper)
                {
                    Console.WriteLine("Password must contain at least one uppercase letter.");
                }

                if (!hasLower)
                {
                    Console.WriteLine("Password must contain at least one lowercase letter.");
                }

                if (!hasDigit)
                {
                    Console.WriteLine("Password must contain at least one number.");
                }

            } while (password.Length < 6 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit));

            // Validate Email
            Console.WriteLine("Enter Email:");
            do
            {
                email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                {
                    Console.WriteLine("Invalid email address. Please enter a valid email containing '@'.");
                }
            } while (string.IsNullOrWhiteSpace(email) || !email.Contains("@"));

            // If all validations pass
            Console.WriteLine($"User {name} added successfully with email {email}.");
        }
    }
}
