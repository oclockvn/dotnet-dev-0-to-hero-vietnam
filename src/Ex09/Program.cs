namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var day = GetWeekDay();
            var text = day switch
            {
                2 => "Monday",
                3 => "Tuesday",
                4 => "Wednesday",
                5 => "Thursday",
                6 => "Friday",
                7 => "Saturday",
                _ => "Sunday"
            };

            Console.WriteLine(text);
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
