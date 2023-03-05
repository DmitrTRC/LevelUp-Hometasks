namespace Lesson3.Models.Interface;

public enum State
{
    InStock,
    OutOfStock,
    OrderOnly,
    Discontinued
}

public interface IStateStock
{
    public State State { get; set; }

    public bool IsInStock => State == State.InStock;

    public bool IsOutOfStock => State == State.OutOfStock;

    public bool IsOrderOnly => State == State.OrderOnly;

    public bool IsDiscontinued => State == State.Discontinued;

    public bool IsAvailable => State == State.InStock || State == State.OrderOnly;

    public bool IsUnavailable => State == State.OutOfStock || State == State.Discontinued;

    public string StateToString => State switch
    {
        State.InStock => "In Stock",
        State.OutOfStock => "Out of Stock",
        State.OrderOnly => "Order Only",
        State.Discontinued => "Discontinued",
        _ => "Unknown"
    };
}