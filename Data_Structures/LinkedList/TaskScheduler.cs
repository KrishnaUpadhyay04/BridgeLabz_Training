namespace LinkedList;

class TaskNode
{
    public int Id;
    public string Name;
    public int Priority;
    public DateTime Time;

    public TaskNode? next;

    public TaskNode(int Id, string Name, int Priority, DateTime Time)
    {
        this.Id = Id;
        this.Name = Name;
        this.Priority = Priority;
        this.Time = Time;
        next = null;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Task Id       : {Id}");
        Console.WriteLine($"Task Name     : {Name}");
        Console.WriteLine($"Task Priority : {Priority}");
        Console.WriteLine($"Due Date      : {Time}");
        Console.WriteLine("--------------------------------");
    }
}

class CircularLinkedList
{
    TaskNode? head;
    TaskNode? tail;

    public void AddAtStart(TaskNode task)
    {
        // If the list is empty
        if(head == null)
        {
            head = tail = task;
            task.next = head;
            return;
        }

        task.next = head;
        head = task;
        tail.next = head;
    }

    public void AddAtEnd(TaskNode task)
    {
        if(tail == null)
        {
            head = tail = task;
            task.next = head;
            return;
        }

        task.next = head;
        tail.next = task;
        tail = task;
    }

    public void AddAtPosition(TaskNode task, int position)
    {
        if(position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }

        if(position == 1)
        {
            AddAtStart(task);
            return;
        }

        TaskNode? temp = head;
        int curr = 1;
        while(curr < position - 1)
        {
            if(temp == head)
            {
                Console.WriteLine("Position out of Bounds.");
                return;
            }

            curr++;
            temp = temp.next;
        }

        if(temp == tail)
        {
            tail.next = task;
            task.next = head;
            tail = task;
            return;
        }

        task.next = temp.next;
        temp.next = task;
    }

    public void RemoveByTaskId(int Id)
    {
        if(head == null) return;

        if(head.Id == Id)
        {
            if(head == tail)
            {
                head = tail = null;
                return;
            }

            tail.next = head.next;
            head = head.next;
            return;
        }

        TaskNode? temp = head.next;

        while(temp != head)
        {
            if(temp.next == head)
            {
                Console.WriteLine("Task not found");
                return;
            }


            if(temp.next.Id == Id)
            {

                // If task is at tail
                if(temp.next == tail) tail = temp;

                temp.next = temp.next.next;
                return;
            }
            temp = temp.next;
        }
    }

    public void DisplayAllTasks()
    {
        if(head == null) return;

        head.DisplayDetails();
        TaskNode? temp = head.next;
        while(temp != null && temp != head)
        {
            temp.DisplayDetails();
            temp = temp.next;
        }
    }

    public void SearchTaskByPriority(int Priority)
    {
        if(head == null) return;
        if(head.Priority == Priority) head.DisplayDetails();
        TaskNode? temp = head.next;

        while(temp != head && temp != null)
        {
            if(temp.Priority == Priority)
            {
                temp.DisplayDetails();
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Error, Task not Found!");
    }
}