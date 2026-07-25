Console.WriteLine("Choose a question to run:");
Console.WriteLine("1. Armstrong number");
Console.WriteLine("2. Number of digits");
Console.WriteLine("3. Harshad number");
Console.WriteLine("4. Abundant number");
Console.WriteLine("5. Day of week");
Console.WriteLine("6. Calculator using switch case");

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
    default: Console.WriteLine("Invalid choice"); break;
}
