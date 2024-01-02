namespace LargestNumber3;

internal class Program
{
    static void Main(string[] args)
    {
        var num1 = GetNumber("Please enter number 1: ");
        var num2 = GetNumber("Please enter number 2: ");
        var num3 = GetNumber("Please enter number 3: ");

        var largestNumber = GetLargestNumber(num1, num2, num3);
        Console.WriteLine($"The largest number is {largestNumber}");
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

    static int GetLargestNumber(int n1, int n2, int n3)
    {
        if ((n1>n2) && (n1>n3))
        {
            return n1;
        }
        else if ((n1 < n2) && (n2 > n3))
        {
            return n2;
        }
        else
        {
            return n3;
        }
    }
}
