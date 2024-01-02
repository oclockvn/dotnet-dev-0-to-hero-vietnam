namespace Adding4Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int v1, v2, v3, v4;

            //v1 = int.Parse(Console.ReadLine());
            //v2 = int.Parse(Console.ReadLine());
            //v3 = int.Parse(Console.ReadLine());
            //v4 = int.Parse(Console.ReadLine());

            //int sum = v1 + v2 + v3 + v4;

            //int sum = 0;

            //sum = sum + int.Parse(Console.ReadLine());
            //sum = sum + int.Parse(Console.ReadLine());

            //Console.WriteLine(sum);

            var n1 = GetNumber("Number 1: ");
            var n2 = GetNumber("Number 2: ");
            var n3 = GetNumber("Number 3: ");
            var n4 = GetNumber("Number 4: ");

            var result = n1 + n2 + n3 + n4;
            Console.WriteLine(result);
        }

        static int GetNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }
    }
}
