using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj28 : BaseProj
    {
        public override string Description => "Write a C# program to reverse the words of a sentence.";

        public override void Run()
        {
            Console.WriteLine("Please enter the sentence: ");
            var sen = Console.ReadLine();
            var result = "";
            var words = sen.Split(new[] { ' ' }, StringSplitOptions.None);

            if (!sen.Contains(" "))
            {
                Console.WriteLine(sen);
            }

            var len = words.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                result += words[i] + " "; 
            }

            Console.WriteLine(result);
        }
    }
}
