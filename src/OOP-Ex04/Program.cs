namespace OOP_Ex04;

public class Program
{
    static void Main(string[] args)
    {
        var A = new Manager();
        A.Salary = 1;
        Console.WriteLine($"{A.ManagerSalary()}");
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
    public double ManagerSalary()
    {
        return Salary * 3;
    }
}

public class Engineer : Employee
{
    public double EngineSalary()
    {
        return Salary * 2;
    }
}

public class Salesperson : Employee
{
    public double SalespersonSalary()
    {
        return Salary;
    }
}
