using System;
using System.Diagnostics;
using System.IO;

public class BufferedFileCopy
{
    public void Execute()
    {
        string sourceFile = "largefile.dat";
        string normalCopy = "normal_copy.dat";
        string bufferedCopy = "buffered_copy.dat";

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        CopyUsingNormalStream(sourceFile, normalCopy);
        CopyUsingBufferedStream(sourceFile, bufferedCopy);
    }

    private void CopyUsingNormalStream(string source, string destination)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        using FileStream input = new FileStream(
            source,
            FileMode.Open,
            FileAccess.Read
        );

        using FileStream output = new FileStream(
            destination,
            FileMode.Create,
            FileAccess.Write
        );

        byte[] buffer = new byte[4096];
        int bytesRead;

        while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
        {
            output.Write(buffer, 0, bytesRead);
        }

        stopwatch.Stop();

        Console.WriteLine(
            $"Normal FileStream: {stopwatch.ElapsedMilliseconds} ms"
        );
    }

    private void CopyUsingBufferedStream(string source, string destination)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        using FileStream inputFile = new FileStream(
            source,
            FileMode.Open,
            FileAccess.Read
        );

        using FileStream outputFile = new FileStream(
            destination,
            FileMode.Create,
            FileAccess.Write
        );

        using BufferedStream input = new BufferedStream(inputFile);
        using BufferedStream output = new BufferedStream(outputFile);

        byte[] buffer = new byte[4096];
        int bytesRead;

        while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
        {
            output.Write(buffer, 0, bytesRead);
        }

        stopwatch.Stop();

        Console.WriteLine(
            $"BufferedStream: {stopwatch.ElapsedMilliseconds} ms"
        );
    }
}