namespace Exercises.Projects
{
    public class Proj09 : BaseProj
    {
        public override string Description => "Write a C# Sharp program that takes four numbers as input to calculate and print the average";

        public override void Run()
        {
            var num1 = GetNumber("Please enter the number 1: ");
            var num2 = GetNumber("Please enter the number 2: ");
            var num3 = GetNumber("Please enter the number 3: ");
            var num4 = GetNumber("Please enter the number 4: ");

            var average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");
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
