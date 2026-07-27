using System;

class Question6
{
    public static void Solution()
    {
        double[] heights = new double[11];
        double sum = 0.0;
        Console.WriteLine("Enter the heights of players(in cm.): ");
        for(int i = 0; i < 11; i++)
        {
            heights[i] = Convert.ToDouble(Console.ReadLine());
            sum += heights[i];
        }

        Console.WriteLine($"Mean height of the team is {sum / 11.0}");
    }
}