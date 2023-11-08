using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj22 : BaseProj
    {
        public override string Description => "Write a C# program to check if the given integer is within 20 of 100 or 200.";

        public override void Run()
        {
            var num = GetNumber("Please enter a number: ");

            if (Math.Abs(num - 100) <= 20 || Math.Abs(num - 200) <= 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
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
