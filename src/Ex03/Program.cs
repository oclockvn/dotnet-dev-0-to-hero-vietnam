namespace Ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            var firstNum = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            var secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of two number is : {firstNum + secondNum}");
        }
    }
}
