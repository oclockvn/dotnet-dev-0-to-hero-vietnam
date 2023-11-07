using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj12 : BaseProj
    {
        public override string Description => "Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.";

        public override void Run()
        {
            var number = GetNumber("Please enter a number: ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.WriteLine(" ");

            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);

            Console.Write("{0} {0} {0} {0}",number);
            Console.WriteLine();
            Console.Write("{0}{0}{0}{0}",number);
            Console.WriteLine();

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
