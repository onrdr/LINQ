using WorkingWithProductDatabase.LinqLibrary;

class Product 
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; } 
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public override string ToString()
    {
        return $"Category Id: {CategoryId}, \tName: {ProductName}, \tQuantity Per Unit: {QuantityPerUnit}, \tUnit Price: {UnitPrice}, \tUnits In Stock: {UnitsInStock}";
    }
}
