namespace LargestNumber;

public class Program
{
    static void Main(string[] args)
    {
        var num1 = GetNumber("Please enter first number: ");
        var num2 = GetNumber("Please enter second number: ");

        if (num1 >= num2)
        {
            Console.WriteLine($"The largest number is {num1}");
        }
        else
        {
            Console.WriteLine($"The largest number is {num2}");
        }
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
