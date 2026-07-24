using System;

class P1Question4
{
    public static void Solution()
    {
        int costPrice = 129;
        int sellingPrice = 191;

        int profit = sellingPrice - costPrice;
        double profitPercentage = (double)profit / costPrice * 100;

        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice + "\n" +
                          "The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage);
    }
}
