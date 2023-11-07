namespace Ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstNum = GetNumber("Please enter the first number: ");

            var secondNum = GetNumber("Please enter the second number: ");

            var result = firstNum + secondNum;

            Console.WriteLine($"The sum of two number is : {result}");

            
        }

        static int GetNumber(string message)
        {
            bool invalid = false;
            var num = 0;
            while (!invalid)
            {
                Console.Write(message);
                invalid = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }
    }
}
