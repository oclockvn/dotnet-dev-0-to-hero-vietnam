namespace Ex07
{
    public class Program
    {
        static void Main(string[] args)
        {
            var weekday = GetWeekDay();

            if (weekday == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (weekday == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (weekday == 7)
            {
                Console.WriteLine("Sarturday");
            }
            else
            {
                Console.WriteLine("Sunday");
            }

        }

        static int GetWeekDay()
        {
            while (true)
            {
                Console.Write("Please enter a number 2=>8: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number >= 2 && number <= 8)
                    {
                        return number;
                    }
                }

            }
        }
    }
}

