using System;

class Patient
{
    public string Name;
    public int Age;
    public string Ailment;
    public readonly string PatientId;

    public static string HospitalName = "Chitkara University Hospital";
    public static int TotalPatients = 0;

    public Patient(string Name, int Age, string Ailment, string PatientId)
    {
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        this.PatientId = PatientId;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine($"Total Patients: {TotalPatients}");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Ailment: {Ailment}");
        Console.WriteLine($"PatientId: {PatientId}");
    }
}