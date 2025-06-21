using Xunit;
using ProductFiltering.Models;
using ProductFiltering.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProductFiltering.Tests
{
    public class ProductServiceTests
    {
        private List<Product> GetSampleData()
        {
            var dataDemo = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics", Price = 1500, InStock = 5 },
                new Product { Name = "Phone", Category = "Electronics", Price = 1000, InStock = 0 },
                new Product { Name = "Shoes", Category = "Fashion", Price = 100, InStock = 10 },
                new Product { Name = "Bag", Category = "Fashion", Price = 80, InStock = 3 }
            };

            return dataDemo;
        }

        [Fact]
        public void FilterProducts_ShouldReturnCorrectResults()
        {
            // Arrange
            var data = GetSampleData();

            // Act
            var result = ProductService.FilterProducts(data, "Fashion", 50, 150);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.All(result, p => Assert.Equal("Fashion", p.Category));
        }

        [Fact]
        public void CalculateTotalInventoryValue_ShouldReturnCorrectSum()
        {
            // Arrange
            var data = GetSampleData();

            // Act
            var total = ProductService.CalculateTotalInventoryValue(data);

            // Assert
            Assert.Equal(5 * 1500 + 10 * 100 + 3 * 80, total);
        }

        [Fact]
        public void ShowTop3MostExpensive_ShouldReturnTop3Descending()
        {
            // Arrange
            var data = GetSampleData();

            // Act
            var top3 = ProductService.GetTopThreeMostExpensive(data);

            // Assert
            Assert.Equal(3, top3.Count);
            Assert.Equal("Laptop", top3[0].Name);
            Assert.Equal("Phone", top3[1].Name);
            Assert.Equal("Shoes", top3[2].Name);

        }

        [Fact]
        public void GetProductCountByCategory_ReturnsCorrectCounts()
        {
            // Arrange
            var data = GetSampleData();

            // Act
            var grouped = ProductService.GetProductCountByCategory(data);

            // Asset
            Assert.Equal("Electronics", grouped[0].Category);
            Assert.Equal(2, grouped[0].Count);

        }
    }
}
