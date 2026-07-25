public static class Question15
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number >= 0)
        {
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Please enter a non-negative integer");
        }
    }
}
