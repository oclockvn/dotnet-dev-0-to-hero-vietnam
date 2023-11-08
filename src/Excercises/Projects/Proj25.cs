using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj25 : BaseProj
    {
        public override string Description => "Write a C# program to print odd numbers from 1 to 99. Prints one number per line.";

        public override void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                Console.WriteLine(i);
                }
            }
        }
    }
}
