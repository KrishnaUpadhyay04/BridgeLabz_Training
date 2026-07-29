using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

class Question1
{
    static Random random = new Random();

    public static void Solution()
    {
        Console.WriteLine("Think of a number between 1 and 100.");

        int low = 1, high = 100;
        int guess;

        while(true)
        {
            guess = GenerateGuess(low, high);

            Console.WriteLine($"\nIs your number {guess}?");
            Console.Write("Enter (H = High, L = Low, C = Correct)");

            char feedback = GetFeedBack();

            if(feedback == 'C')
            {
                Console.WriteLine($"Yay! I gussed your number: {guess}");
                break;
            }

            DetermineNextGuess(feedback, guess, ref low, ref high);
        }
    }

    static int GenerateGuess(int low, int high)
    {
        return random.Next(low, high + 1);
    }

    static char GetFeedback()
    {
        while(true)
        {
            char feedback = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if(feedback == 'H' || feedback == 'L' || feedback == 'C') return feedback;

            Console.Write("Invalid input! Enter H, L or C: ");
        }
    }

    static void DetermineNextGuess(char feedback, int guess, ref int low, ref int high)
    {
        if(feedback == 'H') high = guess - 1;
        else if(feedback == 'L') low = guess + 1;

        if(low > high)
        {
            Console.WriteLine("The answers are inconsistent. Please restart the game.");
            Environment.Exit(0);
        }
    }
}