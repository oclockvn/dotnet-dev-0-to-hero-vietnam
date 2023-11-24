using System.Threading.Channels;

namespace OOP_Ex07;

public class Program
{
    static void Main(string[] args)
    {
        ATM atm = new ATM();
        atm.CreateAccount("John", "deposit", 200);

        atm.AccountTransaction("Alice");
        atm.AccountTransaction("John");
    }
}

public class Account
{
    public string HolderName { get; set; } = null!;
    public string Type { get; private set; } = null!;
    public double Balance { get; private set; }

    public Account(string holderName, string type, double balance)
    {
        HolderName = holderName;
        Type = type;
        Balance = balance;
    }

    public Account(double balance)
    {
        Balance = balance;
    }

    public double Deposit(double amount)
    {
        Balance += amount;
        return Balance;
    }

    public double Withdraw(double amount)
    {
        Balance -= amount;
        return Balance;
    }

    public void CheckBalance()
    {
        Console.WriteLine($"The balance is {Balance}");
    }
}

public class ATM
{
    private List<Account> accounts = new List<Account>();
    
    public void CreateAccount(string holdername, string type, double balance)
    {
        Account newAcc = new Account(holdername, type, balance);
        accounts.Add(newAcc);
    }

    public void AccountTransaction(string holderName)
    {
        var acc = accounts.Where(x => x.HolderName.Equals(holderName)).FirstOrDefault();

        if (acc == null)
        {
            Console.WriteLine("Account doesn't exist.");
            return;
        }

        int option;
        do
        {
            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Check Balance");
            Console.WriteLine("0.Exit");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter deposit amount: ");
                    var depositAmount = double.Parse(Console.ReadLine());
                    acc.Deposit(depositAmount);
                    break;
                case 2:
                    Console.WriteLine("Enter withdraw amount: ");
                    var withdrawAmount = double.Parse(Console.ReadLine());
                    acc.Withdraw(withdrawAmount);
                    break;
                case 3:
                    acc.CheckBalance();
                    break;
            }

        } while (option != 0);
    }
}
