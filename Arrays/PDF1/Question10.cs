using System;

class Question10
{
    public static void Solution()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string[] arr = new string[number + 1];

        for(int i = 0; i <= number; i++)
        {
            if(i % 3 == 0 && i % 5 == 0) arr[i] = "FizzBuzz";

            else if(i % 3 == 0) arr[i] = "Fizz";

            else if(i % 5 == 0) arr[i] = "Buzz";

            else arr[i] = i.ToString();
        }

        foreach(string ch in arr) Console.Write(ch + " ");
    }
}