namespace Lesson3.Models.Interface;

public interface IHasDiscount
{
    public bool HasDiscount { get; set; }
    public int Discount { get; set; } // in percent

    //Setter for Discount ( 0 -100 )
    public void SetDiscount(int discount)
    {
        if (discount >= 0 && discount <= 100)
        {
            Discount = discount;
        }
    }
}