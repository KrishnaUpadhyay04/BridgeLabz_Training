using System.Reflection;

public sealed class MappablePerson
{
    public string Name = string.Empty;
    public int Age;
}

public static class CustomObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : class
    {
        if (!typeof(T).IsAssignableFrom(clazz))
            throw new ArgumentException($"{clazz.Name} is not assignable to {typeof(T).Name}.", nameof(clazz));

        T instance = (T)(Activator.CreateInstance(clazz)
            ?? throw new InvalidOperationException($"Could not create {clazz.Name}."));

        foreach ((string name, object value) in properties)
        {
            FieldInfo? field = clazz.GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            PropertyInfo? property = clazz.GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (field is not null)
                field.SetValue(instance, ConvertValue(value, field.FieldType));
            else if (property?.CanWrite == true)
                property.SetValue(instance, ConvertValue(value, property.PropertyType));
        }

        return instance;
    }

    private static object? ConvertValue(object value, Type targetType)
    {
        Type actualType = Nullable.GetUnderlyingType(targetType) ?? targetType;
        return actualType.IsInstanceOfType(value) ? value : Convert.ChangeType(value, actualType);
    }

    public static void Run()
    {
        MappablePerson person = ToObject<MappablePerson>(typeof(MappablePerson), new Dictionary<string, object>
        {
            ["Name"] = "Anita",
            ["Age"] = 25
        });
        Console.WriteLine($"Mapped object: {person.Name}, {person.Age}");
    }
}
