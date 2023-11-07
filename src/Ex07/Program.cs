namespace Ex07
{
    internal class Program
    {
        /*
            Viết chương trình nhập vào 1 số từ 2 tới 8, xuất ra "Monday" nếu số nhập vào là 2, "Tuesday" nếu số 3, ...
            Lặp lại cho tới khi nhập đúng số từ 2 tới 8 (ví dụ nếu người dùng nhập 0 thì báo nhập lại)
            Sử dụng if else để xuất kết quả
         * */
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
                Console.WriteLine("Wednesdays");
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
                Console.WriteLine("Saturdays");
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
