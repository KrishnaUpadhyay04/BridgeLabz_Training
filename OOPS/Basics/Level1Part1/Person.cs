using System;
using System.ComponentModel.DataAnnotations;

class Person
{
    public string Name;
    public int Age;
    public string Gender;

    public Person()
    {
        Name = "Unknown";
        Age = 0;
        Gender = "Unknown";
    }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public Person(Person person)
    {
        this.Name = person.Name;
        this.Age = person.Age;
        this.Gender = person.Gender;
    }

    public void Display()
    {
        Console.WriteLine($"Name   : {Name}");
        Console.WriteLine($"Age    : {Age}");
        Console.WriteLine($"Gender : {Gender}");
    }
}