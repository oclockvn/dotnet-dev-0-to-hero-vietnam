using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj19 : BaseProj
    {
        public override string Description => "Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.";

        public override void Run()
        {
            var num1 = GetNumber("Please enter the first number: ");
            var num2 = GetNumber("Please enter the second number: ");

            if (num1 != num2)
            {
                Console.WriteLine($"The sum of two number is: {num1 + num2}");
            }
            else
            {
                Console.WriteLine($"The result is {3 * (num1 + num2)}");
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
