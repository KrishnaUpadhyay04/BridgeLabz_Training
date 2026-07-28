using System;

public class Question7
{
    public static void Run()
    {
        Console.WriteLine("Question 7: OTP generation");
        Console.Write("How many OTPs do you want to generate? ");
        int count = Convert.ToInt32(Console.ReadLine());

        int[] otps = new int[count];
        for (int i = 0; i < count; i++)
        {
            otps[i] = Program.GenerateOTP();
        }

        Console.WriteLine($"Generated OTPs: {string.Join(", ", otps)}");
        Console.WriteLine($"Unique: {Program.AreOTPsUnique(otps)}");
    }
}
