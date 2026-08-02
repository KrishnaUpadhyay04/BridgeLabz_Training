using System;
using System.Collections.Generic;

namespace ObjectModeling.Hospital
{
    class Patient
    {
        public string Name { get; }

        // Association
        private List<Doctor> doctors = new();

        public Patient(string name)
        {
            Name = name;
        }

        public void AddDoctor(Doctor doctor)
        {
            if (!doctors.Contains(doctor))
            {
                doctors.Add(doctor);
            }
        }

        public void DisplayDoctors()
        {
            Console.WriteLine($"\n{Name}'s Doctors:");

            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine(doctor.Name);
            }
        }
    }

    class Doctor
    {
        public string Name { get; }

        // Association
        private List<Patient> patients = new();

        public Doctor(string name)
        {
            Name = name;
        }

        public void AddPatient(Patient patient)
        {
            if (!patients.Contains(patient))
            {
                patients.Add(patient);
                patient.AddDoctor(this);
            }
        }

        public void Consult(Patient patient)
        {
            Console.WriteLine($"{Name} is consulting {patient.Name}.");
        }

        public void DisplayPatients()
        {
            Console.WriteLine($"\n{Name}'s Patients:");

            foreach (Patient patient in patients)
            {
                Console.WriteLine(patient.Name);
            }
        }
    }

    class Hospital
    {
        public string Name { get; }

        private List<Doctor> doctors = new();
        private List<Patient> patients = new();

        public Hospital(string name)
        {
            Name = name;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void DisplayDoctors()
        {
            Console.WriteLine($"\nDoctors in {Name}:");

            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine(doctor.Name);
            }
        }

        public void DisplayPatients()
        {
            Console.WriteLine($"\nPatients in {Name}:");

            foreach (Patient patient in patients)
            {
                Console.WriteLine(patient.Name);
            }
        }
    }
}