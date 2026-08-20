using System;
using System.Collections.Generic;

namespace TicketSystem;

public class Ticket
{
    public string Id {get; private set;}
    public string Priority {get; private set;}
    public DateTime Created {get; private set;}
    public string Status {get; private set;}
    public string Assignee {get; private set;}
    public List<string> Tags {get; private set;}

    public static Dictionary<string, int> priority = new() {{"P1", 5}, {"P2", 10}, {"P3", 15}, {"P4", 20}};

    public static Dictionary<string, int> tagg = new();

    public Ticket(string Id, string Priority, DateTime Created, string Status, string Assignee, List<string> Tags)
    {
        this.Id = Id;
        this.Priority = Priority;
        this.Created = Created;
        this.Status = Status;
        this.Assignee = Assignee;
        this.Tags = Tags;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Id: {Id} | Priority: {Priority} | Created: {Created} | Status: {Status} | Assignee: {Assignee}");
    }
}