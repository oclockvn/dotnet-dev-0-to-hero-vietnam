namespace Ex04
{
    internal class Program
    {
        // Viết chương trình nhập vào 1 ký tự bất kỳ, in ra "Bạn đã nhập số" nếu ký tự đó là số, "Bạn đã nhập chuỗi" nếu ký tự không phải là số
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            var isNumber = int.TryParse(Console.ReadLine(), out var _); // discard output as we don't need it
            if (isNumber)
            {
                Console.WriteLine("This is a number");
            }
            else
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
