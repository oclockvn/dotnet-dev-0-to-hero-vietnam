namespace Ex06
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isNumber = false;
            var number = 0;
            while (!isNumber)
                {
                    Console.Write("Please enter number: ");
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                }
            Console.WriteLine($"Your number is {number}");
        }
    }
}
