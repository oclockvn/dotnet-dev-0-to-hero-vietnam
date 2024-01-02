namespace BeginToCode;

public class Sum
{
    static void Main()
    {
        Console.WriteLine("This program adds two number together.");
        //Console.Write("First number: ");
        //string number1Text = Console.ReadLine();
        //int number1 = int.Parse(number1Text);
        var number1 = GetNumber("First number: ");

        //Console.Write("Second number: ");
        //string number2Text = Console.ReadLine();
        //int number2 = int.Parse(number2Text);
        var number2 = GetNumber("Second number: ");

        int result = number1 + number2;
        Console.WriteLine("Sum is " + result);
    }

    public static int GetNumber(string message)
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
