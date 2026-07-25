public static class Question12
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n > 0)
        {
            int formulaSum = n * (n + 1) / 2;
            int loopSum = 0;
            int i = 1;

            while (i <= n)
            {
                loopSum += i;
                i++;
            }

            Console.WriteLine($"Formula sum: {formulaSum}");
            Console.WriteLine($"While loop sum: {loopSum}");
            Console.WriteLine($"Result correct: {formulaSum == loopSum}");
        }
        else
        {
            Console.WriteLine("The number is not a natural number");
        }
    }
}
