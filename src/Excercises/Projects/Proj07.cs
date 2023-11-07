namespace Exercises.Projects
{
    public class Proj07 : BaseProj
    {
        public override string Description => "Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user";

        public override void Run()
        {
            var firstNum = GetNumber("Please enter the first number: ");
            var secondNum = GetNumber("Please enter the second number: ");

            var adding = firstNum + secondNum;
            var subtracting = firstNum - secondNum;
            var multiplying = firstNum * secondNum;
            float dividing = 0;
            if (secondNum != 0)
            {
                dividing = firstNum / secondNum;
            }

            var mod = firstNum % secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {adding}");
            Console.WriteLine($"{firstNum} - {secondNum} = {subtracting}");
            Console.WriteLine($"{firstNum} * {secondNum} = {multiplying}");
            Console.WriteLine(secondNum == 0 ? "The division can not be performed." : $"{firstNum} / {secondNum} = {dividing}");
            Console.WriteLine($"{firstNum} % {secondNum} = {mod}");
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
