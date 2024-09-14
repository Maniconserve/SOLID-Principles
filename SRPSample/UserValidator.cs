using System;

namespace SRP_Sample
{
    public class UserValidator
    {
        // Validate the user name
        public static bool ValidateUserName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("User name cannot be empty. Please enter a valid name.");
                return false;
            }
            return true;
        }

        // Validate the password
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("Password must be at least 6 characters long.");
                return false;
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
                return false;
            }

            if (!hasLower)
            {
                Console.WriteLine("Password must contain at least one lowercase letter.");
                return false;
            }

            if (!hasDigit)
            {
                Console.WriteLine("Password must contain at least one number.");
                return false;
            }

            return true;
        }

        // Validate the email
        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("Invalid email address. Please enter a valid email containing '@'.");
                return false;
            }
            return true;
        }
    }
}
