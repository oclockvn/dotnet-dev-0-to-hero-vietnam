namespace OOP_Ex15_Dept;

public class Program
{
    static void Main(string[] args)
    {
        Dept dept = new Dept(120000, 1.01);
        dept.PrintBalance();

        dept.WaitOneYear();
        dept.PrintBalance();

        var years = 0;
        while (years < 20)
        {
            dept.WaitOneYear();
            years++;
        }

        dept.PrintBalance();
    }
}

public class Dept
{
    private double balance;
    private double interestRate;

    public Dept(double initialBalance, double initialInterestRate)
    {
        this.balance = initialBalance;
        this.interestRate = initialInterestRate;
    }

    public void PrintBalance()
    {
        Console.WriteLine(balance);
    }

    public void WaitOneYear()
    {
        balance = balance * interestRate;
    }
}
