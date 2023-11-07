using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj05 : BaseProj
    {
        public override string Description => "Write a C# Sharp program to swap two numbers";

        public override void Run()
        {
            var firstNum = GetNumber("Please enter first number: ");
            var secondNum = GetNumber("Please enter second number: ");

            var temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

            Console.WriteLine($"The first number is {firstNum}");
            Console.WriteLine($"The second number is {secondNum}");
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
