using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj35 : BaseProj
    {
        public override string Description => "Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.";

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
            if ((num1 < 100 && num2 > 200) || (num1 >200 && num2<100))
            {
                return true;
            }

            return false;
        }
    }
}
