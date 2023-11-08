using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj27 : BaseProj
    {
        public override string Description => "Write a C# program and compute the sum of an integer's digits.";

        public override void Run()
        {
            var num = GetNumber("Please enter a number: ");

            if (num <= 10)
            {
                Console.WriteLine(num);
            }
            else
            {
                var digit = num.ToString();
                var sum = 0;
                foreach (var d in digit) 
                {
                   sum += int.Parse(d.ToString());
                }
                Console.WriteLine(sum);
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
