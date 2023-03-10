namespace Lesson2.Models;

public record Engineer()
{
    public string Name { get; init; } = "Unknown";
    public string? Surname { get; set; }
    public int Age { get; set; }
    public string? Company { get; set; }
    public string? Position { get; set; }
    public int Salary { get; set; } = 1000;
}