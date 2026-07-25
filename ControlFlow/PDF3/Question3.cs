public static class Question3
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);
        int sum = 0;
        int temp = number;

        while (temp != 0)
        {
            sum += temp % 10;
            temp /= 10;
        }

        if (number % sum == 0)
        {
            Console.WriteLine($"{number} is a Harshad Number");
        }
        else
        {
            Console.WriteLine($"{number} is not a Harshad Number");
        }
    }
}
