using System;
using System.IO;

public class StudentBinaryData
{
    public void Execute()
    {
        string file = "student.dat";

        try
        {
            Console.Write("Enter Roll Number: ");
            int rollNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter GPA: ");
            double gpa = double.Parse(Console.ReadLine() ?? "0");

            // Writing
            using (FileStream fileStream =
                   new FileStream(file, FileMode.Create))
            {
                using BinaryWriter writer =
                    new BinaryWriter(fileStream);

                writer.Write(rollNumber);
                writer.Write(name);
                writer.Write(gpa);
            }

            Console.WriteLine("\nStudent data saved.");

            // Reading
            using (FileStream fileStream =
                   new FileStream(file, FileMode.Open))
            {
                using BinaryReader reader =
                    new BinaryReader(fileStream);

                int storedRollNumber = reader.ReadInt32();
                string storedName = reader.ReadString();
                double storedGpa = reader.ReadDouble();

                Console.WriteLine("\nRetrieved Student:");
                Console.WriteLine($"Roll Number: {storedRollNumber}");
                Console.WriteLine($"Name: {storedName}");
                Console.WriteLine($"GPA: {storedGpa}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input.");
        }
    }
}