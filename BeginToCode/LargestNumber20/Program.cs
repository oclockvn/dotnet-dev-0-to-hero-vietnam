using System.ComponentModel.DataAnnotations;

namespace LargestNumber20;

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            numbers[i] = GetNumber($"Please enter number {i + 1}: ");
        }

        Console.WriteLine($"The largest number is {GetLargestNumber(numbers)}");
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

    static int GetLargestNumber(int[] numbers)
    {
        var largest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        return largest;
    }
}
