using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;
using NewtonSoft.Json;
using NewtonSoft.Json.Schema;
namespace FlightBooking.Models;
public class Booking
{
    public string? BookingId { get; set; }
    public string? PassengerName { get; set; }
    public string? FromCode { get; set ;}
    public string? ToCode { get; set; }
    public string? SeatClass { get; set; }

    public Booking(string BookingId, string PassengerName, string FromCode, string ToCode, string SeatClass)
    {
        this.BookingId = BookingId;
        this.PassengerName = PassengerName;
        this.FromCode = FromCode;
        this.ToCode = ToCode;
        this.SeatClass = SeatClass;
    }

    

    public bool isValid()
    {
        StreamReader reader = new StreamReader("bookingschema.json");

        string schematext = reader.ReadToEnd();
        reader.Dispose();

        string datatext = JsonSerializer.Serialize(this);

        JSchema schema = JSchema.Parse(schematext);

        JObject data = JObject.Parse(datatext);

        return data.IsValid(schema);

    }
}