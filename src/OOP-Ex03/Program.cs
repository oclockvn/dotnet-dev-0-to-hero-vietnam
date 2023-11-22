namespace OOP_Ex03;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius) { }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width) { }

    public override double CalculateArea()
    {
        return length * width;
    }
}

public class Triangle : Shape
{
    private double _base;
    private double height;

    public Triangle(double _base, double height) { }

    public override double CalculateArea()
    {
        throw new NotImplementedException();
    }
}
