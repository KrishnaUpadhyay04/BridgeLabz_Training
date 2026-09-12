using System.Text.Json;
using FlightBooking.Models;
using FlightBooking.Exceptions;
using System.Text;

namespace FlightBooking;

public class FlightBooking
{
    private int EconomySeat = 3;
    private int BusinessSeat = 1;

    private Dictionary<string, Booking> BookedFlights;
    private List<Allocation> allocations;
    private HashSet<string> airports;

    private HashSet<string> seatClass;

    private List<Booking> EconomySeats;
    private List<Booking> BusinessSeats;

    private int economySeatNumber = 1;
    private int businessSeatNumber = 1;


    public FlightBooking()
    {
        BookedFlights = new Dictionary<string, Booking>();

        allocations = new List<Allocation>();

        EconomySeats = new List<Booking>();
        BusinessSeats = new List<Booking>();

        airports = new HashSet<string>();

        seatClass = new HashSet<string> {"Economy", "Business"};

        LoadAirports();
    }

    public void LoadAirports()
    {
        using (FileStream fs = new FileStream("airports.json", FileMode.Open, FileAccess.Read))
        {
            AirportData? data = JsonSerializer.Deserialize<AirportData>(fs);

            if (data != null)
            {
                airports = new HashSet<string>(data.Airports);
            }
        }
    }


    public bool ValidAirport(Booking booking)
    {
        return airports.Contains(booking.FromCode) && airports.Contains(booking.ToCode);
    }

    public void ProcessBooking(string filePath = "flights.csv")
    {
        // if (airports.Count == 0) LoadAirports();

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader reader = new StreamReader(fs))
            {
                string? header = reader.ReadLine();

                // Empty file / header only
                if (string.IsNullOrWhiteSpace(header))
                {
                    Persist();
                    return;
                }

                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    try
                    {
                        Booking booking = ParseBooking(line);

                        AddBooking(booking);
                    }
                    catch (FlightException exception)
                    {
                        Booking? rejectedBooking = TryParseBooking(line);

                        if (rejectedBooking != null) WriteRejectedBooking(rejectedBooking, exception.Message);

                        Console.WriteLine($"Rejected: {exception.Message}");
                    }
                }
            }
        }

        Persist();
    }



    private Booking ParseBooking(string line)
    {
        string[] fields = line.Split(',');

        if (fields.Length != 5)throw new FlightException("Invalid CSV record.");

        return new Booking(fields[0], fields[1], fields[2], fields[3], fields[4]);
    }


    private Booking? TryParseBooking(string line)
    {
        try
        {
            return ParseBooking(line);
        }
        catch
        {
            return null;
        }
    }

    public Allocation AddBooking(Booking booking)
    {
        // Duplicate booking
        if (BookedFlights.ContainsKey(booking.BookingId)) throw new DuplicateBookingException("Booking already exists.");


        // Airport validation
        if (!ValidAirport(booking)) throw new InvalidAirportCodeException("Invalid airport code.");


        // Seat class validation
        if (!seatClass.Contains(booking.SeatClass)) throw new FlightException("Invalid seat class.");



        if (booking.SeatClass == "Economy")
        {
            if (EconomySeat < 1) throw new SeatUnavailableException("No Economy seats available.");

            string seatNumber = "E" + economySeatNumber;

            economySeatNumber++;
            EconomySeat--;

            EconomySeats.Add(booking);

            BookedFlights.Add(booking.BookingId, booking);

            Allocation allocation = new Allocation(booking.BookingId, booking.PassengerName, booking.FromCode, booking.ToCode, booking.SeatClass, seatNumber);

            allocations.Add(allocation);

            return allocation;
        }



        if (booking.SeatClass == "Business")
        {
            if (BusinessSeat < 1) throw new SeatUnavailableException("No Business seats available.");

            string seatNumber = "B" + businessSeatNumber;

            businessSeatNumber++;
            BusinessSeat--;

            BusinessSeats.Add(booking);

            BookedFlights.Add(booking.BookingId, booking);

            Allocation allocation = new Allocation(booking.BookingId, booking.PassengerName, booking.FromCode, booking.ToCode, booking.SeatClass, seatNumber);

            allocations.Add(allocation);

            return allocation;
        }


        throw new FlightException("Invalid Booking");
    }


    public void Persist()
    {
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.UTF8, true))
            {
                // Write number of allocations first
                writer.Write(allocations.Count);

                foreach (Allocation allocation in allocations)
                {
                    writer.Write(allocation.BookingId);
                    writer.Write(allocation.PassengerName);
                    writer.Write(allocation.FromCode);
                    writer.Write(allocation.ToCode);
                    writer.Write(allocation.SeatClass);
                    writer.Write(allocation.SeatNumber);
                }

                writer.Flush();
            }


            // Move back to beginning before reading
            memoryStream.Position = 0;


            List<Allocation> finalAllocations = new List<Allocation>();

            using (BinaryReader reader = new BinaryReader(memoryStream, Encoding.UTF8, true))
            {
                int count = reader.ReadInt32();

                for (int i = 0; i < count; i++)
                {
                    string bookingId = reader.ReadString();

                    string passengerName = reader.ReadString();

                    string fromCode = reader.ReadString();

                    string toCode = reader.ReadString();

                    string seatClass = reader.ReadString();

                    string seatNumber = reader.ReadString();


                    finalAllocations.Add(new Allocation(bookingId, passengerName, fromCode, toCode, seatClass, seatNumber));
                }
            }


            string jsonstring = JsonSerializer.Serialize(finalAllocations, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (FileStream fs = new FileStream("allocations.json", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(jsonstring);
                }
            }
        }
    }


    public void WriteRejectedBooking(Booking booking, string reason)
    {
        using (FileStream fs =  new FileStream("rejected.json", FileMode.Append, FileAccess.Write))
        {
            using (BufferedStream buffer = new BufferedStream(fs))
            {
                string text = JsonSerializer.Serialize(new{booking.BookingId, booking.PassengerName, booking.FromCode, booking.ToCode, booking.SeatClass, Reason = reason});

                byte[] bytes = Encoding.UTF8.GetBytes(text + "\n");

                buffer.Write(bytes);
            }
        }
    }


    public void DisplayRejectedFlights()
    {
        if (!File.Exists("rejected.json"))
        {
            Console.WriteLine("No rejected bookings.");
            return;
        }

        using (FileStream fs = new FileStream("rejected.json", FileMode.Open, FileAccess.Read))
        {
            using (BufferedStream buffer = new BufferedStream(fs))
            {
                using (StreamReader reader = new StreamReader(buffer))
                {
                    string? line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }


    public void AddFlight(Booking Booking)
    {
        using (FileStream fs = new FileStream("flights.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            string text = $"Booking Id: {Booking.BookingId}, " + $"Passenger Name: {Booking.PassengerName}, " + $"From: {Booking.FromCode}, " + $"To: {Booking.ToCode}, " + $"Class: {Booking.SeatClass}" + Environment.NewLine;

            byte[] bytes = Encoding.UTF8.GetBytes(text);

            fs.Position = fs.Length;

            fs.Write(bytes);
        }
    }


    public void ViewFlights()
    {
        if (!File.Exists("flights.txt")) return;

        using (StreamReader reader = new StreamReader("flights.txt"))
        {
            string? line;

            while ((line = reader.ReadLine()) != null) Console.WriteLine(line);
        }
    }

    public int GetRemainingEconomySeats()
    {
        return EconomySeat;
    }

    public int GetRemainingBusinessSeats()
    {
        return BusinessSeat;
    }

    public List<Allocation> GetAllocations()
    {
        return allocations;
    }
}