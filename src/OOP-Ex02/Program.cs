namespace OOP_Ex02;

public class Program
{
    static void Main(string[] args)
    {
        BankAccount ba = new BankAccount();
        ba.Depositing(200);
        ba.Depositing(120);

        ba.Withdrawing(20);
        ba.CheckBalance();

        var ba2 = new BankAccount();
        ba2.Depositing(100);
    }
}

public class BankAccount
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public string AccountHolderName { get; set; } = null!;

    public void Depositing(decimal num)
    {
        Balance += num;
    }

    public void Withdrawing(decimal num)
    {
        Balance -= num;
    }

    public void CheckBalance()
    {
        Console.WriteLine($"{Balance}");
    }
}
