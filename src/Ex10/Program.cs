using System.Security.Claims;

namespace Ex10
{
    public class Program
    {
        static void Main(string[] args)
        {
            var invalid = false;
            var num = 0;

            while (!invalid)
            {
                Console.Write("Please enter a number: ");
                invalid = int.TryParse(Console.ReadLine(), out num);
            }

            var sum = 0;
            string s = "";
            for (int i = 1; i <= num; i++)
            {
                sum += i;
                if (i != num)
                {
                s += $"{i} + ";
                }
                else
                {
                    s += $"{i}";
                }
            }

            Console.WriteLine($"{s} = {sum}");
        }
    }
}
