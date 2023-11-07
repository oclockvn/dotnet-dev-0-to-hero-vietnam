namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write program to print hello name from user's input
            Console.Write("Enter your name: ");  // print to console, use Console.Write to enter the value in the same line
            var name = Console.ReadLine();       // read from console and assign to a variable
            Console.WriteLine($"Hello, {name}"); // using string interpolation and print to console
        }
    }
}
