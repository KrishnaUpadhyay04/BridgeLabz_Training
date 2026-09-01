namespace EventManager.Exceptions;

class SeatUnavailableException : Exception
{
    public int SeatId {get;}
    public SeatUnavailableException(string SeatId, string Reason) : base($"Seat {SeatId} is Unavailable: {Reason}")
    {
        this.SeatId = SeatId;
    }

    public SeatUnavailableException(string message) : base(message){}
}

class AccessibilityRequirementNotMetException : Exception
{

    public AccessibilityRequirementNotMetException() : base(){}
    public AccessibilityRequirementNotMetException(string Text) : base(Text) {}
}

class TimeOutException : Exception
{
    public TimeOutException() : base(){}

    public TimeOutException(string message) : base(message){}
}