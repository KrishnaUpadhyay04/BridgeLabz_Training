using System.Diagnostics;
using System.Reflection;

public sealed class TimedOperations
{
    public long SumNumbers(int count)
    {
        long total = 0;
        for (int index = 0; index < count; index++) total += index;
        return total;
    }
}

public static class MethodExecutionTiming
{
    public static void Run(string methodName, int count)
    {
        MethodInfo? method = typeof(TimedOperations).GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
        if (method is null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        Stopwatch stopwatch = Stopwatch.StartNew();
        object? result = method.Invoke(new TimedOperations(), new object[] { count });
        stopwatch.Stop();
        Console.WriteLine($"Result: {result}; elapsed: {stopwatch.Elapsed.TotalMilliseconds:F3} ms");
    }
}
