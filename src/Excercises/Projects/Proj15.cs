namespace Exercises.Projects
{
    public class Proj15 : BaseProj
    {
        public override string Description => "Write a C# program that removes a specified character from a non-empty string using the index of a character.";

        public override void Run()
        {
            var str = GetString("Please enter a non-empty string: ");
            var num = GetNumber("Please enter a number: ");
            if (num < str.Length)
            {
                var newString = RemoveCharacter(str, num);
                Console.WriteLine(newString);
            }
            else
            {
                Console.WriteLine("Cannot perform this requiration.");
            }
        }

        static int GetNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }

        static string GetString(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                var str = Console.ReadLine();
                if (!str.Contains(" "))
                {
                    return str;
                }
            }
        }

        static string RemoveCharacter(string str, int num)
        {
            return str.Remove(num, 1);
        }
    }
}

