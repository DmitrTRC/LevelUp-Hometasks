namespace Lesson3.Models;

public class Equipment : ShopStoreItem
{
    public string Model { get; set; } = "Unknown";
    public string Type { get; set; } = "Unknown"; //TODO: Move to Interface
    
}