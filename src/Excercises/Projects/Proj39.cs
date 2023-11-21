using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj39 : BaseProj
    {
        public override string Description => " Write a C# program to find the largest and lowest values from three integer values.\r\nTest Data:";

        public override void Run()
        {
            var num1 = GetNumber("Please enter number 1: ");
            var num2 = GetNumber("Please enter number 2: ");
            var num3 = GetNumber("Please enter number 3: ");

            var arr = new int[] { num1, num2, num3 };
            var largest = 0;
            var lowest = 0;

            
            if (num1 > num2 )
            {
                largest = num1 > num3 ? num1 : num3;
            }
            else
            {
                largest = num2 > num3 ? num2 : num3;
            }
            


            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j <= arr.Length; j++)
            //    {
            //        if (arr[i] >= arr[j])
            //        {
            //            largest = arr[i];
            //            lowest = arr[j];
            //        }
            //        else
            //        {
            //            largest = arr[j];
            //            lowest = arr[i];
            //        }
            //    }
            //}
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine($"The lowest number is: {lowest}");
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
