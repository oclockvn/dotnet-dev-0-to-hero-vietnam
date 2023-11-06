namespace Ex06
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isNumber = false;
            while (!isNumber)
                {
                    Console.Write("Please enter number: ");
                    isNumber = int.TryParse(Console.ReadLine(), out int number);
                }
        }
    }
}
