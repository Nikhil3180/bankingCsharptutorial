using System;

namespace MySuperBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Nikhil", 10000);
            var account2 = new BankAccount("Suraj", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance}.");
            account.MakeDeposit(9000, DateTime.Now, "PF amount deposit");
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            account.MakeWithdrawal(900, DateTime.Now, "ATM");
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Balance cannot be negative");
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
