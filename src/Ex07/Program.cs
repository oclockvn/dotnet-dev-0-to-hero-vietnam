namespace Ex07
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isNumber = false;
            while(!isNumber)
            {
                Console.Write("Please enter number: ");
                isNumber = int.TryParse(Console.ReadLine(), out int number);

                if (number < 2 || number > 8)
                {
                    Console.WriteLine("Invalid number");
                }
                else if(number == 2)
                {
                    Console.WriteLine("Today is Monday");
                }
                else if (number == 3)
                {
                    Console.WriteLine("Today is Tuesday");
                }
                else if (number == 4)
                {
                    Console.WriteLine("Today is Wednesday");
                }
                else if (number == 5)
                {
                    Console.WriteLine("Today is Thursday");
                }
                else if (number == 6)
                {
                    Console.WriteLine("Today is Friday");
                }
                else if (number == 7)
                {
                    Console.WriteLine("Today is Sarturday");
                }
                else if (number == 8)
                {
                    Console.WriteLine("Today is Sunday");
                }
            }
        }
    }
}
