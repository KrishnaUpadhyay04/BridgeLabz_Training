using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
public sealed class AuthorAttribute : Attribute
{
    public AuthorAttribute(string name) => Name = name;
    public string Name { get; }
}

[Author("BridgeLabz Student")]
public sealed class DocumentedClass
{
}

public static class RuntimeAttributes
{
    public static void Run()
    {
        AuthorAttribute? author = typeof(DocumentedClass).GetCustomAttribute<AuthorAttribute>();
        Console.WriteLine($"Author: {author?.Name ?? "Not specified"}");
    }
}
