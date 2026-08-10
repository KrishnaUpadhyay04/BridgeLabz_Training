using System;
using System.Collections.Generic;
using System.Linq;

public static class ShoppingCartDemo
{
    public static void Run()
    {
        var prices = new Dictionary<string,double>{{"apple",1.2},{"banana",0.5},{"milk",2.0}};
        var cart = new LinkedList<(string item,double price)>();
        cart.AddLast(("apple",1.2)); cart.AddLast(("milk",2.0)); cart.AddLast(("banana",0.5));
        Console.WriteLine("Cart (insertion order):");
        foreach(var it in cart) Console.WriteLine($"{it.item}: {it.price}");
        var sorted = cart.OrderBy(x=>x.price).ToList();
        Console.WriteLine("Cart sorted by price:"); foreach(var it in sorted) Console.WriteLine($"{it.item}: {it.price}");
    }
}
