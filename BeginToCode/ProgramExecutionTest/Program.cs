using System.Runtime.ExceptionServices;

namespace ProgramExecutionTest
{
    public class Program
    {
        static void Main()
        {
            int result;

            AddNumber(2,3, out result);

            Console.WriteLine($"Sum: {result}");
        }

        static void AddNumber(int a, int b, out int sum)
        {
            sum = a + b;
        }
    }
}
