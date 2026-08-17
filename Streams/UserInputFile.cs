using System;
using System.IO;

public class UserInputFile
{
    public void Execute()
    {
        try
        {
            using StreamReader reader =
                new StreamReader(Console.OpenStandardInput());

            Console.Write("Enter your name: ");
            string name = reader.ReadLine() ?? "";

            Console.Write("Enter your age: ");
            int age = int.Parse(reader.ReadLine() ?? "0");

            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine() ?? "";

            using StreamWriter writer =
                new StreamWriter("userdetails.txt");

            writer.WriteLine($"Name: {name}");
            writer.WriteLine($"Age: {age}");
            writer.WriteLine($"Favorite Language: {language}");

            Console.WriteLine("Information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid age.");
        }
    }
}