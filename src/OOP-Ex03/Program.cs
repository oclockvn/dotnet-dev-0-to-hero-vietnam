namespace OOP_Ex03;

public class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(4);
        var c = circle.CalculateArea();
        Console.WriteLine($"The area of the circle is {c}");

        var rectangle = new Rectangle(4, 3);
        var r = rectangle.CalculateArea();
        Console.WriteLine($"The area of the reactangle is {r}");

        var triangle = new Triangle(8,6);
        var t = triangle.CalculateArea();
        Console.WriteLine($"The area of the triangle is {t}");
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius) { this.radius = radius; }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double _length, double _width)
    {
        length = _length;
        width = _width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }
}

public class Triangle : Shape
{
    private double baseWidth;
    private double height;

    public Triangle(double _base, double _height) 
    { 
        baseWidth = _base;
        height = _height;
    }

    public override double CalculateArea()
    {
        return ((1.0 / 2.0) * baseWidth * height);
    }
}
