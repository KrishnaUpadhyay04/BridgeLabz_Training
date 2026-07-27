using System;

class Question3
{
    public static void Solution()
    {
        Console.Write("Enter a number: ");
        long number = Convert.ToInt64(Console.ReadLine());

        int maxDigit = 10;
        int[] digits = new int[maxDigit];

        int index = 0;

        while (number != 0)
        {
            digits[index] = (int)(number % 10);
            number /= 10;
            index++;

            if (index == maxDigit)
                break;
        }

        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"Largest Digit : {largest}");
        Console.WriteLine($"Second Largest Digit : {secondLargest}");
    }
}