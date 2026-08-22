using System.Reflection;

public static class ClassInformation
{
    public static void Display(string className)
    {
        Type? type = Type.GetType(className, throwOnError: false, ignoreCase: true)
            ?? typeof(ClassInformation).Assembly.GetTypes()
                .FirstOrDefault(candidate => string.Equals(candidate.Name, className, StringComparison.OrdinalIgnoreCase));

        if (type is null)
        {
            Console.WriteLine($"Class '{className}' was not found.");
            return;
        }

        Console.WriteLine($"Class: {type.FullName}");
        Console.WriteLine("Constructors:");
        foreach (ConstructorInfo constructor in type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
            Console.WriteLine($"  {constructor}");

        Console.WriteLine("Methods:");
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
            Console.WriteLine($"  {method}");

        Console.WriteLine("Fields:");
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
            Console.WriteLine($"  {field.FieldType.Name} {field.Name}");
    }
}
