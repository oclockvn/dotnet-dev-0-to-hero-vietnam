namespace Ex06_pluspromax
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isNumber = false;
            do
            {
                Console.Write("Please enter number: ");
                isNumber = int.TryParse(Console.ReadLine(), out int number);
            } while (!isNumber);
        }
    }
}
