using System;
using System.Collections.Generic;

namespace VehicleRentalSystem
{
    interface IInsurable
    {
        double CalculateInsurance();

        string GetInsuranceDetails();
    }

    abstract class Vehicle
    {
        public string VehicleNumber { get; private set; }
        public string VehicleType { get; private set; }
        public double RentalRate { get; private set; }

        private static List<Vehicle> vehicles = new();

        public Vehicle()
        {
            VehicleNumber = "";
            VehicleType = "";
            RentalRate = 0.0;
            vehicles.Add(this);
        }

        public Vehicle(string VehicleNumber, string VehicleType, double RentalRate)
        {
            this.VehicleNumber = VehicleNumber;
            this.VehicleType = VehicleType;
            this.RentalRate = RentalRate;
            vehicles.Add(this);
        }

        public abstract double CalculateRentalCost(int Days);

        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Vehicle Number : {VehicleNumber}");
            Console.WriteLine($"Vehicle Type   : {VehicleType}");
            Console.WriteLine($"Rental Rate    : ${RentalRate}");
        }

        public void DisplayAllDetails(int days)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayVehicleDetails();
                Console.WriteLine($"Total Rental Cost : {vehicle.CalculateRentalCost(days)}");
                if (vehicle is IInsurable insurable)
                {
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }
                Console.WriteLine("------------------------");
            }
        }
    }

    class Car : Vehicle, IInsurable
    {
        public double EMI { get; private set; }
        public double RateOfInsurance { get; private set; }
        public int MonthsOfInsurance { get; private set; }

        public Car() : base()
        {
            EMI = 0.0;
            RateOfInsurance = 0.0;
            MonthsOfInsurance = 0;
        }

        public Car(string VehicleNumber, string VehicleType, double RentalRate, double EMI, double RateOfInsurance, int MonthsOfInsurance) : base(VehicleNumber, VehicleType, RentalRate)
        {
            this.EMI = EMI;
            this.RateOfInsurance = RateOfInsurance;
            this.MonthsOfInsurance = MonthsOfInsurance;
        }

        public override double CalculateRentalCost(int Days)
        {
            return RentalRate * Days;
        }

        public double CalculateInsurance()
        {
            return EMI * RateOfInsurance * MonthsOfInsurance;
        }

        public string GetInsuranceDetails()
        {
            return $"EMI : {EMI}\nRate of Insurance : {RateOfInsurance}\nMonths : {MonthsOfInsurance}";
        }
    }

    class Bike : Vehicle, IInsurable
    {
        public double EMI { get; private set; }
        public double RateOfInsurance { get; private set; }
        public int MonthsOfInsurance { get; private set; }

        public Bike() : base()
        {
            EMI = 0.0;
            RateOfInsurance = 0.0;
            MonthsOfInsurance = 0;
        }

        public Bike(string VehicleNumber, string VehicleType, double RentalRate, double EMI, double RateOfInsurance, int MonthsOfInsurance) : base(VehicleNumber, VehicleType, RentalRate)
        {
            this.EMI = EMI;
            this.RateOfInsurance = RateOfInsurance;
            this.MonthsOfInsurance = MonthsOfInsurance;
        }

        public override double CalculateRentalCost(int Days)
        {
            return RentalRate * Days;
        }

        public double CalculateInsurance()
        {
            return EMI * RateOfInsurance * MonthsOfInsurance;
        }

        public string GetInsuranceDetails()
        {
            return $"EMI : {EMI}\nRate of Insurance : {RateOfInsurance}\nMonths : {MonthsOfInsurance}";
        }
    }

    class Truck : Vehicle
    {
        public Truck() : base() { }

        public Truck(string VehicleNumber, string VehicleType, double RentalRate) : base(VehicleNumber, VehicleType, RentalRate) { }

        public override double CalculateRentalCost(int Days)
        {
            return RentalRate * Days;
        }
    }
}
