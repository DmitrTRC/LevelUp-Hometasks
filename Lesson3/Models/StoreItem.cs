namespace Lesson3.Models;

public class StoreItem
{
    protected static int GlobalId{ get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public string Brand { get; set; }
    public double Price { get; set; }


    protected StoreItem() : this("Unknown", "Unknown", 0, "Noname")
    {
        GlobalId++;
        Console.WriteLine($"StoreItem new ID is: {GlobalId}");
    }

    private StoreItem(string name, string description, double price, string brand)
    {
        Name = name;
        Description = description;
        Price = price;
        Brand = brand;
    }


    public override string ToString()
    {
        return $"{Name} - {Description} - {Price}";
    }
}