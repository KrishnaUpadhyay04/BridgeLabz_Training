using System.Reflection;

public interface IGreeting
{
    void SayHello(string name);
}

public sealed class Greeting : IGreeting
{
    public void SayHello(string name) => Console.WriteLine($"Hello, {name}!");
}

public class LoggingProxy<T> : DispatchProxy where T : class
{
    public T Decorated { get; set; } = null!;

    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
    {
        Console.WriteLine($"Calling: {targetMethod?.Name}");
        return targetMethod?.Invoke(Decorated, args);
    }

    public static T Create(T decorated)
    {
        T proxy = Create<T, LoggingProxy<T>>();
        ((LoggingProxy<T>)(object)proxy).Decorated = decorated;
        return proxy;
    }
}

public static class LoggingProxyDemo
{
    public static void Run(string name)
    {
        IGreeting greeting = LoggingProxy<IGreeting>.Create(new Greeting());
        greeting.SayHello(name);
    }
}
