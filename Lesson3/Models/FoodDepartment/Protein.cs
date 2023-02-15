namespace Lesson3.Models.FoodDepartment;

public class Protein : Food, IHasShelfLife
{
    public DateTime ExpirationDate { get; set; } = DateTime.Now.AddDays(180);

    public int ContainsPercent { get; set; } = 100;
}