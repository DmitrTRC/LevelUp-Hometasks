namespace Tests.Lesson2;

public class StudentTest
{
    [Fact]
    public void TestConstructor()
    {
        var student = new global::Lesson2.Models.Student("Dmitry", 1, 2);
        Assert.Equal("Dmitry", student.Name);
        Assert.Equal(1, student.GroupNumber);
        Assert.Equal(2, student.CourseNumber);
    }

    [Fact]
    public void TestPrintInfo()
    {
        var student = new global::Lesson2.Models.Student("Dmitry", 1, 2);
        var output = new StringWriter();
        Console.SetOut(output);
        student.PrintInfo();
        Assert.Equal("Name: Dmitry, Group: 1, Course: 2" + Environment.NewLine, output.ToString());
    }
}