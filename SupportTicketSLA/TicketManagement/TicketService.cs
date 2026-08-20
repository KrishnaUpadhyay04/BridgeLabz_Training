namespace TicketSystem;

public class TicketService
{
    private Dictionary<string, int> slaLimits;

    public TicketService(Dictionary<string, int> slaLimits)
    {
        this.slaLimits = slaLimits;
    }

    public bool IsEligibleForEscalation(Ticket ticket, DateTime currentTime)
    {
        if (ticket.Status != "open") return false;

        if (ticket.Assignee != "none") return false;

        int slaMinutes = slaLimits[ticket.Priority];

        DateTime deadline = ticket.Created.AddMinutes(slaMinutes);

        return currentTime > deadline;
    }

    public List<Ticket> GetBreachedTickets(List<Ticket> tickets, DateTime currentTime)
    {
        return tickets.Where(t => IsEligibleForEscalation(t, currentTime)).ToList();
    }

    public Dictionary<string, int> GetTrendingTags(List<Ticket> tickets)
    {
        return tickets.Where(t => t.Status == "open").SelectMany(t => t.Tags).GroupBy(tag => tag).OrderByDescending(g => g.Count()).ToDictionary(g => g.Key, g => g.Count());
    }
}