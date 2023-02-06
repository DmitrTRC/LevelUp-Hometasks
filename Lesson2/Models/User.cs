namespace Lesson2.Models;

public class User
{
    public User(string name, string surname, int age, string hobby)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Hobby = hobby;
    }

    string Name { get; init; }
    string Surname { get; set; }
    int Age { get; set; }
    string Hobby { get; set; }


    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Hobby: {Hobby}");
    }

    public override string ToString()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Hobby: {Hobby}";
    }
}