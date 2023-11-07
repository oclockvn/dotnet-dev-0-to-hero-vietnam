namespace Exercises.Projects
{
    public class Proj08 : BaseProj
    {
        public override string Description => "Write a C# Sharp program that prints the multiplication table of a number as input.";

        public override void Run()
        {
            var firstNum = GetNumber("Please enter a number: ");

            for (var i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{ firstNum}*{i} = {firstNum*i}");
            }
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
