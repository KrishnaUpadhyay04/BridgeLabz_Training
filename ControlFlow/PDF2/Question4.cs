public static class Question4
{
    public static void Run()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number > 0)
        {
            int i = 0;
            while (i <= number)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer");
        }
    }
}
