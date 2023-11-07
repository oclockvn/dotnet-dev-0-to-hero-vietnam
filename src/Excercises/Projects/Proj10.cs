namespace Exercises.Projects
{
    public class Proj10 : BaseProj
    {
        public override string Description => "Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.";

        public override void Run()
        {
            var x = GetNumber("Please enter the first number: ");
            var y = GetNumber("Please enter the second number: ");
            var z = GetNumber("Please enter the third number: ");

            var result1 = (x + y) * z;
            var result2 = (x * y) + (y * z);

            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, ({x}+{y})*{z} is {result1} and {x}*{y} + {y}*{z} is {result2}");
        }

        public int GetNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }
    }
}
