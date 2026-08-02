using System;
using System.Collections.Generic;

namespace ObjectModeling.ECommerce
{
    class Product
    {
        public string Name { get; }
        public double Price { get; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} - ₹{Price}");
        }
    }

    class Customer
    {
        public string Name { get; }

        private List<Order> orders = new();

        public Customer(string name)
        {
            Name = name;
        }

        // Association
        public void PlaceOrder(Order order)
        {
            if (!orders.Contains(order))
            {
                orders.Add(order);
            }

            Console.WriteLine($"{Name} placed Order #{order.OrderId}");
        }

        public void DisplayOrders()
        {
            Console.WriteLine($"\nOrders placed by {Name}:");

            foreach (Order order in orders)
            {
                Console.WriteLine($"Order #{order.OrderId}");
            }
        }
    }

    class Order
    {
        public int OrderId { get; }

        // Association
        private Customer customer;

        // Aggregation
        private List<Product> products = new();

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"\nOrder #{OrderId}");
            Console.WriteLine($"Customer: {customer.Name}");

            double total = 0;

            Console.WriteLine("\nProducts:");

            foreach (Product product in products)
            {
                product.Display();
                total += product.Price;
            }

            Console.WriteLine($"\nTotal = ₹{total}");
        }
    }
}