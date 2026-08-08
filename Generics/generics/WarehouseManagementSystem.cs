abstract class Warehouse
{
    public string Id { get; protected set; }
    public string Name { get; protected set; }
    public double Price{ get; protected set; }

    public Warehouse()
    {
        Id = "";
        Name = "";
        Price = 0.0;
    }

    public Warehouse(string Id, string Name, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
    }

    public abstract void DisplayDetails();
}

class Electronics : Warehouse
{
    public Electronics() : base() {}

    public Electronics(string Id, string Name, double Price) : base(Id, Name, Price) {}

    public override void DisplayDetails()
    {
        Console.WriteLine($"Product Id    : {Id}");
        Console.WriteLine($"Product Name  : {Name}");
        Console.WriteLine($"Product Price : {Price}");
        Console.WriteLine("Product Type   : Electronic");
    }
}

class Groceries : Warehouse
{
    public Groceries()
    {
        Id = "";
        Name = "";
        Price = 0.0;
    }

    public Groceries(string Id, string Name, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Product Id    : {Id}");
        Console.WriteLine($"Product Name  : {Name}");
        Console.WriteLine($"Product Price : {Price}");
        Console.WriteLine("Product Type   : Grocery");
    }
}

class Furniture : Warehouse
{
    public Furniture()
    {
        Id = "";
        Name = "";
        Price = 0.0;
    }

    public Furniture(string Id, string Name, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Product Id    : {Id}");
        Console.WriteLine($"Product Name  : {Name}");
        Console.WriteLine($"Product Price : {Price}");
        Console.WriteLine("Product Type   : Furniture");
    }
}

class Storage<T> where T : Warehouse
{
    public static List<T> list = new List<T>();

    public void AddItem(T Item)
    {
        list.Add(Item);
    }

    public void DisplayItems()
    {
        Console.WriteLine("------------------------");
        foreach(var item in list)
        {
            item.DisplayDetails();
            Console.WriteLine("------------------------");
        }
    }
}