using System;

class P1Question6
{
    public static void Solution()
    {
        double fee = 125000;
        double discountPercent = 10;

        double discount = fee * discountPercent / 100;
        double discountedFee = fee - discount;

        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFee}");
    }
}
