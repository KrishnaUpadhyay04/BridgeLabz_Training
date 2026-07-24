using System;

class Question2
{
    public static void Solution()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter your numbers:");

        for(int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if(arr[i] > 0) {
                Console.WriteLine("The Number is Positive and the number is " + (arr[i] % 2 == 0 ? "Even" : "Odd"));
            }
            else if(arr[i] < 0) Console.WriteLine("The Number is Negative");
            else Console.WriteLine("The Number is Zero");
        }

        if(arr[0] > arr[4]) Console.WriteLine("The first element is greater than the last element");
        else if(arr[0] < arr[4]) Console.WriteLine("The first element is less than the last element");
        else Console.WriteLine("The first and last elements are equal");
    }
}