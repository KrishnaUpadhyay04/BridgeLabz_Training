Console.WriteLine("Choose a question to run:");
Console.WriteLine("1. Leap year");
Console.WriteLine("2. Prime number check");
Console.WriteLine("3. FizzBuzz using for loop");
Console.WriteLine("4. FizzBuzz using while loop");
Console.WriteLine("5. BMI calculator");
Console.WriteLine("6. Youngest and tallest friend");
Console.WriteLine("7. Greatest factor of a number");
Console.WriteLine("8. Power of a number");
Console.WriteLine("9. Factors of a number");
Console.WriteLine("10. Multiples of a number below 100");

Console.Write("Enter your choice: ");
int choice = int.Parse(Console.ReadLine()!);

switch (choice)
{
    case 1: Question1.Run(); break;
    case 2: Question2.Run(); break;
    case 3: Question3.Run(); break;
    case 4: Question4.Run(); break;
    case 5: Question5.Run(); break;
    case 6: Question6.Run(); break;
    case 7: Question7.Run(); break;
    case 8: Question8.Run(); break;
    case 9: Question9.Run(); break;
    case 10: Question10.Run(); break;
    default: Console.WriteLine("Invalid choice"); break;
}
