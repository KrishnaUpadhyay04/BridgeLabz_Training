using System;
using System.Collections.Generic;

namespace LinkedList
{
    class StateNode
    {
        public string Content; public StateNode? Prev, Next;
        public StateNode(string c){ Content=c; Prev=Next=null; }
    }

    class UndoRedoList
    {
        private StateNode? head, tail, current; private int limit=10; public UndoRedoList(int limit=10){ this.limit=limit; }
        public void AddState(string content){ var node=new StateNode(content); if(head==null){ head=tail=current=node; return; } // append after current and drop redo
            if(current!=null && current.Next!=null){ // drop nodes after current
                var p=current.Next; while(p!=null){ var nx=p.Next; p.Prev = p.Next = null; p=nx; }
                current.Next=null; tail=current;
            }
            tail!.Next=node; node.Prev=tail; tail=node; current=node;
            // enforce limit by removing from head
            while(Count()>limit){ head = head!.Next; if(head!=null) head.Prev=null; }
        }
        public string? Undo(){ if(current?.Prev==null) return current?.Content; current=current?.Prev; return current?.Content; }
        public string? Redo(){ if(current?.Next==null) return current?.Content; current=current?.Next; return current?.Content; }
        public string? Current() => current?.Content;
        public int Count(){ int c=0; var p=head; while(p!=null){ c++; p=p.Next; } return c; }
    }

    public static class UndoRedoEditor
    {
        public static void Run()
        {
            var history = new UndoRedoList(10);
            while(true)
            {
                Console.Clear(); Console.WriteLine("Editor: 1-Type 2-Undo 3-Redo 4-Show 5-Exit"); var c=Console.ReadLine(); if(string.IsNullOrWhiteSpace(c)) continue; if(c=="5") break;
                switch(c)
                {
                    case "1": Console.Write("Text: "); var txt=Console.ReadLine()??""; history.AddState(txt); break;
                    case "2": Console.WriteLine("After undo: " + history.Undo()); break;
                    case "3": Console.WriteLine("After redo: " + history.Redo()); break;
                    case "4": Console.WriteLine("Current: " + history.Current()); break;
                }
                Console.WriteLine("Press Enter..."); Console.ReadLine();
            }
        }
    }
}
