public static class ReadLargeCsv
{
    public static void Run(string path, int chunkSize)
    {
        int processed = 0;
        using StreamReader reader = new(path);
        reader.ReadLine();
        while (true)
        {
            int chunkCount = 0;
            while (chunkCount < chunkSize && reader.ReadLine() is not null) { chunkCount++; processed++; }
            if (chunkCount == 0) break;
            Console.WriteLine($"Processed chunk: {chunkCount} records; total: {processed}");
        }
    }
}
