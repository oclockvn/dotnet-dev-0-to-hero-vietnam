using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj43 : BaseProj
    {
        public override string Description => "Write a C# program to check if a given string starts with \"w\" and is immediately followed by two \"ww\".";

        public override void Run()
        {
            var str = GetString("Please enter a string: ");

            if (str.ToLower()[0] != 'w')
            {
                Console.WriteLine(false);
            }
            else if (str.ToLower()[0] == 'w' && str.Substring(1,2).ToLower() == "ww")
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
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
    }
}
