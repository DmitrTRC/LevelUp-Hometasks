using Lesson5;

namespace Tests.Lesson5;

public class ClearTest
{
    [Fact]
    public void TestClearString()
    {
        
        string testString1 = " \tThis is \n a test string 123 ";
        string testString2 = " \tTh%^is $is &* \n a test string 123 ";

        string referenceString = "This is a test string 123";
        
        Assert.Equal(referenceString, testString1.Clear());
        Assert.Equal(referenceString, testString2.Clear());
    }
}