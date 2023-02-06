namespace Lesson3.Models;

public class Snack : Food, IHasShelfLife
{
    public DateTime ExpirationDate { get; set; }
}