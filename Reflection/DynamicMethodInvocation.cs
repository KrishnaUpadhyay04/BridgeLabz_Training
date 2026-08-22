using System.Reflection;

public sealed class MathOperations
{
    public int Add(int first, int second) => first + second;
    public int Subtract(int first, int second) => first - second;
    public int Multiply(int first, int second) => first * second;
}

public static class DynamicMethodInvocation
{
    public static void Run(string methodName, int first, int second)
    {
        MethodInfo? method = typeof(MathOperations).GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
        if (method is null || method.ReturnType != typeof(int))
        {
            Console.WriteLine("Unknown operation. Choose Add, Subtract, or Multiply.");
            return;
        }

        object result = method.Invoke(new MathOperations(), new object[] { first, second })!;
        Console.WriteLine($"{methodName} result: {result}");
    }
}
