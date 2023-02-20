using Lesson3.Models.Interface;

namespace Lesson3.Models.FoodDepartment;

public class Snack : Food, IHasShelfLife
{
    public DateTime ExpirationDate { get; set; }
}