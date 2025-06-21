using ProductFiltering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFiltering.Services
{
    public static class ProductService
    {
        // 1. Lọc sản phẩm theo loại, khoảng giá, còn hàng
        public static List<Product> FilterProducts(List<Product> products, string category, decimal minPrice, decimal maxPrice)
        {
            var listResult = products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)
                                                 && p.Price >= minPrice
                                                 && p.Price <= maxPrice
                                                 && p.InStock >0)
                                     .ToList();

            return listResult;

        }

        // 2. Gom nhóm theo loại và đếm số lượng
        public static void GroupAndCountByCategory(List<Product> products)
        {
            var grouped = GetProductCountByCategory(products);

            Console.WriteLine("\n--- Number Of Products By Category ---");
            foreach (var item in grouped)
            {
                Console.WriteLine($"{item.Category}: {item.Count} product(s)");
            }
        }

        public static List<(string Category, int Count)> GetProductCountByCategory(List<Product> products)
        {
            var finalResult = products.GroupBy(p => p.Category)
                                      .Select(g => (Category: g.Key, Count: g.Count()))
                                      .ToList();
            return finalResult;
        }

        // 3. Tính tổng tiền hàng còn tồn kho
        public static decimal CalculateTotalInventoryValue(List<Product> products) 
        {
            var finalResult = products.Sum(p => p.Price * p.InStock);

            return finalResult;
        }

        // 4. Liệt kê Top 3 sản phẩm có giá cao nhất
        public static void ShowTopThreeMostExpensive(List<Product> products)
        {
            var top3 = GetTopThreeMostExpensive(products);

            Console.WriteLine("--- Top 3 Highest-Priced Products ---");
            foreach (var p in top3)
            {
                Console.WriteLine($"{p.Name} - {p.Category} - {p.Price:#,##0} VND");                
            }
        }

        public static List<Product> GetTopThreeMostExpensive(List<Product> products)
        {
            var top3 = products.OrderByDescending(p => p.Price)
                               .Take(3)
                               .ToList();

            return top3;
        }
    }
}
