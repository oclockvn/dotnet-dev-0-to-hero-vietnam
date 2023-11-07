using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj13 : BaseProj
    {
        public override string Description => "Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.";

        public override void Run()
        {
            var number = GetNumber("Please enter a number: ");

            Console.WriteLine("{}{}{}", number);
            Console.WriteLine("{} {}", number);
            Console.WriteLine("{} {}", number);
            Console.WriteLine("{} {}", number);
            Console.WriteLine("{}{}{}", number);
        }

        public int GetNumber(string message)
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
    }
}
