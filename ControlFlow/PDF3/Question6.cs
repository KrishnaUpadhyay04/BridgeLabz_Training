public static class Question6
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        double first = double.Parse(Console.ReadLine()!);
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine()!;
        Console.Write("Enter second number: ");
        double second = double.Parse(Console.ReadLine()!);

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine($"Result: {first / second}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
