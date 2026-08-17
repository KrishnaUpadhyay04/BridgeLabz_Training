using System;
using System.IO;

public class ImageByteArray
{
    public void Execute()
    {
        string sourceImage = "original.jpg";
        string destinationImage = "copy.jpg";

        try
        {
            if (!File.Exists(sourceImage))
            {
                Console.WriteLine("Image does not exist.");
                return;
            }

            byte[] imageBytes;

            // Image → Byte Array
            using (FileStream fileStream =
                   new FileStream(sourceImage, FileMode.Open))
            {
                using MemoryStream memoryStream = new MemoryStream();

                fileStream.CopyTo(memoryStream);

                imageBytes = memoryStream.ToArray();
            }

            // Byte Array → Image
            using (MemoryStream memoryStream =
                   new MemoryStream(imageBytes))
            {
                using FileStream output =
                    new FileStream(
                        destinationImage,
                        FileMode.Create
                    );

                memoryStream.CopyTo(output);
            }

            Console.WriteLine("Image copied successfully.");

            // Verify
            byte[] originalBytes = File.ReadAllBytes(sourceImage);
            byte[] copiedBytes = File.ReadAllBytes(destinationImage);

            bool identical =
                originalBytes.Length == copiedBytes.Length;

            if (identical)
            {
                for (int i = 0; i < originalBytes.Length; i++)
                {
                    if (originalBytes[i] != copiedBytes[i])
                    {
                        identical = false;
                        break;
                    }
                }
            }

            Console.WriteLine(
                identical
                    ? "The images are identical."
                    : "The images are different."
            );
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
    }
}