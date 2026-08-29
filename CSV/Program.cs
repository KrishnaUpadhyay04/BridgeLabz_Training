public static class Program
{
	public static void Main()
	{
		Console.WriteLine("CSV Data Handling Practice");
		Console.WriteLine("Choose an exercise, A for all demos, or Q to quit.");
		while (true)
		{
			PrintMenu();
			string choice = Read("Choice: ").Trim();
			if (choice.Equals("Q", StringComparison.OrdinalIgnoreCase)) break;
			if (choice.Equals("A", StringComparison.OrdinalIgnoreCase)) { RunAll(); continue; }
			if (!int.TryParse(choice, out int problem) || problem is < 1 or > 15)
			{
				Console.WriteLine("Enter a number from 1 to 15, A, or Q.");
				continue;
			}
			try { RunProblem(problem); }
			catch (Exception exception) { Console.WriteLine($"Operation failed: {exception.Message}"); }
		}
	}

	private static void PrintMenu()
	{
		Console.WriteLine();
		Console.WriteLine("1. Read and print CSV");
		Console.WriteLine("2. Write employee CSV");
		Console.WriteLine("3. Count CSV rows");
		Console.WriteLine("4. Filter students by marks");
		Console.WriteLine("5. Search employee by name");
		Console.WriteLine("6. Increase IT salaries");
		Console.WriteLine("7. Sort employees by salary");
		Console.WriteLine("8. Validate email and phone columns");
		Console.WriteLine("9. Convert CSV rows to Student objects");
		Console.WriteLine("10. Merge CSV files by ID");
		Console.WriteLine("11. Read large CSV in chunks");
		Console.WriteLine("12. Find duplicate IDs");
		Console.WriteLine("13. Generate employee report");
		Console.WriteLine("14. Convert JSON to CSV and CSV to JSON");
		Console.WriteLine("15. Encrypt or decrypt sensitive CSV fields");
		Console.WriteLine("A. Run all sample demos");
		Console.WriteLine("Q. Quit");
	}

	private static void RunProblem(int problem)
	{
		switch (problem)
		{
			case 1: ReadCsvData.Run(Read("CSV path: ")); break;
			case 2: WriteCsvData.Run(Read("Output CSV path: ")); break;
			case 3: CountCsvRows.Run(Read("CSV path: ")); break;
			case 4: FilterStudents.Run(Read("CSV path: "), ReadDecimal("Minimum marks: ")); break;
			case 5: SearchEmployee.Run(Read("Employees CSV path: "), Read("Employee name: ")); break;
			case 6: UpdateItSalaries.Run(Read("Input CSV path: "), Read("Output CSV path: ")); break;
			case 7: SortEmployeesBySalary.Run(Read("Employees CSV path: "), ReadInt("How many records: ")); break;
			case 8: ValidateCsvData.Run(Read("CSV path: ")); break;
			case 9: ConvertStudents.Run(Read("Students CSV path: ")); break;
			case 10: MergeCsvFiles.Run(Read("First CSV path: "), Read("Second CSV path: "), Read("Output CSV path: ")); break;
			case 11: ReadLargeCsv.Run(Read("CSV path: "), ReadInt("Chunk size: ")); break;
			case 12: FindDuplicateIds.Run(Read("CSV path: ")); break;
			case 13: DatabaseCsvReport.Run(Read("Output report path: ")); break;
			case 14: JsonCsvConversion.Run(Read("Input JSON path: "), Read("Output CSV path: "), Read("Output JSON path: ")); break;
			case 15:
				string action = Read("Action (encrypt/decrypt): ");
				string input = Read("Input CSV path: ");
				string output = Read("Output CSV path: ");
				string password = Read("Password: ");
				if (action.Equals("encrypt", StringComparison.OrdinalIgnoreCase)) EncryptCsvData.Encrypt(input, output, password);
				else if (action.Equals("decrypt", StringComparison.OrdinalIgnoreCase)) EncryptCsvData.Decrypt(input, output, password);
				else Console.WriteLine("Choose encrypt or decrypt.");
				break;
		}
	}

	private static void RunAll()
	{
		string directory = Path.Combine(Path.GetTempPath(), "CsvPractice");
		Directory.CreateDirectory(directory);
		string employees = Path.Combine(directory, "employees.csv");
		string students = Path.Combine(directory, "students.csv");
		string contacts = Path.Combine(directory, "contacts.csv");
		string second = Path.Combine(directory, "second.csv");
		string json = Path.Combine(directory, "students.json");
		File.WriteAllText(employees, "ID,Name,Department,Salary\nE1,Asha,IT,75000\nE2,Ravi,HR,62000\nE3,Meena,IT,88000\nE3,Meena,IT,88000\n");
		File.WriteAllText(students, "ID,Name,Age,Marks\nS1,Anita,20,91\nS2,Rahul,21,76\n");
		File.WriteAllText(contacts, "ID,Email,Phone\n1,valid@example.com,9876543210\n2,wrong-email,12345\n");
		File.WriteAllText(second, "ID,Location\nE1,Pune\nE2,Delhi\n");
		File.WriteAllText(json, "[{\"Id\":\"S1\",\"Name\":\"Anita\",\"Age\":20,\"Marks\":91}]");
		Console.WriteLine($"Sample files: {directory}");
		ReadCsvData.Run(employees); CountCsvRows.Run(employees); FilterStudents.Run(students, 80);
		SearchEmployee.Run(employees, "Asha"); UpdateItSalaries.Run(employees, Path.Combine(directory, "updated.csv"));
		SortEmployeesBySalary.Run(employees, 5); ValidateCsvData.Run(contacts); ConvertStudents.Run(students);
		MergeCsvFiles.Run(employees, second, Path.Combine(directory, "merged.csv")); ReadLargeCsv.Run(employees, 2);
		FindDuplicateIds.Run(employees); DatabaseCsvReport.Run(Path.Combine(directory, "report.csv"));
		JsonCsvConversion.Run(json, Path.Combine(directory, "json.csv"), Path.Combine(directory, "roundtrip.json"));
		EncryptCsvData.Encrypt(employees, Path.Combine(directory, "encrypted.csv"), "demo-password");
		EncryptCsvData.Decrypt(Path.Combine(directory, "encrypted.csv"), Path.Combine(directory, "decrypted.csv"), "demo-password");
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

	private static decimal ReadDecimal(string prompt)
	{
		while (true)
		{
			if (decimal.TryParse(Read(prompt), out decimal value)) return value;
			Console.WriteLine("Enter a valid number.");
		}
	}
}
