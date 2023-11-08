using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj14 : BaseProj
    {
        public override string Description => "Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.";

        public override void Run()
        {
            var celsius = GetNumber("Please enter Celsius degrees: ");

            var kelvin = celsius + 273;
            var fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine($"Kelvin degree is {kelvin}");
            Console.WriteLine($"Fahrenheit degree is {fahrenheit}");
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
