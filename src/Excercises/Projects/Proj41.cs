using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj41 : BaseProj
    {
        public override string Description => "Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.";

        public override void Run()
        {
            var str = GetString("Please enter a string: ");
            var check = CheckString(str);

            Console.WriteLine(check);
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

        public bool CheckString(string str)
        {
            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ToLower()[i] == 'w')
                {
                    count++;
                }
            }

            if (count >= 1 && count <= 3)
            {
                return true;
            }

            return false;
        }
    }
}
