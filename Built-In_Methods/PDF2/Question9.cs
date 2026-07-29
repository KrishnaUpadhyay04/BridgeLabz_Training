using System;
using System.Data.Common;

public class Question9
{
    public static void Solution()
    {
        int number1 = GetNumber("Enter the first number: ");
        int number2 = GetNumber("Enter the second number: ");
        Console.Write("Choose operation: +, -, *, /");
        char opr = Console.ReadLine()[0];

        if(opr == '+')
        {
            int answer = AddNumbers(number1, number2);
            Console.WriteLine($"Sum of {number1} and {number2} is: {answer}");
        }

        else if(opr == '-')
        {
            int answer = SubtractNumbers(number1, number2);
            Console.WriteLine($"Difference of {number1} and {number2} is: {answer}");
        }

        else if(opr == '*')
        {
            int answer = MultiplyNumbers(number1, number2);
            Console.WriteLine($"Product of {number1} and {number2} is: {answer}");
        }

        else if(opr == '/')
        {
            int answer = DivideNumbers(number1, number2);
            if(answer != int.MinValue)Console.WriteLine($"Quotient of {number1} and {number2} is: {answer}");
            else Console.WriteLine("Invalid! Can't divide by 0.");
        }
    }


    static void GetNumber(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
    static int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }

    static int SubtractNumbers(int number1, int number2)
    {
        return number1 - number2;
    }

    static int MultiplyNumbers(int number1, int number2)
    {
        return number1 * number2;
    }

    static int DivideNumbers(int number1, int number2)
    {
        if(number2 == 0) return int.MinValue;
        return number1 / number2;
    }
}