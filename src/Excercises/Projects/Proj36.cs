using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj36 : BaseProj
    {
        public override string Description => "Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.";

        public override void Run()
        {
            var num1 = GetNumber("Please enter the first number: ");
            var num2 = GetNumber("Please enter the second number: ");

            var check = CheckNumber(num1, num2);
            Console.WriteLine(check);
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

        public bool CheckNumber(int num1, int num2)
        {
            if ((-10 <= num1 && num1 >= 10) || (-10 <= num2 && num2 >= 10))
            {
                return true;
            }

            return false;
        }
    }
}
