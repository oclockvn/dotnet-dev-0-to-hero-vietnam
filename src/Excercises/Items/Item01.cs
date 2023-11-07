using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Item01 : BaseItem
    {
        public override string Description => "Write a C# Sharp program to print Hello and your name in a separate line";

        public override void Run()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("John");
        }
    }
}
