namespace OOP_Ex14_Counter;

public class Program
{
    static void Main(string[] args)
    {
        DecreasingCounter counter = new DecreasingCounter(20);
        counter.PrintValue();

        counter.ResetValue();
        counter.PrintValue();
    }
}

public class DecreasingCounter
{
    private int value;

    public DecreasingCounter(int initialValue)
    {
        this.value = initialValue;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value: " + this.value);
    }

    public void Decrement()
    {
        if (value > 0)
        {
            value--;
        }
    }

    public void ResetValue()
    {
        value = 0;
    }
}
