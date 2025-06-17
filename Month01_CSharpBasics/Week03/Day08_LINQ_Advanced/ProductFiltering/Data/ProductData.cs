using ProductFiltering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFiltering.Data
{
    public static class ProductData
    {
        public static List<Product> GetSampleProducts()
        {
            return new List<Product> {
                new Product { Name = "iPhone 14", Category = "Electronics", Price = 21000000, InStock = 5 },
                new Product { Name = "Dell Laptop", Category = "Electronics", Price = 18000000, InStock = 3 },
                new Product { Name = "LG Washing Machine", Category = "Home Appliances", Price = 9500000, InStock = 2 },
                new Product { Name = "Samsung Refrigerator", Category = "Home Appliances", Price = 12500000, InStock = 0 },
                new Product { Name = "Men's T-Shirt", Category = "Fashion", Price = 250000, InStock = 12 },
                new Product { Name = "Basic C# Book", Category = "Books", Price = 150000, InStock = 7 },
                new Product { Name = "Sony 55\" TV", Category = "Electronics", Price = 15500000, InStock = 4 },
                new Product { Name = "Rice Cooker", Category = "Home Appliances", Price = 800000, InStock = 10 },
                new Product { Name = "Sports Shoes", Category = "Fashion", Price = 1200000, InStock = 6 },
                new Product { Name = "LINQ Learning Book", Category = "Books", Price = 220000, InStock = 5 }
            };
        }
    }
}
