public static class Question14
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number >= 0)
        {
            long factorial = 1;
            int i = 1;

            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Please enter a non-negative integer");
        }
    }
}
