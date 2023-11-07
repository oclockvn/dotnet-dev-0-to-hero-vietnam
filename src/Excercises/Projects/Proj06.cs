namespace Exercises.Projects
{
    public class Proj06 : BaseProj
    {
        public override string Description => "Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user";

        public override void Run()
        {
            var firstNum = GetNumber("Please enter the first number: ");
            var secondNum = GetNumber("Please enter the second number: ");
            var thirdNum = GetNumber("Please enter the third number: ");

            var result = firstNum * secondNum * thirdNum;
            Console.WriteLine($"{firstNum}*{secondNum}*{thirdNum} = {result}");
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
