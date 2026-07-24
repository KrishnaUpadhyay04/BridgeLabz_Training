using System;

class SumOfDigits
{
    public static void Solution()
    {
        Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int[] arr = new int[number.ToString().Length];

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = number % 10;
            sum += arr[i];
            number /= 10;
        }
        Console.WriteLine("Sum of digits: " + sum);
    }
}