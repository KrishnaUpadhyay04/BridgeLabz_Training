public static class Program
{
	public static void Main()
	{
		Console.WriteLine("JSON and Data Handling Practice");
		Console.WriteLine("Choose an exercise, A for all demos, or Q to quit.");
		while (true)
		{
			PrintMenu();
			string choice = Read("Choice: ").Trim();
			if (choice.Equals("Q", StringComparison.OrdinalIgnoreCase)) break;
			if (choice.Equals("A", StringComparison.OrdinalIgnoreCase)) { RunAll(); continue; }
			if (!int.TryParse(choice, out int problem) || problem is < 1 or > 16)
			{
				Console.WriteLine("Enter a number from 1 to 16, A, or Q.");
				continue;
			}
			try { RunProblem(problem); }
			catch (Exception exception) { Console.WriteLine($"Operation failed: {exception.Message}"); }
		}
	}

	private static void PrintMenu()
	{
		Console.WriteLine();
		Console.WriteLine("1. Create Student JSON");
		Console.WriteLine("2. Serialize a Car object");
		Console.WriteLine("3. Extract name and email from JSON file");
		Console.WriteLine("4. Merge two JSON objects");
		Console.WriteLine("5. Validate JSON with Newtonsoft schema");
		Console.WriteLine("6. Serialize a list as JSON array");
		Console.WriteLine("7. Filter users older than an age");
		Console.WriteLine("8. Print all JSON keys and values");
		Console.WriteLine("9. Merge two JSON files");
		Console.WriteLine("10. Convert JSON to XML");
		Console.WriteLine("11. Convert CSV to JSON");
		Console.WriteLine("12. Generate database JSON report");
		Console.WriteLine("13. Validate an email JSON field");
		Console.WriteLine("14. IPL JSON/CSV censorship analyzer");
		Console.WriteLine("15. Read and filter JSON text");
		Console.WriteLine("16. Extract fields and print JSON values");
		Console.WriteLine("A. Run all sample demos");
		Console.WriteLine("Q. Quit");
	}

	private static void RunProblem(int problem)
	{
		switch (problem)
		{
			case 1: BasicJsonHandling.CreateStudent(); break;
			case 2: BasicJsonHandling.SerializeCar(); break;
			case 3: BasicJsonHandling.ExtractFields(Read("JSON file path: ")); break;
			case 4: Console.WriteLine(BasicJsonHandling.Merge(Read("First JSON object: "), Read("Second JSON object: "))); break;
			case 5: JsonSchemaValidation.Run(Read("JSON value: "), Read("JSON schema: ")); break;
			case 6: BasicJsonHandling.SerializeList(); break;
			case 7: BasicJsonHandling.FilterByAge(Read("JSON array of users: "), ReadInt("Minimum age: ")); break;
			case 8: JsonFileOperations.PrintKeysAndValues(Read("JSON file path: ")); break;
			case 9: JsonFileOperations.MergeFiles(Read("First JSON file: "), Read("Second JSON file: "), Read("Output JSON file: ")); break;
			case 10: JsonFileOperations.ConvertToXml(Read("JSON file: "), Read("Output XML file: ")); break;
			case 11: CsvToJsonAndReport.CsvToJson(Read("CSV file: "), Read("Output JSON file: ")); break;
			case 12: CsvToJsonAndReport.GenerateDatabaseReport(Read("Output report JSON file: ")); break;
			case 13: JsonSchemaValidation.Run(Read("JSON value: "), EmailSchema); break;
			case 14: IplCensorshipAnalyzer.Run(Read("IPL JSON input: "), Read("Censored JSON output: "), Read("IPL CSV input: "), Read("Censored CSV output: ")); break;
			case 15: BasicJsonHandling.FilterByAge(Read("JSON array of users: "), ReadInt("Print users older than: ")); break;
			case 16: JsonFileOperations.PrintKeysAndValues(Read("JSON file path: ")); break;
		}
	}

	private static readonly string EmailSchema = "{\"type\":\"object\",\"properties\":{\"email\":{\"type\":\"string\",\"format\":\"email\"}},\"required\":[\"email\"]}";

	private static void RunAll()
	{
		string directory = Path.Combine(Path.GetTempPath(), "JsonPractice");
		Directory.CreateDirectory(directory);
		string users = Path.Combine(directory, "users.json");
		string first = Path.Combine(directory, "first.json");
		string second = Path.Combine(directory, "second.json");
		string csv = Path.Combine(directory, "students.csv");
		string iplJson = Path.Combine(directory, "ipl.json");
		string iplCsv = Path.Combine(directory, "ipl.csv");
		File.WriteAllText(users, "[{\"name\":\"Asha\",\"age\":22,\"email\":\"asha@example.com\"},{\"name\":\"Ravi\",\"age\":30,\"email\":\"ravi@example.com\"}]");
		File.WriteAllText(first, "{\"name\":\"Asha\",\"role\":\"Developer\"}");
		File.WriteAllText(second, "{\"email\":\"asha@example.com\",\"active\":true}");
		File.WriteAllText(csv, "Name,Age,Marks\nAsha,22,91\nRavi,30,86\n");
		File.WriteAllText(iplJson, "[{\"match_id\":101,\"team1\":\"Mumbai Indians\",\"team2\":\"Chennai Super Kings\",\"score\":{\"Mumbai Indians\":178,\"Chennai Super Kings\":182},\"winner\":\"Chennai Super Kings\",\"player_of_match\":\"MS Dhoni\"}]");
		File.WriteAllText(iplCsv, "match_id,team1,team2,score_team1,score_team2,winner,player_of_match\n101,Mumbai Indians,Chennai Super Kings,178,182,Chennai Super Kings,MS Dhoni\n");
		Console.WriteLine($"Sample files: {directory}");
		BasicJsonHandling.CreateStudent(); BasicJsonHandling.SerializeCar(); BasicJsonHandling.ExtractFields(users);
		Console.WriteLine(BasicJsonHandling.Merge(File.ReadAllText(first), File.ReadAllText(second))); BasicJsonHandling.SerializeList();
		BasicJsonHandling.FilterByAge(File.ReadAllText(users), 25); JsonSchemaValidation.Run("{\"email\":\"user@example.com\"}", EmailSchema);
		JsonFileOperations.PrintKeysAndValues(users); JsonFileOperations.MergeFiles(first, second, Path.Combine(directory, "merged.json"));
		JsonFileOperations.ConvertToXml(users, Path.Combine(directory, "users.xml")); CsvToJsonAndReport.CsvToJson(csv, Path.Combine(directory, "students.json"));
		CsvToJsonAndReport.GenerateDatabaseReport(Path.Combine(directory, "report.json"));
		IplCensorshipAnalyzer.Run(iplJson, Path.Combine(directory, "censored.json"), iplCsv, Path.Combine(directory, "censored.csv"));
		Console.WriteLine("All demos completed.");
	}

	private static string Read(string prompt) { Console.Write(prompt); return Console.ReadLine() ?? string.Empty; }

	private static int ReadInt(string prompt)
	{
		while (true)
		{
			if (int.TryParse(Read(prompt), out int value)) return value;
			Console.WriteLine("Enter a valid integer.");
		}
	}
}
