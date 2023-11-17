using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj42 : BaseProj
    {
        public override string Description => "Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.";

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
                Console.WriteLine(message);
                var str = Console.ReadLine();
                if (str.Length > 0)
                {
                    return str;
                }
            }
        }

        public string CreateNewString(string str)
        {
            if (str.Length <= 4)
            {
                return str.ToUpper();
            }
            else
            {
                return str.Substring(0, 4).ToLower() + str.Substring(4,str.Length - 4);
            }
        }
    }
}
