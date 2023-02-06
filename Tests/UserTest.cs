namespace Tests;

public class UserTest
{
    [Fact]
    public void TestConstructor()
    {
        var user = new Lesson2.Models.User("John", "Doe", 25, "Football");
        Assert.Equal("John", user.Name);
        Assert.Equal("Doe", user.Surname);
        Assert.Equal(25, user.Age);
        Assert.Equal("Football", user.Hobby);
    }
    
    [Fact]
    public void TestPrintInfo()
    {
        var user = new Lesson2.Models.User("John", "Doe", 25, "Football");
        var output = new StringWriter();
        Console.SetOut(output);
        user.PrintInfo();
        Assert.Equal("Name: John, Surname: Doe, Age: 25, Hobby: Football" + Environment.NewLine, output.ToString());
    }
}
        



