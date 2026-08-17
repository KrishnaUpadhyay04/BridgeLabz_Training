using System;
using System.IO;

public class FileReadWrite
{
    public void Execute()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using FileStream sourceStream = new FileStream(
                sourceFile,
                FileMode.Open,
                FileAccess.Read
            );

            using FileStream destinationStream = new FileStream(
                destinationFile,
                FileMode.Create,
                FileAccess.Write
            );

            byte[] buffer = new byte[4096];
            int bytesRead;

            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                destinationStream.Write(buffer, 0, bytesRead);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}