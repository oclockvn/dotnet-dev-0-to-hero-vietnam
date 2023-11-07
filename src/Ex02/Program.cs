namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter a number and output the 2 exponent of it
            // x^2 = Math.Pow(x, 2)

            // version 1: no input validation
            Console.Write("Enter a number: ");
            var num = int.Parse(Console.ReadLine()!); // this could throw exception if use enter not a number
            var result = Math.Pow(num, 2);
            Console.WriteLine($"{num}^2 = {result}");

            // version 2: validate user's input
            bool valid = false;
            var num2 = 0;

            while (!valid)
            {
                Console.Write("Enter another number: ");
                valid = int.TryParse(Console.ReadLine(), out num2); // use int.TryParse to convert string to number, skip if string is not a number
            }

            Console.WriteLine($"{num2}^2 = {Math.Pow(num2, 2)}");
        }
    }
}
