using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj34 : BaseProj
    {
        public override string Description => "Write a C# program to check if a string starts with a specified word. Note: Suppose the sentence starts with \"Hello\"";

        public override void Run()
        {
            var str = IsSpecifiedWord("Please enter a string: ");
            Console.WriteLine(str);
        }

        public bool IsSpecifiedWord(string message)
        {
            Console.WriteLine(message);
            var str = Console.ReadLine().Split(' ');

            if (str.Length < 1)
            {
                return false;
            }

            if (str[0].ToLower() == "hello")
            {
                return true;
            }

            return false;
        }
    }
}
