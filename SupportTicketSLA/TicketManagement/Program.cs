using TicketSystem;

Console.WriteLine("Enter number of tickets: ");
int number = Convert.ToInt32(Console.ReadLine());
List<Ticket> tickets = new();
for(int i = 0; i < number; i++)
{
    Console.WriteLine("Enter ticket details: ");
    string input = Console.ReadLine() ?? "";

    Ticket ticket = ParseTicket.Parse(input);
    tickets.Add(ticket);
}


foreach(Ticket ticket in tickets)
{
    ticket.DisplayDetails();
    Console.WriteLine();
}

TicketService service = new TicketService(Ticket.priority);

DateTime currentTime = DateTime.Now;

List<Ticket> breachedTickets = service.GetBreachedTickets(tickets, currentTime);

Console.WriteLine("----------------------");
Console.WriteLine("Breached Tickets");
Console.WriteLine("----------------------");

foreach (Ticket ticket in breachedTickets)
{
    ticket.DisplayDetails();
    Console.WriteLine();
}

Dictionary<string, int> trendingTags = service.GetTrendingTags(tickets);

Console.WriteLine("----------------------");
Console.WriteLine("Trending Tags");
Console.WriteLine("----------------------");

foreach (var tag in trendingTags)
{
    Console.WriteLine($"{tag.Key}: {tag.Value}");
}


TicketQueue<Ticket> queue = new TicketQueue<Ticket>();

foreach (Ticket ticket in tickets)
{
    queue.Enqueue(ticket, ticket.Created);
}

Console.WriteLine("----------------------");
Console.WriteLine("Ticket Queue");
Console.WriteLine("----------------------");

while (queue.TryDequeue(out Ticket ticket))
{
    ticket.DisplayDetails();
    Console.WriteLine();
}

// TICKET-88231 | PRIORITY:P2 | CREATED:2026-08-10T08:00:00 | STATUS:open | ASSIGNEE:none | TAGS:billing,urgent,refund