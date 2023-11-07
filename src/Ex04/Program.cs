namespace Ex04
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter number: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out var num);

            if (isNumber)
            {
                Console.WriteLine(Environment.NewLine + $"The number is : {num}");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "The input is not a number");
            }
        }
    }
}
