using System;

class Question7
{
    public static void Solution()
    {
        Console.Write("Enter number of persons: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double[,] personData = new double[number, 3];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}");

            Console.Write("Enter Weight (kg): ");
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height (m): ");
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());

            if (personData[i, 0] <= 0 || personData[i, 1] <= 0)
            {
                Console.WriteLine("Invalid Input! Enter Again.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < number; i++)
        {
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

            if (personData[i, 2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i, 2] < 25)
                weightStatus[i] = "Normal";
            else if (personData[i, 2] < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"{personData[i,0]}\t{personData[i,1]}\t{personData[i,2]:F2}\t{weightStatus[i]}");
        }
    }
}