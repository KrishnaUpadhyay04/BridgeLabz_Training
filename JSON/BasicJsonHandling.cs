using System.Text.Json;
using System.Text.Json.Nodes;

public static class BasicJsonHandling
{
    private static readonly JsonSerializerOptions Options = new() { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

    public static void CreateStudent() => Console.WriteLine(JsonSerializer.Serialize(new Student { Name = "Anita", Age = 20, Subjects = new() { "Math", "Science" } }, Options));

    public static void SerializeCar() => Console.WriteLine(JsonSerializer.Serialize(new Car { Brand = "Toyota", Model = "Camry", Year = 2024 }, Options));

    public static void ExtractFields(string path)
    {
        using JsonDocument document = JsonDocument.Parse(File.ReadAllText(path));
        JsonElement root = document.RootElement;
        IEnumerable<JsonElement> records = root.ValueKind == JsonValueKind.Array ? root.EnumerateArray() : new[] { root };
        foreach (JsonElement record in records)
        {
            string name = record.TryGetProperty("name", out JsonElement nameValue) ? nameValue.ToString() : string.Empty;
            string email = record.TryGetProperty("email", out JsonElement emailValue) ? emailValue.ToString() : string.Empty;
            Console.WriteLine($"Name: {name}, Email: {email}");
        }
    }

    public static string Merge(string firstJson, string secondJson)
    {
        JsonObject first = JsonNode.Parse(firstJson)?.AsObject() ?? new();
        JsonObject second = JsonNode.Parse(secondJson)?.AsObject() ?? new();
        foreach ((string key, JsonNode? value) in second) first[key] = value?.DeepClone();
        return first.ToJsonString(Options);
    }

    public static void SerializeList() => Console.WriteLine(JsonSerializer.Serialize(new[] { new Student { Name = "Asha", Age = 21 }, new Student { Name = "Ravi", Age = 26 } }, Options));

    public static void FilterByAge(string json, int minimumAge)
    {
        foreach (UserRecord user in JsonSerializer.Deserialize<List<UserRecord>>(json) ?? new())
            if (user.Age > minimumAge) Console.WriteLine(JsonSerializer.Serialize(user, Options));
    }
}
