public static class Question13
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n > 0)
        {
            int formulaSum = n * (n + 1) / 2;
            int loopSum = 0;

            for (int i = 1; i <= n; i++)
            {
                loopSum += i;
            }

            Console.WriteLine($"Formula sum: {formulaSum}");
            Console.WriteLine($"For loop sum: {loopSum}");
            Console.WriteLine($"Result correct: {formulaSum == loopSum}");
        }
        else
        {
            Console.WriteLine("The number is not a natural number");
        }
    }
}
