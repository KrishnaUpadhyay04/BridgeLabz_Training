using System;

class Question6
{
    public static void Solution()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}");

            Console.Write("Enter Weight (kg): ");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height (m): ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            if (weight[i] <= 0 || height[i] <= 0)
            {
                Console.WriteLine("Invalid Input! Enter Again.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < n; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] < 25)
                status[i] = "Normal";
            else if (bmi[i] < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        Console.WriteLine("\nHeight\tWeight\tBMI\tStatus");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{height[i]}\t{weight[i]}\t{bmi[i]:F2}\t{status[i]}");
        }
    }
}