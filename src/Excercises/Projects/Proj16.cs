using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj16 : BaseProj
    {
        public override string Description => "Write a C# program to create a new string from a given string where the first and last characters change their positions.";

        public override void Run()
        {
            Console.WriteLine("Please enter a string: ");
            var str = Console.ReadLine();

            if (str.Length < 2)
            {
                Console.WriteLine($"The new string is {str}");

            }
            else if (str.Length == 2)
            {
                Console.WriteLine($"The new string is {str[1] + str[0]}");
            }
            else if (str.Length > 2)
            {
                var stringLeft = str.Substring(1, str.Length - 1);
                Console.WriteLine($"The new string is {str[str.Length - 1] + stringLeft + str[0]}");
            }
        }
    }
}
