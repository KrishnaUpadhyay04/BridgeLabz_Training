using System;

class Question10
{
    public static void Solution()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        int chocolatesEach = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine($"The number of chocolates each child gets is {chocolatesEach} and the number of remaining chocolates is {remainingChocolates}");
    }
}
