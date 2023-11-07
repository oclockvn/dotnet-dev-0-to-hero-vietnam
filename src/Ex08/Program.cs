namespace Ex08
{
    public class Program
    {
        static void Main(string[] args)
        {
            var weekday = GetWeekDay();

            switch (weekday)
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
                    Console.WriteLine("Sarturday");
                    break;
                    case 8:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        static int GetWeekDay()
        {
            while (true)
            {
                Console.Write("Please enter number fom 2 to 8: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number >=2 && number<=8)
                    {
                        return number;
                    }
                }
            }
        }
    }
}
