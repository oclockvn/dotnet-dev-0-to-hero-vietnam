using System.Drawing;
using System.Runtime.Serialization;

namespace OOP_Ex09;

//Design a class hierarchy for different types of shapes, such as Circle, Rectangle, Triangle, and Square.
//Implement methods for calculating the area and perimeter of each shape.
//Utilize abstract classes and interfaces to manage common properties and behaviors.

public class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle(3);

        Console.WriteLine($"The area of the circle is :{circle.CalcArea()}");
        Console.WriteLine($"The perimeter of the circle is :{circle.CalcPerimeter()}");
        Console.WriteLine();

        IShape rect = new Rectangle(3, 4);
        Console.WriteLine($"The area of the rectangle is :{rect.CalcArea()}");
        Console.WriteLine($"The perimeter of the rectangle is :{rect.CalcPerimeter()}");
        Console.WriteLine();

        IShape square = new Square(4);
        Console.WriteLine($"The area of the square is :{square.CalcArea()}");
        Console.WriteLine($"The perimeter of the square is :{square.CalcPerimeter()}");
        Console.WriteLine();

        IShape triangle = new Triangle(3,4,5);
        Console.WriteLine($"The area of the triangle is :{triangle.CalcArea()}");
        Console.WriteLine($"The perimeter of the triangle is :{triangle.CalcPerimeter()}");
        Console.WriteLine();
    }
}

interface IShape
{
    double CalcArea();
    double CalcPerimeter();
}

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalcArea()
    {
        return Math.PI * radius* radius;
    }

    public double CalcPerimeter()
    {
       return 2 * Math.PI * radius;
    }
}

public class Rectangle : IShape
{
    private readonly double height;
    private readonly double width;

    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    public double CalcArea()
    {
        return height * width;
    }

    public double CalcPerimeter()
    {
        return 2*(width+height);
    }
}

public class Triangle : IShape
{
    private readonly double basewidth;
    private readonly double sidelengthright;
    private readonly double sidelengthleft;

    public Triangle(double basewidth, double sidelengthright, double sidelengthleft)
    {
        this.basewidth = basewidth;
        this.sidelengthright = sidelengthright;
        this.sidelengthleft = sidelengthleft;
    }

    public double CalcArea()
    {
        var s = (basewidth + sidelengthleft + sidelengthright) / 2;
        return Math.Sqrt(s*(s-basewidth)*(s-sidelengthleft)*(s-sidelengthright));
    }

    public double CalcPerimeter()
    {
        return (sidelengthleft + sidelengthright + basewidth);
    }
}

public class Square : IShape
{
    private readonly double sidelength;

    public Square(double sidelength)
    {
        this.sidelength = sidelength;
    }

    public double CalcArea()
    {
        return sidelength* sidelength;
    }

    public double CalcPerimeter()
    {
        return sidelength* 4;
    }
}
