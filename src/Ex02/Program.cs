namespace Ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number: ");

            var num = int.Parse(Console.ReadLine());
            var pow = Math.Pow(num, 2);

            Console.WriteLine("The Result is: " + pow);
        }
    }
}
