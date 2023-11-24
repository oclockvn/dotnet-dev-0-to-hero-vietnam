namespace OOP_Ex11_Classroom;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Classroom
{
    private string code;
    private int seat;

    public Classroom(string classCode, int numberOfSeat) : this(numberOfSeat)
    {
        code = classCode;
    }

    public Classroom(int numberOfSeat)
    {
        seat = numberOfSeat;
    }
}
