using System;

namespace LinkedList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				Console.Clear();
				Console.WriteLine("Linked List Demos:\n1-Inventory 2-Library 3-RoundRobin 4-Social 5-UndoRedo 6-Ticket 7-Exit");
				var c = Console.ReadLine(); if(string.IsNullOrWhiteSpace(c)) continue; if(c=="7") break;
				switch(c)
				{
					case "1": InventoryManagementSystem.Run(); break;
					case "2": LibraryManagementSystem.Run(); break;
					case "3": RoundRobinScheduler.Run(); break;
					case "4": SocialConnections.Run(); break;
					case "5": UndoRedoEditor.Run(); break;
					case "6": TicketReservation.Run(); break;
					default: Console.WriteLine("Unknown"); break;
				}
				Console.WriteLine("Returned to menu. Press Enter..."); Console.ReadLine();
			}
		}
	}
}
