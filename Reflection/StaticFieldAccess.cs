using System.Reflection;

public static class Configuration
{
    private static string API_KEY = "initial-key";

    public static string CurrentApiKey => API_KEY;
}

public static class StaticFieldAccess
{
    public static void Run(string newApiKey)
    {
        FieldInfo field = typeof(Configuration).GetField("API_KEY", BindingFlags.Static | BindingFlags.NonPublic)
            ?? throw new MissingFieldException(nameof(Configuration), "API_KEY");
        field.SetValue(null, newApiKey);
        Console.WriteLine($"API_KEY: {Configuration.CurrentApiKey}");
    }
}
