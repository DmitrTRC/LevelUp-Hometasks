namespace Lesson3.Models.Interface;

public interface IHasShelfLife
{
    DateTime ExpirationDate { get; set; }
}