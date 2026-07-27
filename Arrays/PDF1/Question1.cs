using System;

class Question1
{
    public static void Solution()
    {
        int[] ages = new int[10];

        Console.WriteLine("Enter the ages of the 10 students: ");

        for(int i = 0; i < 10; i++)
        {
            ages[i] = Convert.ToInt32(Console.ReadLine());
            if(ages[i] < 0)
            {
                Console.WriteLine("Invalid age");
                i--;
                continue;
            }

        }

        for(int i = 0; i < 10; i++)
        {
            if(ages[i] >= 18) Console.WriteLine($"The student with the age {ages[i]} can vote");
            else Console.WriteLine($"The student with the age {ages[i]} cannot vote");
        }

    }
}