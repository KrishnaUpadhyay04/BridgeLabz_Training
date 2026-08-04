namespace BankAccount;

class BankAccount
{
    public string AccountNumber { get; }

    public double Balance { get; protected set; }

    public BankAccount()
    {
        AccountNumber = "";
        Balance = 0.0;
    }

    public BankAccount(string AccountNumber, double Balance)
    {
        this.AccountNumber = AccountNumber;
        this.Balance = Balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Bank Account");
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance       : {Balance}");
    }
}

class SavingsAccount : BankAccount
{
    public double InterestRate { get; }

    public SavingsAccount() : base()
    {
        InterestRate = 0.0;
    }

    public SavingsAccount(string AccountNumber, double Balance, double InterestRate) : base(AccountNumber, Balance)
    {
        this.InterestRate = InterestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }
}

class CheckingAccount : BankAccount
{
     public double WithdrawalLimit { get; }

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Withdrawal Limit : ₹{WithdrawalLimit}");
    }
}

class FixedDepositAccount : BankAccount
{
    public int TenureInMonths { get; }

    public FixedDepositAccount(string accountNumber, double balance, int tenureInMonths)
        : base(accountNumber, balance)
    {
        TenureInMonths = tenureInMonths;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Tenure : {TenureInMonths} Months");
    }
}