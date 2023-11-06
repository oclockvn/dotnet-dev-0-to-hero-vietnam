namespace Ex05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your birth year: ");
            var year = int.Parse(Console.ReadLine());

            var age = DateTime.Now.Year - year;
            Console.WriteLine(Environment.NewLine + $"Your age is: {age}");
        }
    }
}
