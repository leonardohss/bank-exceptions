using System;
using BankExceptions.Entities;

namespace BankExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "Peter", 300.00);

            account.Deposit(400.00);

            Console.WriteLine(account);
        }
    }
}
