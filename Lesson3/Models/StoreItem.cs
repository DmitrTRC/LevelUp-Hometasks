namespace Lesson3.Models;

public class StoreItem
{
    public int Id { get; set; }
    private string Name { get; set; }
    private string Description { get; set; }
    private double Price { get; set; }


    protected StoreItem() : this("Unknown", "Unknown", 0)
    {
    }

    private StoreItem(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
    }


    public override string ToString()
    {
        return $"{Name} - {Description} - {Price}";
    }
}