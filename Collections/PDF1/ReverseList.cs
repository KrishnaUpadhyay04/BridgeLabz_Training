using System.Collections;

class ReverseList()
{
    public void ReverseArrayList(ref ArrayList arr)
    {
        int start = 0, end = arr.Count - 1;

        while(start < end)
        {
            object temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
        }
    }

    public LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> Result = new();

        foreach(int num in list)
        {
            Result.AddFirst(num);
        }

        return Result;
    }
}