using System;

public class Question8
{
    public static void Run()
    {
        Console.WriteLine("Question 8: Youngest and tallest friend");
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age for {names[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter height for {names[i]}: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngestIndex = Program.FindYoungestFriend(ages);
        int tallestIndex = Program.FindTallestFriend(heights);

        Console.WriteLine($"Youngest friend: {names[youngestIndex]} ({ages[youngestIndex]})");
        Console.WriteLine($"Tallest friend: {names[tallestIndex]} ({heights[tallestIndex]})");
    }
}
