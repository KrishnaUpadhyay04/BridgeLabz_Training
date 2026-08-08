using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Classes
{
    public class FileProcessor
    {
        public void WriteToFile(string FileName, string Content)
        {
            File.WriteAllText(FileName, Content);
        }

        public string ReadFromFile(string FileName)
        {
            if(!File.Exists(FileName))
            {
                throw new IOException("File does not exist.");
            }

            return File.ReadAllText(FileName);
        }
    }
}
