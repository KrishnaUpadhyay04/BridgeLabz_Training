using System.Text.RegularExpressions;

namespace TicketSystem;

public static class ParseTicket
{
    private static Regex parseticket = new (
        @"^TICKET-(?<Id>\d+)\s*\|\s*" + 
        @"PRIORITY:(?<Priority>P\d)\s*\|\s*" + 
        @"CREATED:(?<Created>[^|]+)\s*\|\s*" + 
        @"STATUS:(?<Status>[^|]+)\s*\|\s*" + 
        @"ASSIGNEE:(?<Assignee>[^|]+)\s*\|\s*" + 
        @"TAGS:(?<Tags>.*)$"
    );

    public static Ticket Parse(string input)
    {
        Match match = parseticket.Match(input);

        if(!match.Success) throw new Exception("Invalid Ticket!");

        string Id = match.Groups["Id"].Value;
        string Priority = match.Groups["Priority"].Value;
        string Created = match.Groups["Created"].Value.Trim();
        string Status = match.Groups["Status"].Value.Trim();
        string Assignee = match.Groups["Assignee"].Value.Trim();
        string TagsString = match.Groups["Tags"].Value.Trim();

        List<string> tags = TagsString == "" ? new() : TagsString.Split(',').Select(x => x.Trim()).ToList();

        return new Ticket(Id, Priority, DateTime.Parse(Created), Status, Assignee, tags);
    }
}