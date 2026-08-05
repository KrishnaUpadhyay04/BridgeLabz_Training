using System;
using System.Collections.Generic;

namespace ECommercePlatform
{
    interface ITaxable
    {
        double CalculateTax();

        string GetTaxDetails();
    }

    abstract class Product
    {
        public string ProductId { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        private static List<Product> products = new();

        public Product()
        {
            ProductId = "";
            Name = "Unknown";
            Price = 0.0;
            products.Add(this);
        }

        public Product(string ProductId, string Name, double Price)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Price = Price;
            products.Add(this);
        }

        public abstract double CalculateDiscount();

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Id : {ProductId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Price      : {Price}");
            if (this is ITaxable taxable) Console.WriteLine($"{taxable.GetTaxDetails()}");
        }

        public static void DisplayFinalPrice()
        {
            foreach (Product product in products)
            {
                product.DisplayProductDetails();
                Console.WriteLine("----------------------");
                Console.Write($"Product Name: {product.Name} \nFinal Price: {product.FinalPrice()}");
                Console.WriteLine();
            }
        }

        public double FinalPrice()
        {
            if (this is ITaxable taxable) return Price - CalculateDiscount() + taxable.CalculateTax();

            return Price - CalculateDiscount();
        }
    }

    class Electronics : Product, ITaxable
    {
        private double DiscountRate;
        private double TaxRate;

        public Electronics() : base()
        {
            DiscountRate = 0.0;
            TaxRate = 0.0;
        }

        public Electronics(string ProductId, string Name, double Price, double DiscountRate, double TaxRate) : base(ProductId, Name, Price)
        {
            this.DiscountRate = DiscountRate;
            this.TaxRate = TaxRate;
        }

        public override double CalculateDiscount()
        {
            return Price * DiscountRate;
        }

        public double CalculateTax()
        {
            return Price * TaxRate;
        }

        public string GetTaxDetails()
        {
            return $"Tax Rate    : {TaxRate}";
        }
    }

    class Clothing : Product, ITaxable
    {
        private double DiscountRate;
        private double TaxRate;

        public Clothing() : base()
        {
            DiscountRate = 0.0;
            TaxRate = 0.0;
        }

        public Clothing(string ProductId, string Name, double Price, double DiscountRate, double TaxRate) : base(ProductId, Name, Price)
        {
            this.DiscountRate = DiscountRate;
            this.TaxRate = TaxRate;
        }

        public override double CalculateDiscount()
        {
            return Price * DiscountRate;
        }

        public double CalculateTax()
        {
            return Price * TaxRate;
        }

        public string GetTaxDetails()
        {
            return $"Tax Rate    : {TaxRate}";
        }
    }

    class Groceries : Product
    {
        private double DiscountRate;

        public Groceries() : base()
        {
            DiscountRate = 0.0;
        }

        public Groceries(string ProductId, string Name, double Price, double DiscountRate) : base(ProductId, Name, Price)
        {
            this.DiscountRate = DiscountRate;
        }

        public override double CalculateDiscount()
        {
            return Price * DiscountRate;
        }
    }
}
