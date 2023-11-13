using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj31 : BaseProj
    {
        public override string Description => "Write a C# program to multiply the corresponding elements of two integer arrays.";

        public override void Run()
        {
            
            var arr1 = new int[] {1,2,3,4};
            var arr2 = new int[] {5,6,7,8};
            var arr3 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] * arr2[i];
            }

            foreach (var item in arr3)
            {
                Console.WriteLine($"{item}");
            }
        }

        public int[] GetArray(string message) 
        {
            while (true)
            {
                Console.WriteLine(message);
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (arr.GetType() == typeof(Array))
                {
                    return arr;
                }
            }
        }
    }
}
