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

        // 3. Tính tổng tiền hàng còn tồn kho

        // 4. Liệt kê Top 3 sản phẩm có giá cao nhất


    }
}
