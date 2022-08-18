
using System.Collections.Generic;

namespace WorkingWithProductDatabase.LinqLibrary
{
    static class ListManager
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new()
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "MacBook Air", QuantityPerUnit = "32 GB RAM", UnitPrice = 30000, UnitsInStock = 6},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus VivoBook", QuantityPerUnit = "8 GB RAM", UnitPrice =15000, UnitsInStock = 12},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "Samsung AU46", QuantityPerUnit = "16 GB RAM", UnitPrice = 20000, UnitsInStock = 4},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Samsung Galaxy", QuantityPerUnit = "4 GB RAM", UnitPrice = 18000, UnitsInStock = 17},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "IPhone 13", QuantityPerUnit = "4 GB RAM", UnitPrice = 24000, UnitsInStock = 0},
            };
            return products;
        }

        public static List<Category> GetCategories()
        {
            List<Category> categories = new()
            {
                new Category{CategoryId = 1, CategoryName = "Computer"},
                new Category{CategoryId = 2, CategoryName = "Phone"},
            };

            return categories;
        }
    }
}
