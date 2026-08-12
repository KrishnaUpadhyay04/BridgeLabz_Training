using System;
using System.Collections.Generic;

namespace LinkedList
{
    class ItemNode
    {
        public string ItemName;
        public string ItemID;
        public int Quantity;
        public double Price;
        public ItemNode? Next;

        public ItemNode(string name, string id, int qty, double price)
        {
            ItemName = name; ItemID = id; Quantity = qty; Price = price; Next = null;
        }
    }

    class InventoryList
    {
        private ItemNode? head;

        public void AddAtBeginning(ItemNode node)
        {
            node.Next = head;
            head = node;
        }

        public void AddAtEnd(ItemNode node)
        {
            if (head == null) { head = node; return; }
            var t = head; while (t.Next != null) t = t.Next; t.Next = node;
        }

        public void AddAtPosition(ItemNode node, int pos)
        {
            if (pos <= 1) { AddAtBeginning(node); return; }
            var curr = head; int i = 1;
            while (curr != null && i < pos - 1) { curr = curr.Next; i++; }
            node.Next = curr?.Next; if (curr != null) curr.Next = node; else head = node;
        }

        public void RemoveById(string id)
        {
            if (head == null) return;
            if (head.ItemID == id) { head = head.Next; return; }
            var prev = head; var cur = head.Next;
            while (cur != null)
            {
                if (cur.ItemID == id) { prev.Next = cur.Next; return; }
                prev = cur; cur = cur.Next;
            }
        }

        public bool UpdateQuantity(string id, int newQty)
        {
            var cur = head; while (cur != null)
            {
                if (cur.ItemID == id) { cur.Quantity = newQty; return true; }
                cur = cur.Next;
            }
            return false;
        }

        public ItemNode? SearchById(string id)
        {
            var cur = head; while (cur != null) { if (cur.ItemID == id) return cur; cur = cur.Next; }
            return null;
        }

        public ItemNode? SearchByName(string name)
        {
            var cur = head; while (cur != null) { if (cur.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase)) return cur; cur = cur.Next; }
            return null;
        }

        public double TotalInventoryValue()
        {
            double total = 0; var cur = head; while (cur != null) { total += cur.Price * cur.Quantity; cur = cur.Next; } return total;
        }

        public void DisplayAll()
        {
            var cur = head; while (cur != null)
            {
                Console.WriteLine($"ID:{cur.ItemID} | {cur.ItemName} | Qty:{cur.Quantity} | Price:{cur.Price}");
                cur = cur.Next;
            }
        }

        public void SortByName(bool ascending = true)
        {
            var list = ToList(); list.Sort((a,b)=> string.Compare(a.ItemName,b.ItemName, StringComparison.OrdinalIgnoreCase) * (ascending?1:-1)); FromList(list);
        }

        public void SortByPrice(bool ascending = true)
        {
            var list = ToList(); list.Sort((a,b)=> (a.Price.CompareTo(b.Price)) * (ascending?1:-1)); FromList(list);
        }

        private List<ItemNode> ToList()
        {
            var outList = new List<ItemNode>(); var cur = head; while (cur != null) { outList.Add(cur); cur = cur.Next; }
            return outList;
        }

        private void FromList(List<ItemNode> nodes)
        {
            head = null; ItemNode? tail = null;
            foreach(var n in nodes)
            {
                n.Next = null;
                if (head == null) { head = tail = n; }
                else { tail!.Next = n; tail = n; }
            }
        }
    }

    public static class InventoryManagementSystem
    {
        public static void Run()
        {
            var inv = new InventoryList();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Inventory Menu: 1-Add 2-Remove 3-UpdateQty 4-Search 5-TotalValue 6-Display 7-Sort 8-Exit");
                var c = Console.ReadLine(); if (string.IsNullOrWhiteSpace(c)) continue;
                if (c=="8") break;
                switch(c)
                {
                    case "1":
                        Console.Write("Name: "); var name=Console.ReadLine() ?? "Item";
                        Console.Write("ID: "); var id=Console.ReadLine() ?? Guid.NewGuid().ToString();
                        Console.Write("Qty: "); var q=int.TryParse(Console.ReadLine(), out var qq)?qq:1;
                        Console.Write("Price: "); var p=double.TryParse(Console.ReadLine(), out var pp)?pp:0.0;
                        Console.Write("Pos (b=begin,e=end,num): "); var pos=Console.ReadLine();
                        var node = new ItemNode(name,id,q,p);
                        if (pos=="b") inv.AddAtBeginning(node);
                        else if (pos=="e") inv.AddAtEnd(node);
                        else if (int.TryParse(pos, out var pv)) inv.AddAtPosition(node,pv);
                        else inv.AddAtEnd(node);
                        break;
                    case "2": Console.Write("ID to remove: "); inv.RemoveById(Console.ReadLine() ?? ""); break;
                    case "3": Console.Write("ID: "); var uid=Console.ReadLine() ?? ""; Console.Write("New Qty: "); var nq=int.TryParse(Console.ReadLine(), out var nqq)?nqq:0; inv.UpdateQuantity(uid,nq); break;
                    case "4": Console.Write("Search by (id/name): "); var mode=Console.ReadLine(); if (mode=="id") { Console.Write("ID: "); var r=inv.SearchById(Console.ReadLine()??""); if (r!=null) Console.WriteLine($"Found: {r.ItemName}"); else Console.WriteLine("Not found"); } else { Console.Write("Name: "); var r=inv.SearchByName(Console.ReadLine()??""); if (r!=null) Console.WriteLine($"Found: {r.ItemID}"); else Console.WriteLine("Not found"); } break;
                    case "5": Console.WriteLine("Total value: " + inv.TotalInventoryValue()); break;
                    case "6": inv.DisplayAll(); break;
                    case "7": Console.Write("Sort by (name/price): "); var s=Console.ReadLine(); Console.Write("asc? (y/n): "); var asc = (Console.ReadLine()??"y")=="y"; if (s=="name") inv.SortByName(asc); else inv.SortByPrice(asc); break;
                }
                Console.WriteLine("Press Enter to continue..."); Console.ReadLine();
            }
        }
    }
}
 