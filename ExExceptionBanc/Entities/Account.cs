using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExExceptionBanc.Entities.Exceptions;

namespace ExExceptionBanc.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Balance: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
