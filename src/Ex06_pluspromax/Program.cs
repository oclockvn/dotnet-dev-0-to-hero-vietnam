namespace Ex06_pluspromax
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isNumber = false;
            var number = 0;
            do
            {
                Console.Write("Please enter number: ");
                isNumber = int.TryParse(Console.ReadLine(), out number);
            } while (!isNumber);

            Console.WriteLine($"Your number is {number}");
        }
    }
}
