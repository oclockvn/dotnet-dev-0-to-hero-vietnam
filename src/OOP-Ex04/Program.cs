namespace OOP_Ex04;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class Employee
{
    public string Name { get; set; } = null!;
    public string Department { get; set; } = null!;
    public double Salary { get; set; }
}

public class Manager : Employee
{
    
}

public class Engineer : Employee
{

}

public class Salesperson : Employee
{

}
