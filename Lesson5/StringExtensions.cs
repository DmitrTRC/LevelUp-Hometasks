using System.Text.RegularExpressions;

namespace Lesson5;

public static class StringExtensions
{
    public static string Clear(this string str)
    {
        char[] delimiterChars = {' ', '\t', '\n'};

        var resultArray = new Regex("[^a-zA-Z0-9 -]")
            .Replace(str, "")
            .Split(delimiterChars.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        return string.Join(" ", resultArray);
    }
}