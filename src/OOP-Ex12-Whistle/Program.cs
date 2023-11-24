namespace OOP_Ex12_Whistle;

public class Program
{
    static void Main(string[] args)
    {
        var whistle = new Whistle("beef");

        whistle.Sound();
    }
}

public class Whistle
{
    private readonly string whistleSound;

    public Whistle(string whistleSound)
    {
        this.whistleSound = whistleSound;
    }

    public void Sound()
    {
        Console.WriteLine(whistleSound);
    }
}
