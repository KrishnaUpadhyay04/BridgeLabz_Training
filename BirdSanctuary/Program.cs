using System.IO.Compression;
using BirdSanctuary.Models;

class Program
{
    static void Main(string[] args)
    {
        Bird Eagle = new Eagle();
        Bird Ostrich = new Ostrich();
        Bird Duck = new Duck();
        Bird Eagle2 = new Eagle(1);

        Sanctuary sanctuary = new("BirdSanctuary", "Chandigarh");

        sanctuary.AddBird(Eagle);
        sanctuary.AddBird(Ostrich);
        sanctuary.AddBird(Duck);
        sanctuary.AddBird(Eagle2);

        sanctuary.DisplayBirds();

        sanctuary.DisplayFlyingBirds();
    }
}