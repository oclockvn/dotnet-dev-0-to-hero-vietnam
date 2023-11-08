using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj17 : BaseProj
    {
        public override string Description => "Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.";

        public override void Run()
        {
            var str = GetString("Please enter a string: ");

            if (str.Length < 1)
            {
                Console.WriteLine("You have entered anything yet.");
            }
            else if (str.Length >= 1)
            {
                var newStr = str.Substring(0, 1);
                Console.WriteLine($"The new string is {newStr + str + newStr}");
            }
        }

        static string GetString(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                var str = Console.ReadLine();
                if (str != null)
                {
                    return str;
                }
            }
        }
    }
}
