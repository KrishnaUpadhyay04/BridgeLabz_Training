using System;

class BankAccount
{
    public string AccountNumber;
    protected string AccountHolder;
    private double Balance;

    public BankAccount(string number, string holder, double balance)
    {
        AccountNumber = number;
        AccountHolder = holder;
        Balance = balance;
    }

    public double GetBalance() {return Balance;}

    private void SetBalance(double Balance)
    {
        this.Balance = Balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string number, string holder, double balance) : base(number, holder, balance){}

    public void DisplayAccountNumber() {Console.WriteLine($"Account Number: {AccountNumber}");}

    public void DisplayAccountHolder() {Console.WriteLine($"Account Holder: {AccountHolder}");}
}