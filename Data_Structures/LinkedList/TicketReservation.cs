using System;
using System.Collections.Generic;

namespace LinkedList
{
    class BookingNode
    {
        public string BookingID; public string Name; public int SeatNo; public BookingNode? Next;
        public BookingNode(string id,string name,int seat){ BookingID=id; Name=name; SeatNo=seat; Next=null; }
    }

    class CircularBookingList
    {
        private BookingNode? head, tail;
        public void AddBooking(BookingNode b){ if(head==null){ head=tail=b; b.Next=head; } else { tail!.Next=b; b.Next=head; tail=b; } }
        public void RemoveById(string id){ if(head==null) return; if(head.BookingID==id){ if(head==tail){ head=tail=null; } else { head=head.Next; tail!.Next=head; } return; } var cur=head; while(cur!.Next!=head){ if(cur.Next!.BookingID==id){ if(cur.Next==tail) tail=cur; cur.Next=cur.Next.Next; return; } cur=cur.Next; } }
        public BookingNode? FindBySeat(int seat){ if(head==null) return null; var cur=head; do{ if(cur.SeatNo==seat) return cur; cur=cur.Next!; } while(cur!=head); return null; }
        public void Display(){ if(head==null){ Console.WriteLine("No bookings"); return; } var cur=head; do{ Console.WriteLine($"{cur.BookingID}: {cur.Name} Seat:{cur.SeatNo}"); cur=cur.Next!; } while(cur!=head); }
    }

    public static class TicketReservation
    {
        public static void Run()
        {
            var lst = new CircularBookingList();
            while(true)
            {
                Console.Clear(); Console.WriteLine("Tickets: 1-Book 2-Cancel 3-FindSeat 4-Display 5-Exit"); var c=Console.ReadLine(); if(string.IsNullOrWhiteSpace(c)) continue; if(c=="5") break;
                switch(c)
                {
                    case "1": Console.Write("Name: "); var name=Console.ReadLine()??""; Console.Write("SeatNo: "); var seat=int.TryParse(Console.ReadLine(), out var sn)?sn:0; var id=Guid.NewGuid().ToString(); lst.AddBooking(new BookingNode(id,name,seat)); Console.WriteLine($"Booked {id}"); break;
                    case "2": Console.Write("Booking ID: "); lst.RemoveById(Console.ReadLine()??""); break;
                    case "3": Console.Write("Seat: "); var s=int.TryParse(Console.ReadLine(), out var ss)?ss:0; var b=lst.FindBySeat(s); Console.WriteLine(b==null?"Not found":$"Found {b.BookingID} - {b.Name}"); break;
                    case "4": lst.Display(); break;
                }
                Console.WriteLine("Press Enter..."); Console.ReadLine();
            }
        }
    }
}
