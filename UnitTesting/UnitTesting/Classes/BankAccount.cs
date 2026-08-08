using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Classes
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
