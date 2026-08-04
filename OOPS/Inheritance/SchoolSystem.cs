namespace SchoolSystem;

class Person
{
    public string Name;
    public int Age;

    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    public Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("Role  : Person");
    }
}

class Teacher : Person
{
    public string Subject;

    public Teacher() : base()
    {
        Subject = "Unknown";
    }

    public Teacher(string Name, int Age, string Subject) : base(Name, Age)
    {
        this.Subject = Subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Teacher");
    }
}

class Student : Person
{
    public string Grade;

    public Student() : base()
    {
        Grade = "Unknown";
    }

    public Student(string Name, int Age, string Grade) : base(Name, Age)
    {
        this.Grade = Grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Student");
    }
}

class Staff : Person
{
    public string Period;

    public Staff() : base()
    {
        Period = "Unknown";
    }

    public Staff(string Name, int Age, string Period) : base(Name, Age)
    {
        this.Period = Period;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Staff");
    }
}