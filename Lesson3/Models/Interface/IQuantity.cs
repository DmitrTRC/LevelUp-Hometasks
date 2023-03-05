namespace Lesson3.Models.Interface;

public enum QuantityType
{
    Unit,

    Kilogram,
    Gram,
    
    Liter,
    Milliliter,

    Meter,
    Centimeter,
    Millimeter
}

public interface IQuantity
{
    public int Quantity { get; set; }
    public QuantityType QuantityType { get; set; }
}