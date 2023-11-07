namespace Ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            var num = 0;
            while (!invalid)
            {
                Console.WriteLine("Please enter number: ");
                invalid = int.TryParse(Console.ReadLine(), out num);
            }

            Console.WriteLine($"{num}^2 = {Math.Pow(num, 2)}");
        }
    }
}
