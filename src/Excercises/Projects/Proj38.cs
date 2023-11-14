using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj38 : BaseProj
    {
        public override string Description => "Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be \"P\" and \"H\", so PHP will be \"PH\".";

        public override void Run()
        {
            var str = GetString("Please enter a string at least containing 3 letters: ");

            if (str.ToLower()[1].Equals('p') && str.ToLower()[2].Equals('h'))
            {
                Console.WriteLine(str.Substring(1,2).ToUpper());
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
                if (str.Length >= 3)
                {
                    return str;
                }
            }
        }
    }
}
