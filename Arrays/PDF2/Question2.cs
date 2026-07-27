using System;

class Question2
{
    public static void Solution()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };

        int[] age = new int[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter details of {names[i]}");

            Console.Write("Age: ");
            age[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height: ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngest = 0;
        int tallest = 0;

        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngest])
                youngest = i;

            if (height[i] > height[tallest])
                tallest = i;
        }

        Console.WriteLine($"\nYoungest Friend : {names[youngest]} ({age[youngest]} years)");
        Console.WriteLine($"Tallest Friend  : {names[tallest]} ({height[tallest]} units)");
    }
}