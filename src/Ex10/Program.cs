namespace Ex10
{
    internal class Program
    {
        // Viết chương trình nhập vào 1 số, tính tổng các số liên tiếp từ 0
        static void Main(string[] args)
        {
            var number = GetNumber();
            var sum = 0;
            var text = "";

            for (int i = 1; i <= number; i++)
            {
                sum += i;
                text += i < number ? $"{i} + " : $"{i}";
            }

            Console.WriteLine($"{text} = {sum}");
        }

        static int GetNumber()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }
            }
        }
    }
}
