namespace Lesson2;


public class Store
{
    public string Name { get; init; }
    public string Address { get; init; }

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