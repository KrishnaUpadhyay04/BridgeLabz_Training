using System;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Level 4 Practice Programs");
            Console.WriteLine("1. Football team heights");
            Console.WriteLine("2. Number checker utilities");
            Console.WriteLine("3. Digit utilities");
            Console.WriteLine("4. Palindrome and duck number");
            Console.WriteLine("5. Number properties");
            Console.WriteLine("6. Factor and number classification");
            Console.WriteLine("7. OTP generation");
            Console.WriteLine("8. Calendar");
            Console.WriteLine("9. Line and distance between points");
            Console.WriteLine("10. Collinear points");
            Console.WriteLine("11. Employee bonus");
            Console.WriteLine("12. Student scorecard");
            Console.WriteLine("13. Matrix operations");
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
                case "13": Question13.Run(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option"); break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    public static int[] GenerateRandomHeights(int size)
    {
        Random random = new Random();
        int[] heights = new int[size];
        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(150, 251);
        }
        return heights;
    }

    public static int FindSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers) sum += number;
        return sum;
    }

    public static double FindMean(int[] numbers) => numbers.Length == 0 ? 0 : FindSum(numbers) / (double)numbers.Length;

    public static int FindShortest(int[] numbers)
    {
        int shortest = numbers[0];
        foreach (int number in numbers) if (number < shortest) shortest = number;
        return shortest;
    }

    public static int FindTallest(int[] numbers)
    {
        int tallest = numbers[0];
        foreach (int number in numbers) if (number > tallest) tallest = number;
        return tallest;
    }

    public static int CountDigits(int number)
    {
        int count = 0;
        int n = Math.Abs(number);
        do { count++; n /= 10; } while (n > 0);
        return count;
    }

    public static int[] StoreDigits(int number)
    {
        int n = Math.Abs(number);
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = n % 10;
            n /= 10;
        }
        return digits;
    }

    public static bool IsDuckNumber(int number, int[] digits)
    {
        if (number < 0) return false;
        for (int i = 1; i < digits.Length; i++) if (digits[i] != 0) return true;
        return false;
    }

    public static bool IsArmstrongNumber(int number, int[] digits)
    {
        int sum = 0;
        int power = digits.Length;
        foreach (int digit in digits) sum += (int)Math.Pow(digit, power);
        return sum == number;
    }

    public static int FindLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        foreach (int digit in digits) if (digit > largest) largest = digit;
        return largest;
    }

    public static int FindSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;
        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
        return secondLargest;
    }

    public static int FindSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        foreach (int digit in digits) if (digit < smallest) smallest = digit;
        return smallest;
    }

    public static int FindSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
        return secondSmallest;
    }

    public static int FindSumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits) sum += digit;
        return sum;
    }

    public static double FindSumOfSquaresOfDigits(int[] digits)
    {
        double sum = 0;
        foreach (int digit in digits) sum += Math.Pow(digit, 2);
        return sum;
    }

    public static bool IsHarshadNumber(int number, int[] digits) => number % FindSumOfDigits(digits) == 0;

    public static int[,] FindDigitFrequency(int number)
    {
        int[] digits = StoreDigits(number);
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < digits.Length; i++)
        {
            int digit = digits[i];
            frequency[digit, 1]++;
            frequency[digit, 0] = digit;
        }
        return frequency;
    }

    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++) reversed[i] = digits[digits.Length - 1 - i];
        return reversed;
    }

    public static bool AreArraysEqual(int[] first, int[] second)
    {
        if (first.Length != second.Length) return false;
        for (int i = 0; i < first.Length; i++) if (first[i] != second[i]) return false;
        return true;
    }

    public static bool IsPalindrome(int number, int[] digits) => AreArraysEqual(digits, ReverseDigits(digits));

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        for (int i = 2; i <= Math.Sqrt(number); i++) if (number % i == 0) return false;
        return true;
    }

    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sum = 0;
        foreach (int digit in StoreDigits(square)) sum += digit;
        return sum == number;
    }

    public static bool IsSpyNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = FindSumOfDigits(digits);
        int product = 1;
        foreach (int digit in digits) product *= digit;
        return sum == product;
    }

    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square % (int)Math.Pow(10, CountDigits(number)) == number;
    }

    public static bool IsBuzzNumber(int number) => number % 7 == 0 || number % 10 == 7;

    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++) if (number % i == 0) count++;
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++) if (number % i == 0) factors[index++] = i;
        return factors;
    }

    public static int FindGreatestFactor(int[] factors) => factors.Length > 0 ? factors[factors.Length - 1] : 0;
    public static int FindSumOfFactors(int[] factors) => FindSum(factors);
    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors) product *= factor;
        return product;
    }

    public static double FindProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors) product *= Math.Pow(factor, 3);
        return product;
    }

    public static bool IsPerfectNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = FindSumOfFactors(factors) - number;
        return sum == number;
    }

    public static bool IsAbundantNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = FindSumOfFactors(factors) - number;
        return sum > number;
    }

    public static bool IsDeficientNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = FindSumOfFactors(factors) - number;
        return sum < number;
    }

    public static bool IsStrongNumber(int number)
    {
        int sum = 0;
        foreach (int digit in StoreDigits(number)) sum += Factorial(digit);
        return sum == number;
    }

    public static int Factorial(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++) result *= i;
        return result;
    }

    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
            for (int j = i + 1; j < otps.Length; j++)
                if (otps[i] == otps[j]) return false;
        return true;
    }

    public static void DisplayCalendar(int month, int year)
    {
        string[] monthNames = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (IsLeapYear(year)) daysInMonth[2] = 29;

        Console.WriteLine($"{monthNames[month]} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int y0 = year - ((14 - month) / 12);
        int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;

        for (int i = 0; i < d0; i++) Console.Write("   ");
        for (int day = 1; day <= daysInMonth[month]; day++)
        {
            Console.Write(day.ToString().PadLeft(3));
            if ((day + d0) % 7 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

    public static double FindDistance(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double intercept = y1 - slope * x1;
        return new[] { slope, intercept };
    }

    public static bool AreCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    public static bool AreCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) < 1e-9;
    }

    public static double[,] CalculateBonus(double[,] employees)
    {
        double[,] result = new double[employees.GetLength(0), 2];
        for (int i = 0; i < employees.GetLength(0); i++)
        {
            double salary = employees[i, 0];
            double years = employees[i, 1];
            double bonus = years > 5 ? salary * 0.05 : salary * 0.02;
            result[i, 0] = salary + bonus;
            result[i, 1] = bonus;
        }
        return result;
    }

    public static double CalculateTotalOldSalary(double[,] employees) => FindSumOfRowColumn(employees, 0);
    public static double CalculateTotalNewSalary(double[,] employees) => FindSumOfRowColumn(employees, 0);
    public static double CalculateTotalBonus(double[,] employees) => FindSumOfRowColumn(employees, 1);

    private static double FindSumOfRowColumn(double[,] array, int column)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) sum += array[i, column];
        return sum;
    }

    public static double CalculatePercentage(double obtained, double total) => total == 0 ? 0 : (obtained / total) * 100;

    public static string CalculateGrade(double gradePoints)
    {
        if (gradePoints >= 90) return "A";
        if (gradePoints >= 80) return "B";
        if (gradePoints >= 70) return "C";
        if (gradePoints >= 60) return "D";
        return "F";
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] transpose = new int[columns, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }
        return transpose;
    }

    public static int SumOfMatrix(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }

    public static int ProductOfDiagonal(int[,] matrix)
    {
        int product = 1;
        int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
        for (int i = 0; i < size; i++)
        {
            product *= matrix[i, i];
        }
        return product;
    }
}
