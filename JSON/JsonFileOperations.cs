using System.Text.Json;
using System.Xml.Linq;

public static class JsonFileOperations
{
    public static void PrintKeysAndValues(string path)
    {
        using JsonDocument document = JsonDocument.Parse(File.ReadAllText(path));
        Print(document.RootElement, "root");
    }

    private static void Print(JsonElement element, string path)
    {
        if (element.ValueKind == JsonValueKind.Object)
            foreach (JsonProperty property in element.EnumerateObject()) Print(property.Value, $"{path}.{property.Name}");
        else if (element.ValueKind == JsonValueKind.Array)
        {
            int index = 0;
            foreach (JsonElement item in element.EnumerateArray()) Print(item, $"{path}[{index++}]");
        }
        else Console.WriteLine($"{path}: {element}");
    }

    public static void MergeFiles(string firstPath, string secondPath, string outputPath)
    {
        string result = BasicJsonHandling.Merge(File.ReadAllText(firstPath), File.ReadAllText(secondPath));
        File.WriteAllText(outputPath, result);
    }

    public static void ConvertToXml(string jsonPath, string xmlPath)
    {
        using JsonDocument document = JsonDocument.Parse(File.ReadAllText(jsonPath));
        XElement root = ToXmlElement("root", document.RootElement);
        File.WriteAllText(xmlPath, root.ToString());
    }

    private static XElement ToXmlElement(string name, JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Object)
            return new XElement(name, element.EnumerateObject().Select(property => ToXmlElement(property.Name, property.Value)));
        if (element.ValueKind == JsonValueKind.Array)
            return new XElement(name, element.EnumerateArray().Select(item => ToXmlElement("item", item)));
        return new XElement(name, element.ToString());
    }
}
