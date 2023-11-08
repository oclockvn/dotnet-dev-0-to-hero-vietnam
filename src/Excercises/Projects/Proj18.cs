using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj18 : BaseProj
    {
        public override string Description => "Write a C# program to check a pair of integers and return true if one is negative and one is positive.";

        public override void Run()
        {
            var num1 = GetNumber("Please enter the first number: ");

            var num2 = GetNumber("Please enter the second number: ");

            if ((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
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
