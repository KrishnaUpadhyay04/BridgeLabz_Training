using System;

class CanVote
{
    public static void Solution()
    {
        int[] ages = new int[10];
        Console.WriteLine("Enter the ages of 10 students: ");
        for(int i = 0; i < 10; i++)
        {
            ages[i] = Convert.ToInt32(Console.ReadLine());
            if(ages[i] < 0)
            {
                Console.WriteLine("Age cannot be negative. Enter a valid age.");
                i--;
            } else if(ages[i] > 120)
            {
                Console.WriteLine("Please enter a valid age.");
                i--;
            }
        }

        for(int i = 0; i < 10; i++)
        {
            string eligibility = ages[i] >= 18 ? "Can Vote" : "Cannot Vote";

            Console.WriteLine("Student " + (i + 1) + " of age: " + ages[i] + " " + eligibility);
        }
    }
}