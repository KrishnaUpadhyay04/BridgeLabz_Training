using System;

public class Question5
{
    public static void Run()
    {
        Console.WriteLine("Question 5: Positive, Negative or Zero");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = Program.CheckSign(number);
        if (result == 1)
        {
            Console.WriteLine("The number is positive");
        }
        else if (result == -1)
        {
            Console.WriteLine("The number is negative");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }
    }
}
