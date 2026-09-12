namespace BirdSanctuary.Models;

public enum Gender
{
    MALE,
    FEMALE
}
public abstract class Bird
{
    public int BirdId {get; set;}
    public string? Name {get; set;}
    public string Species {get; set;}
    public int Age {get; set;}
    public string Color {get; set;}
    public string Habitat {get; set;}
    public Gender Gender {get; set;}

     public override bool Equals(object? obj)
    {
        if (obj is not Bird other) return false;

        return BirdId == other.BirdId;
    }

    public override int GetHashCode()
    {
        return BirdId.GetHashCode();
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Bird ID: {BirdId}, Name: {Name}, Species: {Species}, Age: {Age}, Color: {Color}, Habitat: {Habitat}, Gender: {Gender}");
    }

}


public interface IFlyingBird
{
    void Fly();
}

public interface IRunningBird
{
    void Run();
}

public interface ISwimmingBird
{
    void Swim();
}


public class Eagle : Bird, IFlyingBird
{
    public Eagle()
    {
        BirdId = 1;
        Name = "Eagle";
        Species = "";
        Age = 5;
        Color = "Black";
        Habitat = "Mountains";
        Gender = Gender.MALE;
    }

    public Eagle(int id)
    {
        BirdId = id;
        Name = "Eagle";
        Species = "";
        Age = 5;
        Color = "Black";
        Habitat = "Mountains";
        Gender = Gender.MALE;
    }
    public void Fly()
    {
        Console.WriteLine($"Flying");
    }
}

public class Ostrich : Bird, IRunningBird
{
    public Ostrich()
    {
        BirdId = 2;
        Name = "Ostrich";
        Species = "";
        Age = 7;
        Color = "Brown";
        Habitat = "Deserts";
        Gender = Gender.FEMALE;
    }
    public void Run()
    {
        Console.WriteLine($"Running");
    }
}

public class Duck : Bird, IFlyingBird, ISwimmingBird
{

    public Duck()
    {
        BirdId = 3;
        Name = "Duck";
        Species = "";
        Age = 6;
        Color = "White";
        Habitat = "Plains";
        Gender = Gender.MALE;
    }
    void IFlyingBird.Fly()
    {
        Console.WriteLine($"Flying");
    }

    void ISwimmingBird.Swim()
    {
        Console.WriteLine($"Swimming");
    }
}