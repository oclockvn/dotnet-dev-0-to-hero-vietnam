namespace Ex03
{
    internal class Program
    {
        // write a program to sum 2 numbers from user input
        static void Main(string[] args)
        {
            var firstNumber = GetNumber("Enter first number: ");
            var secondNumber = GetNumber("Enter second number: ");
            var sum = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
        }

        // extract a method to avoid duplicate code
        static int GetNumber(string message)
        {
            var valid = false;
            int num = 0;
            while (!valid)
            {
                Console.Write(message);
                valid = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }
    }
}
