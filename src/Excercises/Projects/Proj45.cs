using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj45 : BaseProj
    {
        public override string Description => "Write a C# program to count a specified number in a given array of integers.";

        public override void Run()
        {
            var arr = new int[] { 1,2,3,2,3,4,5,6,7,8,9,0,9,8,9,8,6,6,0,4,6,4,3,2,1};
            var num = GetNumber("Please enter a number: ");
            var count = 0;

            foreach (var a in arr)
            {
                if (num == a)
                {
                    count++;
                }
            }

            Console.WriteLine($"The number {num} occurs {count} in an array.");
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
