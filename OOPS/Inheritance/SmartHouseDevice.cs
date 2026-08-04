using System;

class Device
{
    public string DeviceId;
    public string Status;

    public Device()
    {
        DeviceId = "Unknown";
        Status = "Unknown";
    }

    public Device(string DeviceId, string Status)
    {
        this.DeviceId = DeviceId;
        this.Status = Status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device Id: {DeviceId}, Status: {Status}");
    }
}

class Thermostat : Device
{
    public string TemperatureSetting;

    public Thermostat() : base()
    {
        TemperatureSetting = "Unknown";
    }

    public Thermostat(string DeviceId, string Status, string TemperatureSetting) : base(DeviceId, Status)
    {
        this.TemperatureSetting = TemperatureSetting;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}");
    }
}