using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj37 : BaseProj
    {
        public override string Description => "Write a C# program to check if \"HP\" appears at the second position in a string and return the string without \"HP\".";

        public override void Run()
        {
            Console.WriteLine("Please enter a string: ");
            var str = Console.ReadLine();

            Console.WriteLine(str.Substring(1, 2) == "HP" ? str.Remove(1, 2) : "String doesn't contain \"HP\"");
        }
    }
}
