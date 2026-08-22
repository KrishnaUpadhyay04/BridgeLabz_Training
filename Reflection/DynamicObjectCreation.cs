using System.Reflection;

public sealed class Student
{
    public string Name { get; set; } = string.Empty;
    public int RollNumber { get; set; }

    public override string ToString() => $"{Name} (Roll number: {RollNumber})";
}

public static class DynamicObjectCreation
{
    public static void Run(string name, int rollNumber)
    {
        object? value = Activator.CreateInstance(typeof(Student));
        if (value is not Student student)
            throw new InvalidOperationException("Student could not be created.");

        typeof(Student).GetProperty(nameof(Student.Name))!.SetValue(student, name);
        typeof(Student).GetProperty(nameof(Student.RollNumber))!.SetValue(student, rollNumber);
        Console.WriteLine($"Created dynamically: {student}");
    }
}
