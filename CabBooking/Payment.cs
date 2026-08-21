interface IPayment
{
    void PayAmount(double amount);
}

class CashPayment : IPayment
{
    public void PayAmount(double amount)
    {
        Console.WriteLine($"{amount} paid in cash.");
    }
}

class UPI : IPayment
{
    public void PayAmount(double amount)
    {
        Console.WriteLine($"{amount} paid using UPI.");
    }
}