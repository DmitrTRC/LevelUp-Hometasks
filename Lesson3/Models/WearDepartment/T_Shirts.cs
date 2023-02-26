using Lesson3.Models.Interface;

namespace Lesson3.Models.WearDepartment;

public class T_Shirts : Wear, IHasGender
{
    public Gender Gender { get; set; } = Gender.Unisex;
    public string Color { get; set; } = "Unknown";
}