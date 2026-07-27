using System;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Level 1 Practice Programs");
            Console.WriteLine("1. Simple Interest");
            Console.WriteLine("2. Handshakes");
            Console.WriteLine("3. Handshakes (alternate)");
            Console.WriteLine("4. Rounds for 5 km run");
            Console.WriteLine("5. Positive, Negative or Zero");
            Console.WriteLine("6. Spring Season");
            Console.WriteLine("7. Sum of Natural Numbers");
            Console.WriteLine("8. Smallest and Largest of Three Numbers");
            Console.WriteLine("9. Quotient and Remainder");
            Console.WriteLine("10. Chocolates Distribution");
            Console.WriteLine("11. Wind Chill Temperature");
            Console.WriteLine("12. Trigonometric Functions");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Question1.Run();
                    break;
                case "2":
                    Question2.Run();
                    break;
                case "3":
                    Question3.Run();
                    break;
                case "4":
                    Question4.Run();
                    break;
                case "5":
                    Question5.Run();
                    break;
                case "6":
                    Question6.Run();
                    break;
                case "7":
                    Question7.Run();
                    break;
                case "8":
                    Question8.Run();
                    break;
                case "9":
                    Question9.Run();
                    break;
                case "10":
                    Question10.Run();
                    break;
                case "11":
                    Question11.Run();
                    break;
                case "12":
                    Question12.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    public static int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }

    public static int CalculateRoundsFor5Km(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        return (int)Math.Ceiling(5000 / perimeter);
    }

    public static int CheckSign(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }

    public static bool IsSpringSeason(int month, int day)
    {
        if (month < 3 || month > 6) return false;
        if (month == 3) return day >= 20;
        if (month == 6) return day <= 20;
        return true;
    }

    public static int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));
        return new[] { smallest, largest };
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new[] { quotient, remainder };
    }

    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + (0.6215 * temperature) + (((0.4275 * temperature) - 35.75) * Math.Pow(windSpeed, 0.16));
    }

    public static double[] CalculateTrigonometricFunctions(double angleInDegrees)
    {
        double angleInRadians = angleInDegrees * Math.PI / 180;
        return new[]
        {
            Math.Sin(angleInRadians),
            Math.Cos(angleInRadians),
            Math.Tan(angleInRadians)
        };
    }
}
