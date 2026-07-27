using System;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Level 2 Practice Programs");
            Console.WriteLine("1. Factors of a number");
            Console.WriteLine("2. Sum of natural numbers recursively");
            Console.WriteLine("3. Leap year");
            Console.WriteLine("4. Unit converter - distance");
            Console.WriteLine("5. Unit converter - length");
            Console.WriteLine("6. Unit converter - temperature/weight/volume");
            Console.WriteLine("7. Student voting eligibility");
            Console.WriteLine("8. Youngest and tallest friend");
            Console.WriteLine("9. Positive/negative and even/odd analysis");
            Console.WriteLine("10. BMI calculator");
            Console.WriteLine("11. Quadratic equation roots");
            Console.WriteLine("12. Random 4-digit numbers");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Question1.Run(); break;
                case "2": Question2.Run(); break;
                case "3": Question3.Run(); break;
                case "4": Question4.Run(); break;
                case "5": Question5.Run(); break;
                case "6": Question6.Run(); break;
                case "7": Question7.Run(); break;
                case "8": Question8.Run(); break;
                case "9": Question9.Run(); break;
                case "10": Question10.Run(); break;
                case "11": Question11.Run(); break;
                case "12": Question12.Run(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option"); break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    public static double FindSumOfSquaresOfFactors(int[] factors)
    {
        double sum = 0;
        foreach (int factor in factors)
        {
            sum += Math.Pow(factor, 2);
        }
        return sum;
    }

    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    public static int SumNaturalNumbersRecursive(int n)
    {
        if (n <= 0) return 0;
        return n + SumNaturalNumbersRecursive(n - 1);
    }

    public static int SumNaturalNumbersFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    public static bool IsLeapYear(int year)
    {
        if (year < 1582) return false;
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }

    public static double ConvertKmToMiles(double km) => km * 0.621371;
    public static double ConvertMilesToKilometers(double miles) => miles * 1.60934;
    public static double ConvertMetersToFeet(double meters) => meters * 3.28084;
    public static double ConvertFeetToMeters(double feet) => feet * 0.3048;

    public static double ConvertYardsToFeet(double yards) => yards * 3;
    public static double ConvertFeetToYards(double feet) => feet * 0.333333;
    public static double ConvertMetersToInches(double meters) => meters * 39.3701;
    public static double ConvertInchesToMeters(double inches) => inches * 0.0254;
    public static double ConvertInchesToCentimeters(double inches) => inches * 2.54;

    public static double ConvertFahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
    public static double ConvertCelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;
    public static double ConvertPoundsToKilograms(double pounds) => pounds * 0.453592;
    public static double ConvertKilogramsToPounds(double kilograms) => kilograms * 2.20462;
    public static double ConvertGallonsToLiters(double gallons) => gallons * 3.78541;
    public static double ConvertLitersToGallons(double liters) => liters * 0.264172;

    public static int FindYoungestFriend(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }
        return youngestIndex;
    }

    public static int FindTallestFriend(double[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        return tallestIndex;
    }

    public static bool IsPositive(int number) => number > 0;
    public static bool IsEven(int number) => number % 2 == 0;
    public static int CompareNumbers(int first, int second)
    {
        if (first > second) return 1;
        if (first < second) return -1;
        return 0;
    }

    public static string[] CalculateBMIAndStatus(double[,] people)
    {
        string[] statuses = new string[people.GetLength(0)];
        for (int i = 0; i < people.GetLength(0); i++)
        {
            double weight = people[i, 0];
            double heightInMeters = people[i, 1] / 100;
            double bmi = weight / (heightInMeters * heightInMeters);
            people[i, 2] = bmi;

            if (bmi < 18.5) statuses[i] = "Underweight";
            else if (bmi < 25) statuses[i] = "Normal";
            else if (bmi < 30) statuses[i] = "Overweight";
            else statuses[i] = "Obese";
        }
        return statuses;
    }

    public static double[] FindQuadraticRoots(double a, double b, double c)
    {
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant < 0)
        {
            return Array.Empty<double>();
        }

        if (discriminant == 0)
        {
            return new[] { -b / (2 * a) };
        }

        double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return new[] { root1, root2 };
    }

    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000);
        }
        return numbers;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        double average = numbers.Average();
        int min = numbers.Min();
        int max = numbers.Max();
        return new[] { average, min, max };
    }
}
