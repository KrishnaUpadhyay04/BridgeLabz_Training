using System.Reflection;

public sealed class Calculator
{
    private int Multiply(int first, int second) => first * second;
}

public static class PrivateMethodInvocation
{
    public static void Run(int first, int second)
    {
        Calculator calculator = new();
        MethodInfo method = typeof(Calculator).GetMethod("Multiply", BindingFlags.Instance | BindingFlags.NonPublic)
            ?? throw new MissingMethodException(nameof(Calculator), "Multiply");
        object? result = method.Invoke(calculator, new object[] { first, second });
        Console.WriteLine($"Multiply result: {result}");
    }
}
