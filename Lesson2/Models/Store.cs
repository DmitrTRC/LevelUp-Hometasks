namespace Lesson2.Models;


public class Store
{
    private string Name { get; init; }
    private string Address { get; init; }

    public Store(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Address: {Address}");
    }
}