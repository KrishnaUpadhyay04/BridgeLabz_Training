namespace TicketSystem;

public class TicketQueue<T>
{
    private PriorityQueue<T, DateTime> queue;

    public TicketQueue()
    {
        queue = new PriorityQueue<T, DateTime>();
    }

    public void Enqueue(T item, DateTime priority)
    {
        queue.Enqueue(item, priority);
    }

    public bool TryPeek(out T item)
    {
        return queue.TryPeek(out item, out _);
    }

    public bool TryDequeue(out T item)
    {
        return queue.TryDequeue(out item, out _);
    }

    public int Count => queue.Count;
}