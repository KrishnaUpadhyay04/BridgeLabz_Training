namespace LinkedList;

class StudentNode
{
    public int RollNo;
    public string Name;
    public int Age;
    public double Grade;
    public StudentNode? Next;

    public StudentNode(int RollNo, string Name, int Age, double Grade)
    {
        this.RollNo = RollNo;
        this.Name = Name;
        this.Age = Age;
        this.Grade = Grade;
        Next = null;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"Roll Number : {RollNo}");
        Console.WriteLine($"Name        : {Name}");
        Console.WriteLine($"Age         : {Age}");
        Console.WriteLine($"Grade       : {Grade}");
        Console.WriteLine("------------------------");
    }
}

class SinglyLinkedList
{
    private StudentNode? head;
    
    public void AddAtBegining(StudentNode student)
    {
        student.Next = head;
        head = student;
    }

    public void AddAtEnd(StudentNode student)
    {
        if(head == null)
        {
            head = student;
            return;
        }
        StudentNode? temp = head;
        while(temp.Next != null) temp = temp.Next;

        temp.Next = student;
    }

    public void AddAtPosition(StudentNode student, int position)
    {
        int curr = 1;
        if(position == 1)
        {
            student.Next = head;
            head = student;
            return;
        }
        StudentNode? temp = head;
        while(curr < position - 1)
        {
            temp = temp?.Next;
            curr++;
        }
        student.Next = temp?.Next;
        temp?.Next = student;
    }

    public void DeleteByRollNo(int RollNo)
    {
        if(head == null) return;
        if(head.RollNo == RollNo)
        {
            head = head?.Next;
            return;
        }

        StudentNode temp = head;
        while(temp.Next != null)
        {
            if(temp.Next.RollNo == RollNo)
            {
                temp.Next = temp.Next.Next;
                return;
            }
            temp = temp.Next;
        }
    }

    public bool SearchByRollNo(int RollNo)
    {
        StudentNode? temp = head;
        while(temp != null)
        {
            if(temp.RollNo == RollNo) return true;
            temp = temp.Next;
        }
        return false;
    }

    public void DisplayAllStudentRecords()
    {
        StudentNode? temp = head;

        while(temp != null)
        {
            temp.DisplayDetails();
            temp = temp.Next;
        }
    }

    public void UpdateGrades(int RollNo, double Grades)
    {
        if(head == null) return;
        if(head.RollNo == RollNo)
        {
            head.Grade = Grades;
            return;
        }
        StudentNode? temp = head.Next;

        while(temp != null)
        {
            if(temp.RollNo == RollNo)
            {
                temp.Grade = Grades;
                return;
            }
            temp = temp.Next;
        }
    }
}