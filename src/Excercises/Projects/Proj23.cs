namespace Exercises.Projects
{
    public class Proj23 : BaseProj
    {
        public override string Description => "Write a C# program to convert a given string into lowercase.";

        public override void Run()
        {
            Console.WriteLine("Please enter a string: ");
            var str = Console.ReadLine();

            if (str.Length >= 1)
            {
                Console.WriteLine(str.ToLower());
            }
            else { Console.WriteLine("Nothing happened!"); }
        }
    }
}
