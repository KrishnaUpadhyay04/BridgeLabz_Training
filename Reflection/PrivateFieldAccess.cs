using System.Reflection;

public sealed class Person
{
    private int age;

    public Person(int age) => this.age = age;
}

public static class PrivateFieldAccess
{
    public static void Run(int initialAge, int updatedAge)
    {
        Person person = new(initialAge);
        FieldInfo field = typeof(Person).GetField("age", BindingFlags.Instance | BindingFlags.NonPublic)
            ?? throw new MissingFieldException(nameof(Person), "age");
        Console.WriteLine($"Original age: {field.GetValue(person)}");
        field.SetValue(person, updatedAge);
        Console.WriteLine($"Updated age: {field.GetValue(person)}");
    }
}
