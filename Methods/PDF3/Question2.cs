using System;

public class Question2
{
    public static void Run()
    {
        Console.WriteLine("Question 2: Number checker utilities");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digitCount = Program.CountDigits(number);
        int[] digits = Program.StoreDigits(number);
        bool isDuck = Program.IsDuckNumber(number, digits);
        bool isArmstrong = Program.IsArmstrongNumber(number, digits);
        int largest = Program.FindLargest(digits);
        int secondLargest = Program.FindSecondLargest(digits);
        int smallest = Program.FindSmallest(digits);
        int secondSmallest = Program.FindSecondSmallest(digits);

        Console.WriteLine($"Digit count: {digitCount}");
        Console.WriteLine($"Digits: {string.Join(", ", digits)}");
        Console.WriteLine($"Duck number: {isDuck}");
        Console.WriteLine($"Armstrong number: {isArmstrong}");
        Console.WriteLine($"Largest: {largest}, Second largest: {secondLargest}");
        Console.WriteLine($"Smallest: {smallest}, Second smallest: {secondSmallest}");
    }
}
