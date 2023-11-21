using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj40 : BaseProj
    {
        public override string Description => "Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.";

        public override void Run()
        {
            var num1 = GetNumber("Please enter the first number: ");
            var num2 = GetNumber("Please enter the second number: ");

            var check = CheckNumber(num1, num2);
            Console.WriteLine($"The nearest value of 20 is: {check}");
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

        public int CheckNumber(int num1, int num2)
        {
            return ((num1 == num2) ? 0 : (Math.Abs(num1 - 20) > Math.Abs(num2 - 20) ? num1 : num2));
        }
    }
}
