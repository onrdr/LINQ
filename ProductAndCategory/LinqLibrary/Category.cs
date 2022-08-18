using WorkingWithProductDatabase.LinqLibrary;

class Category 
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }

    public override string? ToString()
    {
        return $"Category Name: {CategoryName} \tCategoryId: {CategoryId}";
    }
}