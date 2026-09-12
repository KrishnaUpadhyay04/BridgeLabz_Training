namespace BirdSanctuary.Models;

public class Sanctuary
{
    public string Name {get; set;}
    public string Location {get; set;}
    private HashSet<Bird> Birds {get; set;} = new();
    private Dictionary<int, string> RemovedBirds {get; set;} = new();

    public Sanctuary(string Name, string Location)
    {
        this.Name = Name;
        this.Location = Location;
    }

    public void AddBird(Bird Bird)
    {
        Birds.Add(Bird);
    }

    public void UpdateBirdInfo(Bird Bird, string Name, string Species, int Age, string Color, string Habitat)
    {
        Bird.Name = Name;
        Bird.Species = Species;
        Bird.Age = Age;
        Bird.Color = Color;
        Bird.Habitat = Habitat;
    }

    public void RemoveBird(Bird Bird, string reason)
    {
        Birds.Remove(Bird);
        RemovedBirds.Add(Bird.BirdId, reason);
    }

    public void MoveBirdToAnotherSanctuary(Bird Bird, Sanctuary sanctuary)
    {
        RemoveBird(Bird.BirdId, $"Moved to Sanctuary {sanctuary.Name}");
        sanctuary.AddBird(Bird);
    }

    public int BirdCountBySpecies(string species)
    {
        int count = 0;
        foreach (Bird bird in Birds)
        {
            if(bird.Species == species) count++;
        }

        return count;
    }

    public int TotalBirdCount()
    {
        return Birds.Count;
    }

    public void RemoveDeceasedBird(Bird Bird)
    {
        RemoveBird(Bird.BirdId, "Deceased");
    }


    public void DisplayBirds()
    {
        foreach(Bird bird in Birds)
        {
            Console.WriteLine($"Bird ID: {bird.BirdId}, Name: {bird.Name}, Species: {bird.Species}, Age: {bird.Age}, Color: {bird.Color}, Habitat: {bird.Habitat}, Gender: {bird.Gender}");
            Console.WriteLine("-------------------------------");
        }
    }

    public void DisplayFlyingBirds()
    {
        foreach(Bird bird in Birds)
        {
            if(bird is IFlyingBird)
            {
                bird.DisplayDetails();
            }
        }
    }

    public void DisplayRunningBirds()
    {
        foreach(Bird bird in Birds)
        {
            if(bird is IRunningBird)
            {
                bird.DisplayDetails();
            }
        }
    }

    public void DisplaySwimmingBirds()
    {
        foreach(Bird bird in Birds)
        {
            if(bird is ISwimmingBird)
            {
                bird.DisplayDetails();
            }
        }
    }

}