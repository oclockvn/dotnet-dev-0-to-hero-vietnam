using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj32 : BaseProj
    {
        public override string Description => "Write a C# program to create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one.";

        public override void Run()
        {
            var str = GetString("Please enter a string: ");
            var arr = str.Split(' ');

            if (arr.Length >= 4)
            {
                for (int i = arr.Length - 1; i > 0 ; i--)
                {
                    if (arr[i].Length == 4)
                    {
                        Console.Write($"{arr[i]}");
                        Console.Write($"{arr[i]}");
                        Console.Write($"{arr[i]}");
                        Console.WriteLine($"{arr[i]}");
                        break;
                    }
                }
            }
            else 
            {
                Console.WriteLine(str);
            }
        }

        public string GetString(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                var str = Console.ReadLine();
                if (str != null)
                {
                    return str;
                }
            }
        }
    }
}
