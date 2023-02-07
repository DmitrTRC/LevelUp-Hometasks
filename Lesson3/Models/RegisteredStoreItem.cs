namespace Lesson3.Models;

public class RegisteredStoreItem : StoreItem, IQuantity, IStateStock
{
    public int Quantity { get; set; }
    
    public QuantityType QuantityType { get; set; } = QuantityType.Unit;

    public State State { get; set; }
}