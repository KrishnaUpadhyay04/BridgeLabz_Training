using System;

Console.WriteLine("Choose a question to run:");
Console.WriteLine("1. Divisibility by 5");
Console.WriteLine("2. First is smallest");
Console.WriteLine("3. Largest of three numbers");
Console.WriteLine("4. Sum of n natural numbers");
Console.WriteLine("5. Voting eligibility");
Console.WriteLine("6. Positive/negative/zero");
Console.WriteLine("7. Spring season");
Console.WriteLine("8. Countdown using while loop");
Console.WriteLine("9. Countdown using for loop");
Console.WriteLine("10. Sum until 0");
Console.WriteLine("11. Sum until 0 or negative");
Console.WriteLine("12. Sum of n natural numbers using while loop");
Console.WriteLine("13. Sum of n natural numbers using for loop");
Console.WriteLine("14. Factorial using while loop");
Console.WriteLine("15. Factorial using for loop");
Console.WriteLine("16. Odd and even numbers");
Console.WriteLine("17. Employee bonus");
Console.WriteLine("18. Multiplication table");

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
    case 11: Question11.Run(); break;
    case 12: Question12.Run(); break;
    case 13: Question13.Run(); break;
    case 14: Question14.Run(); break;
    case 15: Question15.Run(); break;
    case 16: Question16.Run(); break;
    case 17: Question17.Run(); break;
    case 18: Question18.Run(); break;
    default: Console.WriteLine("Invalid choice"); break;
}
