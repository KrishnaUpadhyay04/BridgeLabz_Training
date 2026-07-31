using System;

class HotelBooking
{
    public string GuestName;
    public string RoomType;
    public int NumberOfNights;

    public HotelBooking()
    {
        GuestName = "Unknown";
        RoomType = "Unknown";
        NumberOfNights = 0;
    }

    public HotelBooking(string Name, string Room, int Days)
    {
        GuestName = Name;
        RoomType = Room;
        NumberOfNights = Days;
    }

    public HotelBooking(HotelBooking hotelBooking)
    {
        GuestName = hotelBooking.GuestName;
        RoomType = hotelBooking.RoomType;
        NumberOfNights = hotelBooking.NumberOfNights;
    }

    public void Display()
    {
        Console.WriteLine($"GuestName: {GuestName}\nRoomType: {RoomType}\nNumberOfNughts:{NumberOfNights}");
    }
}