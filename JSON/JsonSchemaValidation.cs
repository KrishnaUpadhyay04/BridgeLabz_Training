using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

public static class JsonSchemaValidation
{
    public static void Run(string json, string schemaJson)
    {
        JToken data = JToken.Parse(json);
        JSchema schema = JSchema.Parse(schemaJson);
        IList<string> errors = new List<string>();
        bool valid = data.IsValid(schema, out errors);
        Console.WriteLine(valid ? "JSON is valid." : "JSON is invalid.");
        foreach (string error in errors) Console.WriteLine($"  {error}");
    }
}
