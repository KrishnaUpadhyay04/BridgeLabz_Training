using System.Security.Cryptography;
using System.Text;

public static class EncryptCsvData
{
    public static void Encrypt(string inputPath, string outputPath, string password) => Transform(inputPath, outputPath, password, true);
    public static void Decrypt(string inputPath, string outputPath, string password) => Transform(inputPath, outputPath, password, false);

    private static void Transform(string inputPath, string outputPath, string password, bool encrypt)
    {
        List<Dictionary<string, string>> records = CsvUtilities.Read(inputPath);
        using Aes aes = Aes.Create();
        aes.Key = SHA256.HashData(Encoding.UTF8.GetBytes(password));
        aes.IV = new byte[16];
        foreach (Dictionary<string, string> record in records)
            foreach (string column in record.Keys.ToArray())
                if (column.Equals("Salary", StringComparison.OrdinalIgnoreCase) || column.Equals("Email", StringComparison.OrdinalIgnoreCase))
                    record[column] = encrypt ? Convert.ToBase64String(aes.CreateEncryptor().TransformFinalBlock(Encoding.UTF8.GetBytes(record[column]), 0, Encoding.UTF8.GetByteCount(record[column]))) : Encoding.UTF8.GetString(aes.CreateDecryptor().TransformFinalBlock(Convert.FromBase64String(record[column]), 0, Convert.FromBase64String(record[column]).Length));
        CsvUtilities.Write(outputPath, records.FirstOrDefault()?.Keys.ToArray() ?? Array.Empty<string>(), records);
    }
}
