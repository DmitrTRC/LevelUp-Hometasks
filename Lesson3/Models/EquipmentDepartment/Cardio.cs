using Lesson3.Models.Interface;

namespace Lesson3.Models.EquipmentDepartment;

public class Cardio : Equipment, IHasGrade
{
    public int MaxSpeed { get; set; } = 0;
    public int MaxIncline { get; set; } = 0;
}