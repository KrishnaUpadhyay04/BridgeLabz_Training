using System.Reflection;
using System.Text.Json;

public static class ReflectionJsonRepresentation
{
    public static string ToJson(object value)
    {
        Dictionary<string, object?> fields = new(StringComparer.Ordinal);
        foreach (FieldInfo field in value.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            fields[field.Name] = field.GetValue(value);
        foreach (PropertyInfo property in value.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            if (property.CanRead)
                fields[property.Name] = property.GetValue(value);
        return JsonSerializer.Serialize(fields);
    }

    public static void Run()
    {
        MappablePerson person = new() { Name = "Ravi", Age = 30 };
        Console.WriteLine(ToJson(person));
    }
}
