using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj24 : BaseProj
    {
        public override string Description => "Write a C# program to find the longest word in a string.";

        public override void Run()
        {
            Console.WriteLine("Please enter a string: ");
            var str = Console.ReadLine();
            var words = str.Split(new[] { " " }, StringSplitOptions.None);
            var word = "";
            var numChar = 0;

            if (str.Length < 2)
            {
                Console.WriteLine();
            }

            foreach (var w in words)
            {
                if (w.Length > numChar)
                {
                    word = w;
                    numChar = w.Length;
                }

            }
            Console.WriteLine($"The longest word in the string is: {word}");
        }
    }
}
