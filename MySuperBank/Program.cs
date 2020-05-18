using System;

namespace MySuperBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Nikhil");
            var account2 = new BankAccount("Suraj");
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance}.");
        }
    }
}
