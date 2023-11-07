namespace Exercises.Projects
{
    public class Proj03 : BaseProj
    {
        public override string Description => "Write a C# Sharp program to print the result of dividing two numbers";

        public override void Run()
        {
            var firstNum = GetNumber("Please enter first number: ");
            var secondNum = GetNumber("Please enter second number: ");

            if (secondNum != 0)
            {
                var result = firstNum / secondNum;
                Console.WriteLine($"Result is {result}");
            }
            else
            {
                Console.WriteLine("The division can not be performed");
            }
        }

        public int GetNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }
    }
}
