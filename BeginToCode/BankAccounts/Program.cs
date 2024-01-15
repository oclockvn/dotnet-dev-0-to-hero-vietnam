namespace BankAccounts
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("John Doe", "123 Main St", 1000, 500);

            Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
            Console.WriteLine($"Address: {myAccount.Address}");
            Console.WriteLine($"Balance: {myAccount.Balance}");

            myAccount.PayIn(500);
            myAccount.DrawOut(200);
            myAccount.ChangeNameAndAddress("Jane Doe", "456 Oak St");
            myAccount.ChangeOverdraftLimit(1000);

            Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
            Console.WriteLine($"Address: {myAccount.Address}");
            Console.WriteLine($"Balance: {myAccount.Balance}");
        }

        class BankAccount
        {
            public string AccountHolderName { get; private set; }
            public string Address { get; private set; }
            public decimal Balance { get; private set; }
            public decimal OverdraftLimit { get; private set; }

            public BankAccount(string name, string addr, decimal initialBalance, decimal overdraft)
            {
                AccountHolderName = name;
                Address = addr;
                Balance = initialBalance;
                OverdraftLimit = overdraft;
            }

            public void PayIn(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"{AccountHolderName}'s account credited with {amount}. Current balance: {Balance}");
            }

            public void DrawOut(decimal amount)
            {
                if (Balance - amount >= -OverdraftLimit)
                {
                    Balance -= amount;
                    Console.WriteLine($"{AccountHolderName}'s account debited with {amount}. Current balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds!");
                }
            }

            public void ChangeNameAndAddress(string newName, string newAddress)
            {
                AccountHolderName = newName;
                Address = newAddress;
                Console.WriteLine("Account details updated successfully.");
            }

            public void ChangeOverdraftLimit(decimal newOverdraftLimit)
            {
                OverdraftLimit = newOverdraftLimit;
                Console.WriteLine("Overdraft limit updated successfully.");
            }
        }

    }
}
