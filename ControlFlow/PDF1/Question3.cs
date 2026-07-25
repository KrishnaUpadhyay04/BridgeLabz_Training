public static class Question3
{
    public static void Run()
    {
        Console.Write("Enter number1: ");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter number2: ");
        int number2 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter number3: ");
        int number3 = int.Parse(Console.ReadLine()!);

        bool isFirstLargest = number1 > number2 && number1 > number3;
        bool isSecondLargest = number2 > number1 && number2 > number3;
        bool isThirdLargest = number3 > number1 && number3 > number2;

        Console.WriteLine($"Is the first number the largest? {isFirstLargest}");
        Console.WriteLine($"Is the second number the largest? {isSecondLargest}");
        Console.WriteLine($"Is the third number the largest? {isThirdLargest}");
    }
}
