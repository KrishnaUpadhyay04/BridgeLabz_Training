public static class Program
{
	public static void Main()
	{
		Console.WriteLine("Reflection Practice Problems");
		Console.WriteLine("Enter a number to run one exercise, A to run all, or Q to quit.");

		while (true)
		{
			PrintMenu();
			string choice = ReadText("Choice: ").Trim();

			if (choice.Equals("Q", StringComparison.OrdinalIgnoreCase))
				break;

			Console.WriteLine();
			if (choice.Equals("A", StringComparison.OrdinalIgnoreCase))
			{
				RunAll();
				continue;
			}

			if (!int.TryParse(choice, out int problem) || problem is < 1 or > 12)
			{
				Console.WriteLine("Please enter a number from 1 to 12, A, or Q.");
				continue;
			}

			RunProblem(problem);
		}
	}

	private static void PrintMenu()
	{
		Console.WriteLine();
		Console.WriteLine("1. Get class information");
		Console.WriteLine("2. Access private field");
		Console.WriteLine("3. Invoke private method");
		Console.WriteLine("4. Create Student dynamically");
		Console.WriteLine("5. Invoke a math method dynamically");
		Console.WriteLine("6. Retrieve a custom attribute");
		Console.WriteLine("7. Modify a private static field");
		Console.WriteLine("8. Map a dictionary to an object");
		Console.WriteLine("9. Generate JSON using reflection");
		Console.WriteLine("10. Run a logging proxy");
		Console.WriteLine("11. Inject a dependency");
		Console.WriteLine("12. Measure method execution time");
		Console.WriteLine("A. Run all demos");
		Console.WriteLine("Q. Quit");
	}

	private static void RunProblem(int problem)
	{
		switch (problem)
		{
			case 1:
				ClassInformation.Display(ReadText("Class name (for example, Student): "));
				break;
			case 2:
				PrivateFieldAccess.Run(ReadInt("Initial age: "), ReadInt("New age: "));
				break;
			case 3:
				PrivateMethodInvocation.Run(ReadInt("First number: "), ReadInt("Second number: "));
				break;
			case 4:
				DynamicObjectCreation.Run(ReadText("Student name: "), ReadInt("Roll number: "));
				break;
			case 5:
				DynamicMethodInvocation.Run(ReadText("Method (Add, Subtract, Multiply): "), ReadInt("First number: "), ReadInt("Second number: "));
				break;
			case 6:
				RuntimeAttributes.Run();
				break;
			case 7:
				StaticFieldAccess.Run(ReadText("New API key: "));
				break;
			case 8:
				CustomObjectMapper.Run();
				break;
			case 9:
				ReflectionJsonRepresentation.Run();
				break;
			case 10:
				LoggingProxyDemo.Run(ReadText("Greeting name: "));
				break;
			case 11:
				DependencyInjectionDemo.Run();
				break;
			case 12:
				MethodExecutionTiming.Run(ReadText("Method name (SumNumbers): "), ReadInt("Count: "));
				break;
		}
	}

 	private static void RunAll()
	{
		Console.WriteLine("Running all demonstrations with sample values...");
		ClassInformation.Display("Student");
		PrivateFieldAccess.Run(20, 21);
		PrivateMethodInvocation.Run(6, 7);
		DynamicObjectCreation.Run("Asha", 101);
		DynamicMethodInvocation.Run("Add", 10, 5);
		RuntimeAttributes.Run();
		StaticFieldAccess.Run("demo-api-key");
		CustomObjectMapper.Run();
		ReflectionJsonRepresentation.Run();
		LoggingProxyDemo.Run("World");
		DependencyInjectionDemo.Run();
		MethodExecutionTiming.Run("SumNumbers", 100000);
	}

 	private static string ReadText(string prompt)
	{
		Console.Write(prompt);
		return Console.ReadLine() ?? string.Empty;
	}

	private static int ReadInt(string prompt)
	{
		while (true)
		{
			string value = ReadText(prompt);
			if (int.TryParse(value, out int result)) return result;
			Console.WriteLine("Please enter a valid integer.");
		}
	}
}
