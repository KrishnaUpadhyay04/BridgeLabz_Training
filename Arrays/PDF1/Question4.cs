using System;

class Question4
{
    public static void Solution()
    {
        int[] arr = new int[10];

        Console.WriteLine("Enter the natural numbers: ");
        int idx = 0;
        int sum = 0;
        while(true)
        {
            if(idx == 10) break;
            arr[idx] = Convert.ToInt32(Console.ReadLine());
            if(arr[idx] < 1) {
                Console.WriteLine("Number must be natural");
                break;
            }
            sum += arr[idx];
            idx++;
        }
        Console.WriteLine("Numbers till now are: ");

        for(int i = 0; i < 10; i++)
        {
            if(arr[i] < 1) break;

            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("And their sum is: " + sum);
    }
}