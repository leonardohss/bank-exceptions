using System;
using System.Globalization;
using BankExceptions.Entities;
using BankExceptions.Entities.Exceptions;

namespace BankExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            


            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double wlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, wlimit);
                Console.WriteLine("Account: " + account);

                Console.Write("Enter amount for withdraw: ");
                double wamount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(wamount);

                Console.WriteLine("Account: " + account);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            
        }
    }
}
