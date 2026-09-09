using System.Text.Json;
namespace FlightBooking;

using FlightBooking.Models;
using FlightBooking.Exceptions;
using System.Reflection.Emit;
using System.Text.Json.Serialization;
using CsvHelper;
using System.Globalization;
using System.Text;

public class FlightBooking
{
    private static int EconomySeat = 4;
    private static int BusinessSeat = 2;
    
    private Dictionary<string, Booking> BookedFlights;

    private List<Booking> EconomySeats;
    private List<Booking> BusinessSeats;


    public FlightBooking()
    {
        BookedFlights = new Dictionary<string, Booking>();

    }


    public void LoadAirports()
    {
        string text = JsonSerializer.Deserialize<string>("airports.json");

        string[] airports = text.Split(',');

        foreach(var airport in airports)
        {
            Console.Write(airport + " ");
        }
    }


    public void AddBooking(Booking booking)
    {

        // Rejected Bookings
        if(BookedFlights.Contains(booking.BookingId))
        {
            using(BufferedStream buffer = new BufferedStream("rejected.json", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string text = JsonSerializer.Serialize(BookingId);

                buffer.Write(Encoding.UTF8.GetBytes(text));
            }
            throw new DuplicateBookingException("Booking already exists.");
        }

        if(booking.IsValid())
        {
            if((booking.SeatType == "Economy" && EconomySeat < 1) || (booking.SeatType == "Business" && BusinessSeat < 1)) throw new SeatUnavailbleException("No seats available for this class.");
            
            BookedFlights.Add(booking.BookingId, booking);


            // Add to allocations.json
            Persist(booking);


            if(booking.SeatClass == "Economy")
            {
                EconomySeats.Add(booking);
                EconomySeat--;
            }
            else
            {
                BusinessSeats.Add(booking);
                BusinessSeat--;
            }
        }
        else throw new FlightException("Invalid Booking");
    }

    public void Persist(Booking Booking)
    {
        string jsonstring = JsonSerializer.Serialize(Booking, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText("allocations.json", jsonstring);
    }


    public void DisplayRejectedFlights()
    {
        using(BufferedStream buffer = new BufferedStream("rejected.json", FileMode.Open, FileAccess.Read))
        {
            int bytesRead;

            while((bytesRead = buffer.Read()) > 0) Console.Write((char)bytesRead);
        }
    }

    public void AddFlight(Booking Booking)
    {
        using (FileStream fs = new FileStream("flights.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            string text = Encoding.UTF8.GetBytes($"Booking Id: {Booking.BookingId}, Passenger Name: {Booking.PassengerName}, From: {Booking.FromCode}, To: {Booking.ToCode}, Class: {Booking.SeatClass}");

            fs.Write(text);
        }
    }

    public void ViewFlights()
    {
        using(StreamReader reader = new StreamReader("flights.txt"))
        {
            string? line;

            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}