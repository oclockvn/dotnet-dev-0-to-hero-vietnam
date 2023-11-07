namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var day = GetWeekDay();
            switch (day)
            {
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        static int GetWeekDay()
        {
            while (true)
            {
                Console.Write("Enter a number (2->8): ");
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    if (2 <= num && num <= 8)
                    {
                        return num;
                    }
                }
            }
        }
    }
}
