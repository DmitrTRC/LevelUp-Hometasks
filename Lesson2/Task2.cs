namespace Lesson2;

using Models;

public class Task2 : ISolution
{
 
    public void Run()
    {
        Console.Write("Name: ");
        string? userName = Console.ReadLine() ?? string.Empty;

        Console.Write("Surname: ");
        string userSurname = Console.ReadLine() ?? string.Empty;

        Console.Write("Age: ");
        int userAge;

        while (int.TryParse(Console.ReadLine(), out userAge) == false)
        {
            Console.Write("Incorrect input. Try again -> ");
        }


        Console.Write("Hobby: ");
        string userHobby = Console.ReadLine() ?? string.Empty;


        if (string.IsNullOrEmpty(userName))
        {
            Console.WriteLine("Name is null");
        }
        else
        {
            var user = new User(userName, userSurname, userAge, userHobby);

            Console.WriteLine("New user created: \n");

            Console.WriteLine("Using PrintInfo() method:");
            user.PrintInfo();

            Console.WriteLine("Using ToString() method:");
            Console.WriteLine(user);
        }
    }
}