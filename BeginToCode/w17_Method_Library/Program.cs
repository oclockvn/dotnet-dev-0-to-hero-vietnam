namespace w17_Method_Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter your password: ");
                var password = Console.ReadLine();

                if (IsValidPassword(password))
                {
                    Console.WriteLine("Password is valid");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password");
                }
            } while (true);

        }

        static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please enter password");
                return false;
            }

            if (password.Length < 6)
            {
                Console.WriteLine("Password must be at least 6 characters");
                return false;
            }
            else if (password.Length > 20)
            {
                Console.WriteLine("Password must have maximum 20 characters");
            }

            // Password must have number or special characters
            if (!password.Any(char.IsDigit) && !password.Any(char.IsPunctuation))
            {
                Console.WriteLine("Password must have number or special characters");
                return false;
            }

            // Password must have lowercase and uppercase characters
            if (!password.Any(char.IsLower) || !password.Any(char.IsUpper))
            {
                Console.WriteLine("Password must have lowercase and uppercase characters");
                return false;
            }

            return true;
        }
    }
}
