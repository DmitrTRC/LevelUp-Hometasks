namespace Lesson3.Models;

public interface IHasShelfLife
{
    DateTime ExpirationDate { get; set; }
}