namespace Ex04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter input: ");
            var input = Console.ReadLine();

            bool isNumber = int.TryParse(input, out int number);

            if (isNumber)
            {
                Console.WriteLine(Environment.NewLine + $"The number is : {number}");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "The input is not a number");
            }
        }
    }
}
