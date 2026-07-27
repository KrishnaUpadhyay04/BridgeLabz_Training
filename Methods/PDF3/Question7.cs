using System;

public class Question7
{
    public static void Run()
    {
        Console.WriteLine("Question 7: OTP generation");
        int[] otps = new int[10];
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = Program.GenerateOTP();
        }

        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }

        Console.WriteLine($"All unique: {Program.AreOTPsUnique(otps)}");
    }
}
