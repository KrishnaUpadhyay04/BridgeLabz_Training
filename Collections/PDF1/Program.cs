using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Collections Exercises Menu");
			Console.WriteLine("1. Reverse a List (ArrayList & LinkedList)");
			Console.WriteLine("2. Frequency of Elements");
			Console.WriteLine("3. Rotate Elements in a List");
			Console.WriteLine("4. Remove Duplicates Preserving Order");
			Console.WriteLine("5. Nth Element from End (LinkedList)");
			Console.WriteLine("6. Set: Check Equality");
			Console.WriteLine("7. Set: Union and Intersection");
			Console.WriteLine("8. Set: Symmetric Difference");
			Console.WriteLine("9. Set -> Sorted List");
			Console.WriteLine("10. Set: Is Subset");
			Console.WriteLine("11. Queue: Reverse Queue");
			Console.WriteLine("12. Queue: Generate Binary Numbers");
			Console.WriteLine("13. Queue: Hospital Triage (PriorityQueue)");
			Console.WriteLine("14. Map: Word Frequency from Text");
			Console.WriteLine("15. Map: Invert a Map");
			Console.WriteLine("16. Insurance Policy Management (store/retrieve)");
			Console.WriteLine("17. Voting System");
			Console.WriteLine("18. Shopping Cart");
			Console.WriteLine("19. Banking System (queue withdrawals)");
			Console.WriteLine("20. Exit");
			Console.Write("Choose option: ");
			var opt = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(opt)) continue;

			switch (opt.Trim())
			{
				case "1": ReverseListDemo.Run(); break;
				case "2": FrequencyCounterDemo.Run(); break;
				case "3": RotateListDemo.Run(); break;
				case "4": RemoveDuplicatesDemo.Run(); break;
				case "5": NthFromEndDemo.Run(); break;
				case "6": SetEqualityDemo.Run(); break;
				case "7": SetUnionIntersectionDemo.Run(); break;
				case "8": SymmetricDifferenceDemo.Run(); break;
				case "9": SetToSortedListDemo.Run(); break;
				case "10": IsSubsetDemo.Run(); break;
				case "11": ReverseQueueDemo.Run(); break;
				case "12": BinaryNumbersDemo.Run(); break;
				case "13": HospitalTriageDemo.Run(); break;
				case "14": WordFrequencyFileDemo.Run(); break;
				case "15": InvertMapDemo.Run(); break;
				case "16": InsurancePoliciesDemo.Run(); break;
				case "17": VotingSystemDemo.Run(); break;
				case "18": ShoppingCartDemo.Run(); break;
				case "19": BankingSystemDemo.Run(); break;
				case "20": return;
				default: Console.WriteLine("Invalid option"); break;
			}

			Console.WriteLine("\nPress Enter to return to menu...");
			Console.ReadLine();
		}
	}
}

