using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("       FILE HANDLING MENU");
            Console.WriteLine("==============================");

            Console.WriteLine("1. Read and Write Text File");
            Console.WriteLine("2. Buffered File Copy");
            Console.WriteLine("3. Read User Input and Save");
            Console.WriteLine("4. Employee Serialization");
            Console.WriteLine("5. Image to Byte Array");
            Console.WriteLine("6. Uppercase to Lowercase");
            Console.WriteLine("7. Binary Student Data");
            Console.WriteLine("8. Pipe Stream Communication");
            Console.WriteLine("9. Search Large File");
            Console.WriteLine("10. Top 5 Word Frequency");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");

            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    new FileReadWrite().Execute();
                    break;

                case 2:
                    new BufferedFileCopy().Execute();
                    break;

                case 3:
                    new UserInputFile().Execute();
                    break;

                case 4:
                    new EmployeeSerialization().Execute();
                    break;

                case 5:
                    new ImageByteArray().Execute();
                    break;

                case 6:
                    new UppercaseToLowercase().Execute();
                    break;

                case 7:
                    new StudentBinaryData().Execute();
                    break;

                case 8:
                    new PipeCommunication().Execute();
                    break;

                case 9:
                    new LargeFileSearch().Execute();
                    break;

                case 10:
                    new WordFrequency().Execute();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}