using Lesson2.Models;

namespace Lesson2;

public class Task1 : ISolution
{
    public void Task()
    {
        Console.WriteLine("Let's play with C#");

// 1. Sum two numbers from user input

        var firstNumberString = Console.ReadLine() ?? string.Empty;
        var secondNumberString = Console.ReadLine() ?? string.Empty;

        var firstNumber = int.Parse(firstNumberString);
        var secondNumber = int.Parse(secondNumberString);

        var thirdNumberString = Console.ReadLine() ?? string.Empty;
        if (int.TryParse(thirdNumberString, out var thirdNumber))
        {
            Console.WriteLine(thirdNumber);
        }

        Console.WriteLine(firstNumber + secondNumber);

// 2. Print string from input
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();
        Console.WriteLine(str1 + str2);

// 3. Concatenate strings
        Console.WriteLine("Hello, " + "C#");
        Console.WriteLine($"Current date/time is {DateTime.Now}");

// 4. Print interpolated string
        var weather = "+15 degrees";
        Console.WriteLine($"Current dt: {DateTime.Now}, weather is {weather}");

// 5. Print interpolated string with input
        var userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}");

// 6. Print current date and time
        Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));


// 7. Create a class Student
        var name = "Ivan Petrov";
        var groupNumber = 101;
        var courseNumber = 1;


        var student = new Student(name, groupNumber, courseNumber);

// 8. Print student's info
        Console.WriteLine($"Name: {student.Name}, Group: {student.GroupNumber}, Course: {student.CourseNumber}");
        student.PrintInfo();
        Console.WriteLine(student);

// 9. Create a record Engineer

        Engineer engineer = new Engineer
        {
            Name = "Ivan Petrov",
            Age = 25,
            Salary = 1000
        };

// 10. Modify record Engineer

        engineer.Salary = 2000;
        engineer.Company = "Google";
        engineer.Position = "Software Engineer";

        Console.WriteLine(engineer);


// 11. Let's practice
// Create a class Store with properties Name and Address.
// These properties should be set by constructor.
// Create a method PrintInfo to print store's name and address in one row.
// Create Store class instance. Use Console to fill Name and Address.

        Store store = new Store(Console.ReadLine() ?? string.Empty, Console.ReadLine() ?? string.Empty);

// Call PrintInfo method to print store's card.

        store.PrintInfo();

// 12. Try Garbage Collector
        var gcTest = new GarbageCollector();
        gcTest.TryCollect();
    }


    public void Run()
    {
        Console.WriteLine("Task1");
        Task();
    }
}