
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj33 : BaseProj
    {
        public override string Description => "Write a C# program to check if a given positive number is a multiple of 3 or 7.";

        public override void Run()
        {
            var num = GetNumber("Please enter a numbre: ");
            Console.WriteLine(CheckNumber(num));
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

        public bool CheckNumber(int number)
        {
            if (number%3 == 0 || number%7==0)
            {
                return true;
            }
            
            return false;
        }
    }
}
