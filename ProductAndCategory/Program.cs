using WorkingWithProductDatabase.LinqLibrary;

var products = ListManager.GetProducts();
var categories = ListManager.GetCategories();

Console.WriteLine("Unit Price and Units In Stock Restrictions");
products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 4)
        .ToList().ForEach(p => Console.WriteLine(p.ToString()));

Console.WriteLine("\nQuantities Starts With 32 or 16");
products.Select(p => p)
        .Where(p => p.QuantityPerUnit.StartsWith("32") || p.QuantityPerUnit.StartsWith("16")) 
        .ToList().ForEach(p => Console.WriteLine(p.ToString()));

Console.WriteLine("\nOrder by Product Name");
products.OrderBy(p => p.ProductName)
        .ToList().ForEach(p => Console.WriteLine(p.ToString()));

Console.WriteLine("\nOrder By Category Id First and then Order By Unit Price");
products.OrderBy(p=> p.CategoryId)
        .ThenByDescending(p => p.UnitPrice) 
        .ToList().ForEach(p => Console.WriteLine(p.ToString()));

Console.WriteLine("\nThe Cheapest and Most Expensive Computer Prices");
Console.Write(products.Where(p => p.CategoryId == 1).Min(p => p.UnitPrice).ToString() + " and " );
Console.Write(products.Where(p => p.CategoryId == 1).Max(p => p.UnitPrice).ToString());



Console.ReadKey();
 