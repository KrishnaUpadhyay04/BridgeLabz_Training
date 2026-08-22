using System.Reflection;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class InjectAttribute : Attribute
{
}

public interface IMessageService
{
    string GetMessage();
}

public sealed class MessageService : IMessageService
{
    public string GetMessage() => "Dependency injected successfully.";
}

public sealed class NotificationController
{
    [Inject]
    private IMessageService MessageService { get; set; } = null!;

    public void Notify() => Console.WriteLine(MessageService.GetMessage());
}

public sealed class SimpleDiContainer
{
    private readonly Dictionary<Type, Type> registrations = new();

    public void Register<TService, TImplementation>() where TImplementation : TService
        => registrations[typeof(TService)] = typeof(TImplementation);

    public T Resolve<T>() where T : class => (T)Resolve(typeof(T));

    private object Resolve(Type requestedType)
    {
        Type implementation = registrations.GetValueOrDefault(requestedType, requestedType);
        object instance = Activator.CreateInstance(implementation)
            ?? throw new InvalidOperationException($"Could not create {implementation.Name}.");

        foreach (FieldInfo field in implementation.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            if (field.GetCustomAttribute<InjectAttribute>() is not null)
                field.SetValue(instance, Resolve(field.FieldType));
        foreach (PropertyInfo property in implementation.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            if (property.GetCustomAttribute<InjectAttribute>() is not null && property.CanWrite)
                property.SetValue(instance, Resolve(property.PropertyType));
        return instance;
    }
}

public static class DependencyInjectionDemo
{
    public static void Run()
    {
        SimpleDiContainer container = new();
        container.Register<IMessageService, MessageService>();
        container.Resolve<NotificationController>().Notify();
    }
}
