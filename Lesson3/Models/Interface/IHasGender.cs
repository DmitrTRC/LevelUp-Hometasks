namespace Lesson3.Models.Interface;

public enum Gender
{
    Male,
    Female,
    Unisex
}

public interface IHasGender
{
    public Gender Gender { get; set; }
}