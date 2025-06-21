using System;
using System.Collections.Generic;
using ProductFiltering.Data;
using ProductFiltering.Models;
using ProductFiltering.Services;
using ProductFiltering.Utils;

namespace ProductFilteringLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ProductData.GetSampleProducts();
            int choice;

            do
            {
                Console.WriteLine("\n=== PRODUCT MANAGEMENT MENU ===");
                Console.WriteLine("1. View product list");
                Console.WriteLine("2. Filter products by category + price + inventory");
                Console.WriteLine("3. Group by category and count");
                Console.WriteLine("4. Calculate total inventory value");
                Console.WriteLine("5. Top 3 most expensive products");
                Console.WriteLine("0. Exit");

                choice = InputHelper.ReadInt("Select function: ");
                

                switch (choice)
                {
                    case 1:
                        ShowAllProducts(products);
                        break;

                    case 2:
                        string category = InputHelper.ReadString("Enter product category to filter: ");

                        decimal minPrice = InputHelper.ReadDecimal("Minimum price: ");

                        decimal maxPrice = InputHelper.ReadDecimal("Maximum price: ");

                        var filtered = ProductService.FilterProducts(products, category, minPrice, maxPrice);
                        ShowAllProducts(filtered);
                        break;

                    case 3:
                        ProductService.GroupAndCountByCategory(products);
                        break;

                    case 4:
                        var total = ProductService.CalculateTotalInventoryValue(products);
                        Console.WriteLine($"\nTotal inventory value: {total:#,##0} VND");
                        break;

                    case 5:
                        ProductService.ShowTopThreeMostExpensive(products);
                        break;

                    case 0:
                        Console.WriteLine("Đang thoát chương trình...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            } while (choice != 0);
        }

        static void ShowAllProducts(List<Product> products)
        {
            Console.WriteLine("\n=== PRODUCT INVENTORY ===");
            foreach (var p in products)
            {
                Console.WriteLine($"Name: {p.Name} | Category: {p.Category} | Price: {p.Price:#,##0} | In Stock: {p.InStock}");
            }
        }
    }
}