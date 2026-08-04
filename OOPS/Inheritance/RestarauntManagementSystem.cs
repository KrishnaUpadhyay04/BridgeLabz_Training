namespace RestaurauntManagement;

interface Worker
{
    public void PerformDuties();
}
class Person
{
    public string Name;
    public int Id;

    public Person()
    {
        Name = "Unknown";
        Id = 0;
    }

    public Person(string Name, int Id)
    {
        this.Name = Name;
        this.Id = Id;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Id   : {Id}");
    }
}

class Chef : Person, Worker
{
    public string Speciality;

    public Chef() : base()
    {
        Speciality = "";
    }

    public Chef(string Name, int Id, string Speciality) : base(Name, Id)
    {
        this.Speciality = Speciality;
    }

    public void PerformDuties()
    {
        Console.WriteLine("Chef");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role  : Chef");
    }
}

class Waiter : Person, Worker
{
    public int TableNumber;

    public Waiter() : base()
    {
        TableNumber = 0;
    }

    public Waiter(string Name, int Id, int TableNumber) : base(Name, Id)
    {
        this.TableNumber = TableNumber;
    }

    public void PerformDuties()
    {
        Console.WriteLine("Waiter");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Role  : Waiter");
    }
}