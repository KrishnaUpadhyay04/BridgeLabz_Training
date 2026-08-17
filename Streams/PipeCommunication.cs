using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

public class PipeCommunication
{
    public void Execute()
    {
        using AnonymousPipeServerStream server =
            new AnonymousPipeServerStream(
                PipeDirection.Out,
                HandleInheritability.Inheritable
            );

        string clientHandle = server.GetClientHandleAsString();

        Thread writerThread = new Thread(() =>
        {
            try
            {
                using StreamWriter writer =
                    new StreamWriter(server);

                writer.AutoFlush = true;

                writer.WriteLine("Hello from writer thread.");
                writer.WriteLine("This message is sent through PipeStream.");
                writer.WriteLine("End");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Writer error: " + ex.Message);
            }
        });

        Thread readerThread = new Thread(() =>
        {
            try
            {
                using AnonymousPipeClientStream client =
                    new AnonymousPipeClientStream(
                        PipeDirection.In,
                        clientHandle
                    );

                using StreamReader reader =
                    new StreamReader(client);

                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(
                        "Reader received: " + line
                    );

                    if (line == "End")
                        break;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reader error: " + ex.Message);
            }
        });

        readerThread.Start();
        writerThread.Start();

        writerThread.Join();
        readerThread.Join();

        Console.WriteLine("Pipe communication completed.");
    }
}