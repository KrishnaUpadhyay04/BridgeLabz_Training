using System;

namespace RideHailingApplication
{
    interface IGPS
    {
        string GetCurrentLocation();

        void UpdateLocation(string location);
    }

    abstract class Vehicle
    {
        public string VehicleId { get; private set; }
        public string DriverName { get; private set; }
        public double RatePerKm { get; private set; }

        public Vehicle()
        {
            VehicleId = "";
            DriverName = "Unknown";
            RatePerKm = 0.0;
        }

        public Vehicle(string vehicleId,
                       string driverName,
                       double ratePerKm)
        {
            VehicleId = vehicleId;
            DriverName = driverName;
            RatePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID : {VehicleId}");
            Console.WriteLine($"Driver     : {DriverName}");
            Console.WriteLine($"Rate/Km    : {RatePerKm}");
        }
    }

    class Car : Vehicle, IGPS
    {
        private string CurrentLocation;

        public double BookingCharge { get; private set; }

        public Car() : base()
        {
            CurrentLocation = "Unknown";
            BookingCharge = 0;
        }

        public Car(string vehicleId,
                   string driverName,
                   double ratePerKm,
                   double bookingCharge)
            : base(vehicleId, driverName, ratePerKm)
        {
            CurrentLocation = "Unknown";
            BookingCharge = bookingCharge;
        }

        public override double CalculateFare(double distance)
        {
            return BookingCharge + RatePerKm * distance;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string location)
        {
            CurrentLocation = location;
        }
    }

    class Bike : Vehicle, IGPS
    {
        private string CurrentLocation;

        public double ConvenienceFee { get; private set; }

        public Bike() : base()
        {
            CurrentLocation = "Unknown";
            ConvenienceFee = 0;
        }

        public Bike(string vehicleId,
                    string driverName,
                    double ratePerKm,
                    double convenienceFee)
            : base(vehicleId, driverName, ratePerKm)
        {
            CurrentLocation = "Unknown";
            ConvenienceFee = convenienceFee;
        }

        public override double CalculateFare(double distance)
        {
            return ConvenienceFee + RatePerKm * distance;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string location)
        {
            CurrentLocation = location;
        }
    }

    class Auto : Vehicle, IGPS
    {
        private string CurrentLocation;

        public double BaseFare { get; private set; }

        public Auto() : base()
        {
            CurrentLocation = "Unknown";
            BaseFare = 0;
        }

        public Auto(string vehicleId, string driverName, double ratePerKm, double baseFare)
            : base(vehicleId, driverName, ratePerKm)
        {
            CurrentLocation = "Unknown";
            BaseFare = baseFare;
        }

        public override double CalculateFare(double distance)
        {
            return BaseFare + RatePerKm * distance;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string location)
        {
            CurrentLocation = location;
        }
    }
}
