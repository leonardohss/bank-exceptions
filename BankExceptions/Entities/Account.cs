using System;
using System.Collections.Generic;
using System.Text;

namespace BankExceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance =+ amount;
        }

        public void Withdraw(double amount)
        {
            Balance =- amount;
        }

        public override string ToString()
        {
            return "Account: "
                + Number
                + ", Holder: "
                + Holder
                + ", Balance: "
                + Balance.ToString("F2");
        }
    }
}
