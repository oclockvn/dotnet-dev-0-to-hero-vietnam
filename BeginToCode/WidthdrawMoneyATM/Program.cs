using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WidthdrawMoneyATM;

public class Program
{
    static void Main(string[] args)
    {
        ATM atm = new ATM();

        Console.Write("Please enter your account number: ");
        string enteredAccountNumber = Console.ReadLine();

        if (atm.IsAccountValid(enteredAccountNumber))
        {
            Console.WriteLine("Please enter amount to widthdraw: ");

            if (decimal.TryParse(Console.ReadLine(), out var widthdrawalAmount))
            {
                if (atm.Widthdraw(enteredAccountNumber, widthdrawalAmount, out decimal newBalance))
                {
                    Console.WriteLine($"Withdrawal successful! New balance: {newBalance}");
                }
            }
            else
            {
                atm.DisplayError("Invalid withdrawal amount format");
            }
        }
        else
        {
            atm.DisplayError("Invalid account number");
        }
    }

    public struct BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Error { get; set; }
    }

    public class ATM
    {
        private List<BankAccount> accounts = new List<BankAccount>()
            {
                new BankAccount {AccountNumber = "123456", Balance = 100},
                new BankAccount {AccountNumber = "654321", Balance = 150}
            };

        public bool IsAccountValid(string enteredAccountNumber)
        {
            return accounts.Exists(account => account.AccountNumber == enteredAccountNumber);
        }

        public bool Widthdraw(string enteredAccountNumber, decimal widthdrawalAmount, out decimal newBalance)
        {
            BankAccount account = accounts.Find(account => account.AccountNumber == enteredAccountNumber);

            if ((widthdrawalAmount > 0) && (widthdrawalAmount <= account.Balance))
            {
                account.Balance -= widthdrawalAmount;
                newBalance = account.Balance;
                return true;
            }
            else
            {
                newBalance = 0;
                DisplayError("Invalid widthdrawal amount or insufficient funds");
                return false;
            }
        }

        public string DisplayError(string errorMessage)
        {
            BankAccount userAccount = new BankAccount() 
            { 
                Error = errorMessage
            };

            return $"Error: {userAccount.Error}";
        }
    }
}
