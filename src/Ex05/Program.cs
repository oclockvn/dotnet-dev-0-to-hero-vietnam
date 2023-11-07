namespace Ex05
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            var year = 0;
            while (!invalid)
            {
            Console.Write("Please enter your birth year: ");
            invalid = int.TryParse(Console.ReadLine(), out year);
            }

            var age = DateTime.Now.Year - year;
            Console.WriteLine(Environment.NewLine + $"Your age is: {age}");
        }
    }
}
