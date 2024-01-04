using System.Text.RegularExpressions;

namespace Register;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your email: ");
        var enteredEmail = Console.ReadLine();

        if (IsEmailUnique(enteredEmail))
        {
            Console.WriteLine("Please enter your password: ");
            var enteredPassword = Console.ReadLine();

            var passwordValidationResult = IsValidPassword(enteredPassword);
            if (passwordValidationResult.valid)
            {
                RegisterUser(new Register { Email = enteredEmail, Password = enteredPassword });
                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine($"Password validation failed: {passwordValidationResult.error}");
            }
        }
        else
        {
            Console.WriteLine("Email is already registered.Please use a different email.");
        }
    }

    class Register
    {
        public string Email {  get; set; }
        public string Password { get; set; }
    }

    static List<string> registerEmail = new();

    static (bool valid, string? error) IsValidPassword(string password,
        int min = 6,
        int max = 20,
        bool requiresSpecialCharacters = true,
        bool requiresLowercaseUpperCase = true,
        bool requiresNumber = true)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            return (false, "Password must not empty");
        }

        if (password.Length < min)
        {
            return (false, $"Password must have minimum {min} character");
        }

        if (password.Length > max)
        {
            return (false, $"Password must have maximum {max} character");
        }

        if (requiresSpecialCharacters)
        {
            if (!Regex.IsMatch(password, @".*[^a-zA-Z0-9].*"))
                return (false, "Password must have special characters");
        }

        if (requiresLowercaseUpperCase)
        {
            if (!Regex.IsMatch(password, "[a-z]") || !Regex.IsMatch(password, "[A-Z]"))
                return (false, "Password must have lowercase and uppercase");
        }

        if (requiresNumber)
        {
            if (!Regex.IsMatch(password, ".*\\d.*"))
                return (false, "Password must have numbers");
        }

        return (true, null);
    }

    static bool IsEmailUnique(string email)
    {
        return !registerEmail.Contains(email);
    }

    static void RegisterUser(Register user)
    {
        registerEmail.Add(user.Email);
    }
}
