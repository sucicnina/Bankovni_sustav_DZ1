using Bankovni_sustav_DZ1;
using System;

class Program
{
    public static void Main()
    {
        BankUser user1 = new BankUser(1999.85m, new DateTime(2015, 12, 20), "Nina", "Sucic", 1234);
        BankUser user2 = new BankUser(200.35m, new DateTime(2019, 2, 2), "Mia", "Sucic", 1678);

        user1.PutMoney(3000m);
        user2.WithdrawMoney(50.34m);

        Console.WriteLine($"User1 balance: {user1.GetBalance()}");
        Console.WriteLine($"User2 balance: {user2.GetBalance()}");

        List<BankUser> users = new List<BankUser>();
        users.Add(user1);
        users.Add(user2);

        Bank bank = new Bank(users);

        Transaction transaction1 = new MoneyDeposit(user2, 257.98m, new DateTime(2022, 12, 25));
        bank.ExecuteTransaction(transaction1);

        Transaction transaction2 = new MoneyWithdrawl(user1, 100m, new DateTime(2024, 11, 5));
        bank.ExecuteTransaction(transaction2);

        Console.WriteLine($"User1 balance after bank transaction: {user1.GetBalance()}");
        Console.WriteLine($"User2 balance after bank transaction: {user2.GetBalance()}");



    }
}
