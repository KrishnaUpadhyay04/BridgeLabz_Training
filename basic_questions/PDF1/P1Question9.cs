using System;

class P1Question9
{
    public static void Solution()
    {
        Console.Write("Enter student fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = fee * discountPercent / 100;
        double discountedFee = fee - discount;

        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {discountedFee}");
    }
}
