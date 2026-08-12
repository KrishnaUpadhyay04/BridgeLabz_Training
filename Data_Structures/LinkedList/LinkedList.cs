// namespace LinkedList;


// // Singly Linked List
// class Node
// {
//     public int Data;
//     public Node? Next;

//     public Node(int Data)
//     {
//         this.Data = Data;
//         Next = null;
//     }
// }

// class LinkedList
// {
//     private Node? head;

//     public void InsertAtHead(int data)
//     {
//         Node newHead = new Node(data);
//         newHead.Next = head;
//         head = newHead;
//     }

//     public void InsertAtEnd(int Data)
//     {
//         Node node = new(Data);
//         if(head == null)
//         {
//             head = node;
//         }
//         else
//         {
//             Node curr = head;
//             while(curr.Next != null)
//             {
//                 curr = curr.Next;
//             }
//             curr.Next = node;
//         }
//     }

//     public void InsertFromPos(int data, int position)
//     {
//         int curr = 1;
//         Node? temp = head;

//         while(curr < position - 1)
//         {
//             temp = temp?.Next;
//             curr++;
//         }
//         Node node = new(data);
//         node.Next = temp?.Next;
//         temp?.Next = node;
//     }

//     public bool Contains(int data)
//     {
//         if(head == null) return false;

//         Node temp = head;

//         while(temp != null)
//         {
//             if(temp.Data == data) return true;
//         }

//         return false;
//     }

//     public void DeleteFromPos(int position)
//     {
//         int curr = 1;
//         Node? temp = head;

//         while(curr < position - 1)
//         {
//             temp = temp?.Next;
//             curr++;
//         }
//         temp?.Next = temp?.Next?.Next;

//     }
// }