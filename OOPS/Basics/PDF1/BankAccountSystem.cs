using System;

class BankAccount
{
    public static string BankName = "Chitkara University Bank";
    public static int TotalAccounts = 0;
    private readonly string AccountNumber;
    internal string AccountHolderName;

    public BankAccount(string AccountNumber, string AccountHolderName)
    {
        this.AccountNumber = AccountNumber;
        this.AccountHolderName = AccountHolderName;
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine($"Total Accounts: {TotalAccounts}");
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder Name: {AccountHolderName}");
    }
}