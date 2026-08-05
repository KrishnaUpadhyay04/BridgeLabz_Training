using System;
using System.Collections.Generic;

namespace BankingSystem
{
    interface ILoanable
    {
        bool ApplyForLoan(double LoanAmount);

        double LoanEligibility();
    }

    abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolderName { get; private set; }
        protected double Balance { get; private set; }

        private static List<BankAccount> accounts = new();

        public BankAccount()
        {
            AccountNumber = "";
            AccountHolderName = "";
            Balance = 0.0;
            accounts.Add(this);
        }

        public BankAccount(string AccountNumber, string AccountHolderName, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
            accounts.Add(this);
        }

        public void Withdraw(double Amount)
        {
            if (Amount > Balance)
            {
                Console.WriteLine("Insufficient Balance!");
                return;
            }
            Balance -= Amount;
            Console.WriteLine($"${Amount} debited from Account Number: {AccountNumber}");
        }

        public void Deposit(double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Invalid Amount!");
                return;
            }
            Balance += Amount;
            Console.WriteLine($"${Amount} credited to Account Number: {AccountNumber}");
        }

        public abstract double CalculateInterest();
        public new abstract string GetType();

        public void DisplayAccountDetails()
        {
            foreach (BankAccount bankAccount in accounts)
            {
                Console.WriteLine($"Account Number        : {bankAccount.AccountNumber}");
                Console.WriteLine($"Account Holder's Name : {bankAccount.AccountHolderName}");
                Console.WriteLine($"Balance               : ${bankAccount.Balance}");
                Console.WriteLine($"Account Type          : {bankAccount.GetType()}");
                Console.WriteLine($"Total Interest        : {bankAccount.CalculateInterest()}");
                if (bankAccount is ILoanable loanable)
                {
                    Console.Write("Enter Loan Amount: ");
                    if (double.TryParse(Console.ReadLine(), out double LoanAmount))
                    {
                        if (loanable.ApplyForLoan(LoanAmount)) Console.WriteLine("Eligible for Loan");
                        else Console.WriteLine("Not Eligible for Loan");
                        Console.WriteLine($"Eligible for Loan of upto: ${loanable.LoanEligibility()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid loan input.");
                    }
                }
            }
        }
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        private static string Type = "Savings Account";
        private static double InterestRate = 0.19;

        public SavingsAccount() : base() { }

        public SavingsAccount(string AccountNumber, string AccountHolderName, double Balance) : base(AccountNumber, AccountHolderName, Balance) { }

        public override double CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public override string GetType()
        {
            return Type;
        }

        public double LoanEligibility()
        {
            return 5 * Balance;
        }

        public bool ApplyForLoan(double LoanAmount)
        {
            return LoanAmount <= LoanEligibility();
        }
    }

    class CurrentAccount : BankAccount, ILoanable
    {
        private static string Type = "Current Account";
        private static double InterestRate = 0.25;

        public CurrentAccount() : base() { }

        public CurrentAccount(string AccountNumber, string AccountHolderName, double Balance) : base(AccountNumber, AccountHolderName, Balance) { }

        public override double CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public override string GetType()
        {
            return Type;
        }

        public double LoanEligibility()
        {
            return 4 * Balance;
        }

        public bool ApplyForLoan(double LoanAmount)
        {
            return LoanAmount <= LoanEligibility();
        }
    }
}
