Console.WriteLine("Built-In Function Practice Problems.");
Console.WriteLine("1. Number Guessing Game.");
Console.WriteLine("2. Maximum of Three Numbers.");
Console.WriteLine("3. Prime Number Checker.");
Console.WriteLine("4. Fibonacci Sequence Generator.");
Console.WriteLine("5. Palindrome Checker.");
Console.WriteLine("6. Factorial Using recursion");
Console.WriteLine("7. GCD and LCM Calculator.");
Console.WriteLine("8. Temperature Convertor.");
Console.WriteLine("9. Basic Calculator.");

Console.Write("Enter your choice: ");
string? choice = Console.ReadLine();

switch(choice)
{
    case "1": Question1.Solution(); break;
    case "2": Question2.Solution(); break;
    case "3": Question3.Solution(); break;
    case "4": Question4.Solution(); break;
    case "5": Question5.Solution(); break;
    case "6": Question6.Solution(); break;
    case "7": Question7.Solution(); break;
    case "8": Question8.Solution(); break;
    case "9": Question9.Solution(); break;
    default: Console.WriteLine("Invalid Choice!"); break;
}