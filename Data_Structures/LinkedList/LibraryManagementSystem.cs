using System;
using System.Collections.Generic;

namespace LinkedList
{
    class BookNode
    {
        public string Title;
        public string Author;
        public string Genre;
        public string BookID;
        public bool Available;
        public BookNode? Prev, Next;
        public BookNode(string title,string author,string genre,string id)
        {
            Title=title; Author=author; Genre=genre; BookID=id; Available=true; Prev=Next=null;
        }
    }

    class LibraryList
    {
        private BookNode? head, tail;
        public void AddAtBeginning(BookNode b){ if(head==null){ head=tail=b; } else { b.Next=head; head.Prev=b; head=b; } }
        public void AddAtEnd(BookNode b){ if(tail==null){ head=tail=b; } else { tail.Next=b; b.Prev=tail; tail=b; } }
        public void AddAtPosition(BookNode b, int pos){ if(pos<=1){ AddAtBeginning(b); return;} var cur=head; int i=1; while(cur!=null && i<pos-1){ cur=cur.Next; i++; } if(cur==null){ AddAtEnd(b); return; } b.Next=cur.Next; b.Prev=cur; cur.Next=b; if(b.Next==null) tail=b; else b.Next.Prev=b; }
        public void RemoveById(string id){ if(head==null) return; if(head.BookID==id){ head=head.Next; if(head!=null) head.Prev=null; else tail=null; return;} var cur=head; while(cur!=null){ if(cur.BookID==id){ cur.Prev!.Next = cur.Next; cur.Next?.Prev = cur.Prev; if(cur==tail) tail=cur.Prev; return;} cur=cur.Next; } }
        public BookNode? SearchByTitle(string title){ var cur=head; while(cur!=null){ if(cur.Title.Equals(title,StringComparison.OrdinalIgnoreCase)) return cur; cur=cur.Next;} return null; }
        public BookNode? SearchByAuthor(string author){ var cur=head; while(cur!=null){ if(cur.Author.Equals(author,StringComparison.OrdinalIgnoreCase)) return cur; cur=cur.Next;} return null; }
        public void UpdateAvailability(string id,bool avail){ var n=SearchById(id); if(n!=null) n.Available=avail; }
        private BookNode? SearchById(string id){ var cur=head; while(cur!=null){ if(cur.BookID==id) return cur; cur=cur.Next; } return null; }
        public void DisplayForward(){ var cur=head; while(cur!=null){ Console.WriteLine($"{cur.BookID}: {cur.Title} by {cur.Author} ({cur.Genre}) - {(cur.Available?"Available":"Unavailable")}"); cur=cur.Next;} }
        public void DisplayReverse(){ var cur=tail; while(cur!=null){ Console.WriteLine($"{cur.BookID}: {cur.Title} by {cur.Author} ({cur.Genre}) - {(cur.Available?"Available":"Unavailable")}"); cur=cur.Prev;} }
        public int Count(){ int c=0; var cur=head; while(cur!=null){ c++; cur=cur.Next;} return c; }
    }

    public static class LibraryManagementSystem
    {
        public static void Run()
        {
            var lib = new LibraryList();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Library Menu: 1-Add 2-Remove 3-Search 4-UpdateAvailability 5-DisplayForward 6-DisplayReverse 7-Count 8-Exit");
                var c=Console.ReadLine(); if(string.IsNullOrWhiteSpace(c)) continue; if(c=="8") break;
                switch(c)
                {
                    case "1": Console.Write("Title: "); var t=Console.ReadLine()??""; Console.Write("Author: "); var a=Console.ReadLine()??""; Console.Write("Genre: "); var g=Console.ReadLine()??""; Console.Write("ID: "); var id=Console.ReadLine()??Guid.NewGuid().ToString(); Console.Write("Pos (b/e/num): "); var pos=Console.ReadLine(); var node=new BookNode(t,a,g,id); if(pos=="b") lib.AddAtBeginning(node); else if(pos=="e") lib.AddAtEnd(node); else if(int.TryParse(pos,out var pv)) lib.AddAtPosition(node,pv); else lib.AddAtEnd(node); break;
                    case "2": Console.Write("ID to remove: "); lib.RemoveById(Console.ReadLine()??""); break;
                    case "3": Console.Write("Search by (title/author): "); var m=Console.ReadLine(); if(m=="title"){ Console.Write("Title: "); var r=lib.SearchByTitle(Console.ReadLine()??""); Console.WriteLine(r==null?"Not found":"Found"); } else { Console.Write("Author: "); var r=lib.SearchByAuthor(Console.ReadLine()??""); Console.WriteLine(r==null?"Not found":"Found"); } break;
                    case "4": Console.Write("ID: "); var iid=Console.ReadLine()??""; Console.Write("Available (y/n): "); var av=(Console.ReadLine()??"y")=="y"; lib.UpdateAvailability(iid,av); break;
                    case "5": lib.DisplayForward(); break;
                    case "6": lib.DisplayReverse(); break;
                    case "7": Console.WriteLine("Count: " + lib.Count()); break;
                }
                Console.WriteLine("Press Enter..."); Console.ReadLine();
            }
        }
    }
}
