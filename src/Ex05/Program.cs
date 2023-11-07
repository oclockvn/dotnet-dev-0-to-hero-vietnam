namespace Ex05
{
    internal class Program
    {
        // Viết chương trình nhập vào năm sinh, in ra số tuổi
        static void Main(string[] args)
        {
            var birthYear = GetNumber("Enter your birth year: ");
            var age = DateTime.Now.Year - birthYear;
            Console.WriteLine($"You are {age} years old");
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }
    }
}
