namespace OOP_Ex08;

// Implement inheritance and polymorphism to design a class hierarchy for various types of employees, such as Manager, Engineer, Salesperson, and Intern.
// Define abstract methods for common employee tasks and implement them in subclasses with specific behaviors.

public class Program
{
    static void Main(string[] args)
    {
        var manager = new Manager()
        {
            Name = "John",
            Department = "IT",
            Team = "dotnet dev",
        };

        manager.CalculateSalary();
        manager.DisplayDetail();

        var engineer = new Engineer()
        {
            Name = "Louis",
            Department = "Engineering",
            Project = "Whatever",
        };

        engineer.CalculateSalary();
        engineer.DisplayDetail();


        var sales = new Salesperson()
        {
            Name = "Com",
            Department = "Sales",
            SalesTarget = 10,
        };

        sales.CalculateSalary();
        sales.DisplayDetail();

        var interm = new Interm()
        {
            Name = "Nhim",
            Department = "HR",
        };

        interm.CalculateSalary();
        interm.DisplayDetail();
    }
}

public abstract class Employee
{
    public string Name { get; set; } = null!;
    public string Department { get; set; } = null!;
    public double Salary { get; set; }

    public abstract void CalculateSalary();
    public abstract void DisplayDetail();
}

public class Manager : Employee
{
    public string Team { get; set; } = null!;

    public override void CalculateSalary()
    {
        Salary = 200 + 5*Team.Length;
    }

    public override void DisplayDetail()
    {
        Console.WriteLine("Manager Details: ");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Team's name: {Team}");
        Console.WriteLine();

    }
}

public class Engineer : Employee
{
    public string Project { get; set; } = null!;

    public override void CalculateSalary()
    {
        Salary = 40 + 3*Project.Length;
    }

    public override void DisplayDetail()
    {
        Console.WriteLine("Engineer Details: ");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Project's name: {Project}");
        Console.WriteLine();
    }
}

public class Salesperson : Employee
{
    public int SalesTarget { get; set; }

    public override void CalculateSalary()
    {
        Salary = 20 + 2*SalesTarget;
    }

    public override void DisplayDetail()
    {
        Console.WriteLine("Engineer Details: ");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Sale's target: {SalesTarget}");
        Console.WriteLine();

    }
}

public class Interm : Employee
{
    public override void CalculateSalary()
    {
        Salary = 3;
    }

    public override void DisplayDetail()
    {
        Console.WriteLine("Engineer Details: ");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {Salary}");
    }
}
