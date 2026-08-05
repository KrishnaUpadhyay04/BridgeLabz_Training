using System;

namespace HospitalManagementSystem
{
    interface IMedicalRecord
    {
        void AddRecord(string diagnosis, string medicalHistory);

        string ViewRecords();
    }

    abstract class Patient
    {
        public string PatientId { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        private string Diagnosis;
        private string MedicalHistory;

        public Patient()
        {
            PatientId = "";
            Name = "Unknown";
            Age = 0;

            Diagnosis = "";
            MedicalHistory = "";
        }

        public Patient(string patientId, string name, int age)
        {
            PatientId = patientId;
            Name = name;
            Age = age;

            Diagnosis = "";
            MedicalHistory = "";
        }

        protected void SetMedicalRecord(string diagnosis, string medicalHistory)
        {
            Diagnosis = diagnosis;
            MedicalHistory = medicalHistory;
        }

        protected string GetMedicalRecord()
        {
            return $"Diagnosis      : {Diagnosis}\nMedical History : {MedicalHistory}";
        }

        public abstract double CalculateBill();

        public void DisplayPatientDetails()
        {
            Console.WriteLine($"Patient ID : {PatientId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Age        : {Age}");
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        public int DaysAdmitted { get; private set; }
        public double RoomChargePerDay { get; private set; }
        public double TreatmentCharge { get; private set; }

        public InPatient() : base()
        {
            DaysAdmitted = 0;
            RoomChargePerDay = 0;
            TreatmentCharge = 0;
        }

        public InPatient(string patientId,
                         string name,
                         int age,
                         int daysAdmitted,
                         double roomChargePerDay,
                         double treatmentCharge)
            : base(patientId, name, age)
        {
            DaysAdmitted = daysAdmitted;
            RoomChargePerDay = roomChargePerDay;
            TreatmentCharge = treatmentCharge;
        }

        public override double CalculateBill()
        {
            return DaysAdmitted * RoomChargePerDay + TreatmentCharge;
        }

        public void AddRecord(string diagnosis, string medicalHistory)
        {
            SetMedicalRecord(diagnosis, medicalHistory);
        }

        public string ViewRecords()
        {
            return GetMedicalRecord();
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        public double ConsultationFee { get; private set; }
        public double MedicineCharge { get; private set; }

        public OutPatient() : base()
        {
            ConsultationFee = 0;
            MedicineCharge = 0;
        }

        public OutPatient(string patientId,
                          string name,
                          int age,
                          double consultationFee,
                          double medicineCharge)
            : base(patientId, name, age)
        {
            ConsultationFee = consultationFee;
            MedicineCharge = medicineCharge;
        }

        public override double CalculateBill()
        {
            return ConsultationFee + MedicineCharge;
        }

        public void AddRecord(string diagnosis, string medicalHistory)
        {
            SetMedicalRecord(diagnosis, medicalHistory);
        }

        public string ViewRecords()
        {
            return GetMedicalRecord();
        }
    }
}
