using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj11 : BaseProj
    {
        public override string Description => "Write a C# Sharp program that takes an age (for example 20) as input and prints something like \"You look older than 20\"";

        public override void Run()
        {
            var age = GetNumber("Please enter your age: ");
            Console.WriteLine($"You look older than {Math.Abs(age)}");
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
