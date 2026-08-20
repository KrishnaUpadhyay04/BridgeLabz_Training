using NUnit.Framework;
using TicketSystem;

namespace TicketSystem.Tests;

[TestFixture]
public class TicketTests
{
    private TicketService service;

    [SetUp]
    public void Setup()
    {
        Dictionary<string, int> sla = new() {{ "P1", 5 }, { "P2", 10 }, { "P3", 15 }, { "P4", 20 }};

        service = new TicketService(sla);
    }


    // Zero Tags
    [Test]
    public void ZeroTags_ShouldParseSuccessfully()
    {
        string input =
            "TICKET-100 | PRIORITY:P2 | " +
            "CREATED:2026-08-10T08:00:00 | " +
            "STATUS:open | ASSIGNEE:none | TAGS:";

        Ticket ticket = ParseTicket.Parse(input);

        Assert.That(ticket.Tags, Is.Empty);
    }


    // One Tag
    [Test]
    public void OneTag_ShouldBeExtracted()
    {
        string input =
            "TICKET-101 | PRIORITY:P2 | " +
            "CREATED:2026-08-10T08:00:00 | " +
            "STATUS:open | ASSIGNEE:none | TAGS:billing";

        Ticket ticket = ParseTicket.Parse(input);

        Assert.That(ticket.Tags, Has.Count.EqualTo(1));
        Assert.That(ticket.Tags[0], Is.EqualTo("billing"));
    }


    // Multiple Tags
    [Test]
    public void MultipleTags_ShouldBeExtracted()
    {
        string input =
            "TICKET-102 | PRIORITY:P2 | " +
            "CREATED:2026-08-10T08:00:00 | " +
            "STATUS:open | ASSIGNEE:none | " +
            "TAGS:billing,urgent,refund";

        Ticket ticket = ParseTicket.Parse(input);

        Assert.That(ticket.Tags, Is.EqualTo(new[]{"billing", "urgent", "refund"}));
    }


    // Unassigned Tickets
    [Test]
    public void UnassignedTicket_ShouldBeEligible()
    {
        Ticket ticket = new Ticket("100", "P2", new DateTime(2026, 8, 10, 8, 0, 0), "open", "none", new List<string>()
        );

        DateTime current = new DateTime(2026, 8, 10, 9, 1, 0);
        Assert.That(service.IsEligibleForEscalation(ticket, current), Is.True);
    }


    // Assigned Ticket
    [Test]
    public void AssignedTicket_ShouldNotBeEscalated()
    {
        Ticket ticket = new Ticket("101", "P2", new DateTime(2026, 8, 10, 8, 0, 0), "open", "krishna", new List<string>()
        );

        DateTime current = new DateTime(2026, 8, 10, 10, 0, 0);

        Assert.That(service.IsEligibleForEscalation(ticket, current), Is.False);
    }

}