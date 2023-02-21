using Lesson5;

namespace Tests.Lesson5;

public class ClearTest
{
    [Fact]
    public void TestClearString()
    {
        
        const string testString1 = " \tThis is \n a test string 123 ";
        const string testString2 = " \tTh%^is $is &* \n a test string 123 ";

        const string referenceString = "This is a test string 123";
        
        Assert.Equal(referenceString, testString1.Clear());
        Assert.Equal(referenceString, testString2.Clear());
    }
}