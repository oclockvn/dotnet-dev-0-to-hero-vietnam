using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj21 : BaseProj
    {
        public override string Description => "Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.";

        public override void Run()
        {
            var num1 = GetNumber("Please enter the first number: ");
            var num2 = GetNumber("Please enter the second number: ");
            var sum = num1 + num2;

            if (sum == 20 || num1 == 20 || num2 == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
                Console.WriteLine($"The sum of two number is {sum}");
            }
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
