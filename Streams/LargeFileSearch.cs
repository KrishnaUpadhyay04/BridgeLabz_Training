using System;
using System.IO;

public class LargeFileSearch
{
    public void Execute()
    {
        string file = "largefile.txt";

        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            using StreamReader reader =
                new StreamReader(file);

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(
                    "error",
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}