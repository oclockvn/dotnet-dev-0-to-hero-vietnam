namespace Ex06
{
    internal class Program
    {
        // Viết chương trình nhập vào 1 ký tự bất kỳ, lặp lại đến khi nào người dùng nhập vào 1 số bằng 2 cách:
        static void Main(string[] args)
        {
            // we've already know how to do it
            var valid = false;
            var num = 0;
            while (!valid)
            {
                Console.Write("Enter a number: ");
                valid = int.TryParse(Console.ReadLine(), out num );
            }

            Console.WriteLine($"Your number is: {num}");
        }
    }
}
