using System;
using System.IO;
using System.Text;

public class UppercaseToLowercase
{
    public void Execute()
    {
        string sourceFile = "input.txt";
        string destinationFile = "lowercase.txt";

        try
        {
            using FileStream inputFile =
                new FileStream(sourceFile, FileMode.Open);

            using FileStream outputFile =
                new FileStream(destinationFile, FileMode.Create);

            using BufferedStream bufferedInput =
                new BufferedStream(inputFile);

            using BufferedStream bufferedOutput =
                new BufferedStream(outputFile);

            using StreamReader reader =
                new StreamReader(
                    bufferedInput,
                    Encoding.UTF8
                );

            using StreamWriter writer =
                new StreamWriter(
                    bufferedOutput,
                    Encoding.UTF8
                );

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }

            Console.WriteLine("File converted to lowercase.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}