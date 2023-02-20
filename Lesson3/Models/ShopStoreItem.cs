using Lesson3.Models.Interface;

namespace Lesson3.Models;

public class ShopStoreItem : StoreItem, IQuantity, IStateStock, IHasDiscount
{
    private int Id { get; set; } = GlobalId;
    public int Quantity { get; set; }

    public QuantityType QuantityType { get; set; } = QuantityType.Unit;

    public State State { get; set; }

    public bool HasDiscount { get; set; }
    public int Discount { get; set; } // in percent
    
    //Override the ToString method to display the item's properties
    public override string ToString()
    {
        return $"{Id} - {Name} - {Description} - {Price} - {Quantity} - {State} - {HasDiscount} - {Discount}";
    }
    
    
    
}