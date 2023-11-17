using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj44 : BaseProj
    {
        public override string Description => "Write a C# program to create a string of every other character (odd position) from the first position of a given string.";

        public override void Run()
        {
            var str = GetString("Please enter a string: ");
            var newStr = CreateNewString(str);
            Console.WriteLine(newStr);
        }

        public string GetString(string message)
        {
            while (true)
            {
                Console.Write(message);
                var str = Console.ReadLine();
                if (str.Length > 0)
                {
                    return str;
                }
            }
        }

        public string CreateNewString(string str)
        {
            var newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i%2 == 0)
                {
                    newStr += str[i];
                }
            }

            return newStr;
        }
    }
}
