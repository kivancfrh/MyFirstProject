using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> 
            { 
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=1000, UnitInStock=5},
                new Product{ProductId=1, CategoryId=1, ProductName="asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=8000, UnitInStock=3},
                new Product{ProductId=1, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=6000, UnitInStock=2},
                new Product{ProductId=1, CategoryId=2, ProductName="Samsung Tel", QuantityPerUnit="4 GB RAM", UnitPrice=5000, UnitInStock=15},
                new Product{ProductId=1, CategoryId=2, ProductName="Apple Tel", QuantityPerUnit="4 GB RAM", UnitPrice=8000, UnitInStock=0}
            };

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList<Product>();

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; } 
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
