using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj20 : BaseProj
    {
        public override string Description => "Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.";

        public override void Run()
        {
            var num1 = GetNumber("Please enter the first number: ");
            var num2 = GetNumber("Please enter the second number: ");

            var result = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine($"The result is {2 * (num1 - num2)}");
            }
            else
            {
                Console.WriteLine($"The result is {num2 - num1}");
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
    }
}
